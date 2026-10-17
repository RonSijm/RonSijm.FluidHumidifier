using RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

namespace FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ElasticBeanstalkStack;

public class ElasticBeanstalkStackComposer : BaseStackComposer<ElasticBeanstalkStackConfig>
{
    public override StackCreateResult Create(ElasticBeanstalkStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();
        var stack = environmentFactory.AddStack($"beanstalk");

        var ebRole = stack.WithRole("aws-elasticbeanstalk-ec2-role", roleConfig =>
        {
            roleConfig.ManagedPolicyArns = new List<dynamic>
            {
                "arn:aws:iam::aws:policy/AWSElasticBeanstalkWebTier",
                "arn:aws:iam::aws:policy/AWSElasticBeanstalkWorkerTier",
                "arn:aws:iam::aws:policy/AWSElasticBeanstalkMulticontainerDocker",
                "arn:aws:iam::aws:policy/AmazonEC2ContainerRegistryReadOnly",
                "arn:aws:iam::aws:policy/CloudWatchLogsFullAccess",
                "arn:aws:iam::aws:policy/AmazonRDSFullAccess" // Or replace with custom policy if needed
            };
        });

        ebRole.WithAssumeRolePolicy().WithStatement("sts:AssumeRole", principle: new
        {
            Service = "ec2.amazonaws.com"
        });

        var instanceProfile = stack.WithIAMInstanceProfile("aws-elasticbeanstalk-instanceprofile", profile =>
        {
            profile.InstanceProfileName = "aws-elasticbeanstalk-ec2-role";
            profile.Roles = new List<dynamic>
            {
                ebRole.FFnREF()
            };
            profile.ResourceName = "awselasticbeanstalkec2roleip";
        });

        // Create Elastic Beanstalk Application
        var application = stack.WithElasticBeanstalkApplication($"{Environment.EnvironmentName}-be", app =>
        {
            app.ApplicationName = $"{Environment.EnvironmentName}-be";
            app.Description = $"Elastic Beanstalk application for {Environment.EnvironmentName} environment";
        });

        var applicationVersion = stack.WithApplicationVersion($"{Environment.EnvironmentName}-be-version", app =>
        {
            app.ApplicationName = FFn.FFnREF(application);
            app.Description = $"Elastic Beanstalk application for {Environment.EnvironmentName} environment";
            app.DependsOn = application.FFNamedList();
        });

        applicationVersion.WithSourceBundle(source =>
        {
            source.S3Bucket = "aws-fruitvendor-prod-cloudformation-fruitvendor";
            source.S3Key = "DeploymentBundle-fruitvendor.example.zip";
        });

        // Create Elastic Beanstalk Environment
        var environment = stack.WithElasticBeanstalkEnvironment($"{Environment.EnvironmentName}-beanstalk", env =>
        {
            env.ApplicationName = application.FFnREF();
            env.EnvironmentName = $"{Environment.EnvironmentName}-beanstalk";
            env.SolutionStackName = config.SolutionStackName;
            env.DependsOn = instanceProfile.FFNamedList();
        });

        environment.WithTier(tier =>
        {
            tier.Name = "WebServer";
            tier.Type = "Standard";
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:autoscaling:launchconfiguration";
            options.OptionName = "InstanceType";
            options.Value = config.InstanceType;
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:autoscaling:launchconfiguration";
            options.OptionName = "IamInstanceProfile";
            options.Value = "aws-elasticbeanstalk-ec2-role";
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:autoscaling:launchconfiguration";
            options.OptionName = "EC2KeyName";
            options.Value = "fruitvendor_key";
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:autoscaling:asg";
            options.OptionName = "MinSize";
            options.Value = config.MinInstances.ToString();
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:autoscaling:asg";
            options.OptionName = "MaxSize";
            options.Value = config.MaxInstances.ToString();
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:elasticbeanstalk:environment";
            options.OptionName = "EnvironmentType";
            options.Value = config.EnableLoadBalancer ? "LoadBalanced" : "SingleInstance";
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:elasticbeanstalk:environment";
            options.OptionName = "LoadBalancerType";
            options.Value = "application";
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:ec2:vpc";
            options.OptionName = "VPCId";
            options.Value = config.VPCId.Value;
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:ec2:vpc";
            options.OptionName = "Subnets";
            options.Value = Fn.Join(",", config.Subnets.Value);
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:ec2:vpc";
            options.OptionName = "ELBSubnets";
            options.Value = Fn.Join(",", config.LoadBalancerSubnets.Value);
        });

        environment.WithOptionSettings(options =>
        {
            options.Namespace_ = "aws:ec2:vpc";
            options.OptionName = "AssociatePublicIpAddress";
            options.Value = "true";
        });

        //environment.WithOptionSettings(options =>
        //{
        //    options.Namespace_ = "aws:elbv2:listener:80";
        //    options.OptionName = "ListenerEnabled";
        //    options.Value = "false";
        //});

        //environment.WithOptionSettings(options =>
        //{
        //    options.Namespace_ = "aws:elbv2:listener:443";
        //    options.OptionName = "ListenerEnabled";
        //    options.Value = "true";
        //});

        //environment.WithOptionSettings(options =>
        //{
        //    options.Namespace_ = "aws:elbv2:listener:443";
        //    options.OptionName = "Protocol";
        //    options.Value = "HTTPS";
        //});

        //environment.WithOptionSettings(options =>
        //{
        //    options.Namespace_ = "aws:elbv2:listener:443";
        //    options.OptionName = "SSLPolicy";
        //    options.Value = "ELBSecurityPolicy-2016-08";
        //});

        //environment.WithOptionSettings(options =>
        //{
        //    options.Namespace_ = "aws:elbv2:listener:443";
        //    options.OptionName = "SSLCertificateArns";
        //    options.Value = "arn:aws:acm:us-east-1:666666666666:certificate/00000000-0000-0000-0000-000000000011";
        //});

        //environment.WithOptionSettings(options =>
        //{
        //    options.Namespace_ = "aws:autoscaling:launchconfiguration";
        //    options.OptionName = "SecurityGroups";
        //    options.Value = string.Join(",", config.SecurityGroups.Value);
        //});

        foreach (var envVar in config.EnvironmentVariables)
        {
            environment.WithOptionSettings(options =>
            {
                options.Namespace_ = "aws:elasticbeanstalk:application:environment";
                options.OptionName = envVar.Key;
                options.Value = envVar.Value;
            });
        }

        //stack.WithRecordSet(record =>
        //{
        //    record.HostedZoneName = $"fruitvendor.example.";
        //    record.Type = "CNAME";
        //    record.Name = $"api.fruitvendor.example";
        //    record.TTL = 300;
        //    record.ResourceRecords = new List<dynamic>() { FFn.FFnGetAtt(loadBalancer.T1, "DNSName") };
        //});

        var stackResult = environmentFactory.Build().First();

        return new StackCreateResult
        {
            Stack = stackResult,
        };
    }
}