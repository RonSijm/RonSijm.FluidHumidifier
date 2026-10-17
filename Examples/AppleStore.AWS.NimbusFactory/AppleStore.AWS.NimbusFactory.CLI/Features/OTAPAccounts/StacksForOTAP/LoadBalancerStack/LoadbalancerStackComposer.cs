using RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;
using RonSijm.FluidHumidifier.VCDM.Helpers;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.LoadBalancerStack;

public class LoadBalancerStackComposer : BaseStackComposer<LoadbalancerStackConfig>
{
    public override StackCreateResult Create(LoadbalancerStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory
        .AddStack(ResourceConfigSettings.LoadBalancerName);

        var loggingBucketName = LoggingBucketNameFactory.GetBucketName(Environment);

        var loadBalancer = stack.WithElasticLoadBalancingV2LoadBalancer(ResourceConfigSettings.ConceptName, loadBalancer =>
            {
                loadBalancer.Scheme = "internet-facing";
                loadBalancer.Type = "application";
                loadBalancer.IpAddressType = "ipv4";
                loadBalancer.Subnets = config.LoadBalancerSubnets;
                loadBalancer.SecurityGroups = config.LoadBalancerSecurityGroups;
            }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "idle_timeout.timeout_seconds";
               x.Value = "240";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "deletion_protection.enabled";
               x.Value = "false";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "routing.http2.enabled";
               x.Value = "true";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "routing.http.drop_invalid_header_fields.enabled";
               x.Value = "false";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "routing.http.xff_client_port.enabled";
               x.Value = "true";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "routing.http.preserve_host_header.enabled";
               x.Value = "true";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "routing.http.xff_header_processing.mode";
               x.Value = "append";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "load_balancing.cross_zone.enabled";
               x.Value = "true";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "routing.http.desync_mitigation_mode";
               x.Value = "defensive";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "client_keep_alive.seconds";
               x.Value = "3600";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "waf.fail_open.enabled";
               x.Value = "false";
           }).WithLoadBalancerAttributes(x =>
           {
               x.Key = "routing.http.x_amzn_tls_version_and_cipher_suite.enabled";
               x.Value = "false";
           });

        var ecsTargetGroup = stack.WithElasticLoadBalancingV2TargetGroup(ResourceConfigSettings.ConceptName + "ecs-tg", targetGroup =>
            {
                targetGroup.HealthCheckIntervalSeconds = 300;
                targetGroup.HealthCheckPath = "/up";
                targetGroup.Port = 3000;
                targetGroup.Protocol = "HTTP";
                targetGroup.HealthCheckPort = "3000";
                targetGroup.HealthCheckProtocol = "HTTP";
                targetGroup.HealthCheckTimeoutSeconds = 30;
                targetGroup.UnhealthyThresholdCount = 2;
                targetGroup.TargetType = "ip";
                targetGroup.HealthyThresholdCount = 5;
                targetGroup.VpcId = config.VpcId;
                targetGroup.HealthCheckEnabled = true;
            }).WithMatcher(x => x.HttpCode = "200-499")
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "target_group_health.unhealthy_state_routing.minimum_healthy_targets.percentage";
                x.Value = "off";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "deregistration_delay.timeout_seconds";
                x.Value = "300";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "stickiness.type";
                x.Value = "lb_cookie";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "stickiness.lb_cookie.duration_seconds";
                x.Value = "86400";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "slow_start.duration_seconds";
                x.Value = "0";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "stickiness.app_cookie.duration_seconds";
                x.Value = "86400";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "target_group_health.dns_failover.minimum_healthy_targets.percentage";
                x.Value = "off";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "load_balancing.cross_zone.enabled";
                x.Value = "use_load_balancer_configuration";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "load_balancing.algorithm.type";
                x.Value = "round_robin";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "target_group_health.unhealthy_state_routing.minimum_healthy_targets.count";
                x.Value = "1";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "stickiness.enabled";
                x.Value = "false";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "target_group_health.dns_failover.minimum_healthy_targets.count";
                x.Value = "1";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "load_balancing.algorithm.anomaly_mitigation";
                x.Value = "off";
            })
            .WithTargetGroupAttributes(x =>
            {
                x.Key = "stickiness.app_cookie.cookie_name";
                x.Value = "";
            });


        stack.WithElasticLoadBalancingV2Listener(ResourceConfigSettings.LoadBalancerName + "-https-listener", listener =>
        {
            listener.Port = 443;
            listener.Protocol = "HTTPS";
            listener.LoadBalancerArn = loadBalancer.T1.FFnGetAtt("LoadBalancerArn");
            listener.DependsOn = loadBalancer.T1.FFNamedList();
        }).WithCertificates(x =>
        {
            x.CertificateArn = CertificateRetriever.GetCertificateArnFromRegion(Environment.EnvironmentName);
        }).WithDefaultActions(x =>
        {
            x.Order = 1;
            x.Type = "forward";
            x.TargetGroupArn = ecsTargetGroup.T1.FFnREF();
        });

        stack.WithRecordSet(record =>
        {
            record.HostedZoneName = $"{Environment.EnvironmentName}-applestore.example.";
            record.Type = "CNAME";
            record.Name = $"loadbalancer.{Environment.EnvironmentName}-applestore.example";
            record.TTL = 300;
            record.ResourceRecords = new List<dynamic>() { FFn.FFnGetAtt(loadBalancer.T1, "DNSName") };
        });

        var export = new ExportModel { ecsTargetGroup.T1 };

        var stackResult = environmentFactory.Build().First();

        var result = new StackCreateResult
        {
            Stack = stackResult,
            Export = export
        };

        return result;
    }
}