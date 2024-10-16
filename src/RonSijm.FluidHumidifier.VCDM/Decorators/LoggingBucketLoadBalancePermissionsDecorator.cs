using Humidifier;
using Humidifier.S3;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Helpers.EC2;
using RonSijm.FluidHumidifier.Features.Resources;
using RonSijm.FluidHumidifier.VCDM.Helpers;

namespace RonSijm.FluidHumidifier.VCDM.Decorators
{
    /// <summary>
    /// https://docs.aws.amazon.com/elasticloadbalancing/latest/application/enable-access-logging.html#attach-bucket-policy
    /// </summary>
    public class LoggingBucketLoadBalancePermissionsDecorator : BaseDecorator, IWantEnvironmentName, IWantAWSRegion
    {
        public LoggingBucketLoadBalancePermissionsDecorator() : base(DecoratorType.AfterChildren)
        {
            _expectedEnvironmentName = new Lazy<string>(() => LoggingBucketNameFactory.GetBucketName(EnvironmentName));
        }

        private readonly Lazy<string> _expectedEnvironmentName;

        public override int Rank { get; set; }
        public override bool CanHandle(object target)
        {
            if (Disabled)
            {
                return false;
            }

            if (target is BucketPolicy bucketPolicy)
            {
                if (bucketPolicy.Bucket == _expectedEnvironmentName.Value)
                {
                    return true;
                }
            }

            return false;
        }

        public override void Decorate(object target)
        {
            Decorate(target as BucketPolicy);
        }

        public void Decorate(BucketPolicy target)
        {
            var policyDocument = target.PolicyDocument as PolicyDocument;

            if (policyDocument == null)
            {
                policyDocument = new PolicyDocument();
            }

            if (policyDocument.Statement == null)
            {
                policyDocument.Statement = new List<Statement>();
            }

            AddLoadBalancerAllowPolicy(policyDocument);
            AddGuarddutyAllowPolicy(policyDocument);
        }

        private void AddLoadBalancerAllowPolicy(PolicyDocument policyDocument)
        {
            var loggingAccountId = AWSLoadBalancerLoggingAccountLocator.GetAccountId(AWSRegion);

            policyDocument.Statement.Add(new Statement()
            {
                Sid = "Allow LoadBalancer Logging Account",
                Action = "s3:PutObject",
                Principal = new { AWS = $"arn:aws:iam::{loggingAccountId}:root" },
                Effect = "Allow",
                Resource = $"arn:aws:s3:::{_expectedEnvironmentName.Value}/*"
            });
        }

        private void AddGuarddutyAllowPolicy(PolicyDocument policyDocument)
        {
            policyDocument.Statement.Add(new Statement()
            {
                Sid = "Allow GuardDuty Get Bucket Location",
                Action = new[] { "s3:GetBucketLocation", "s3:ListBucket" },
                Principal = new { Service = "guardduty.amazonaws.com" },
                Effect = "Allow",
                Resource = $"arn:aws:s3:::{_expectedEnvironmentName.Value}",
                Condition = new Dictionary<string, Dictionary<string, dynamic>>
                {
                    ["StringEquals"] = new() { ["aws:SourceAccount"] = Fn.Sub("${AWS::AccountId}") },
                }
            });

            policyDocument.Statement.Add(new Statement()
            {
                Sid = "Allow GuardDuty PutObject",
                Action = "s3:PutObject",
                Principal = new { Service = "guardduty.amazonaws.com" },
                Effect = "Allow",
                Resource = $"arn:aws:s3:::{_expectedEnvironmentName.Value}/*",
                Condition = new Dictionary<string, Dictionary<string, dynamic>>
                {
                    ["StringEquals"] = new() { ["aws:SourceAccount"] = Fn.Sub("${AWS::AccountId}") },
                }
            });
        }

        public string EnvironmentName { get; set; }
        public string AWSRegion { get; set; }
    }
}
