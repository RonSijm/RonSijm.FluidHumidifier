using Humidifier.ElasticLoadBalancingV2;
using Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes;
using Humidifier.S3;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;
using RonSijm.FluidHumidifier.VCDM.Helpers;

namespace RonSijm.FluidHumidifier.VCDM.Decorators
{
    public class LoadBalancerToSecurityTeamDecorator : BaseDecorator, IWantEnvironmentName
    {
        private readonly Lazy<string> _expectedEnvironmentName;

        public LoadBalancerToSecurityTeamDecorator() : base(DecoratorType.AfterChildren)
        {
            _expectedEnvironmentName = new Lazy<string>(() => LoggingBucketNameFactory.GetBucketName(EnvironmentName));
        }

        public override int Rank { get; set; }
        public override bool CanHandle(object target)
        {
            if (Disabled)
            {
                return false;
            }

            if (target is LoadBalancer)
            {
                return true;
            }

            if (target is Bucket bucket)
            {
                return bucket.BucketName == _expectedEnvironmentName.Value;
            }

            return false;
        }

        public override void Decorate(object target)
        {
            if (target is LoadBalancer loadBalancer)
            {
                Decorate(loadBalancer);
            }
            else if (target is Bucket bucket)
            {
                Decorate(bucket);
            }
        }

        private List<LoadBalancer> _loadBalancers = new();

        public void Decorate(LoadBalancer target)
        {
            if (target.LoadBalancerAttributes == null)
            {
                target.LoadBalancerAttributes = [];
            }

            // Access logs S3 bucket
            var accessLogBucket = target.LoadBalancerAttributes.FirstOrDefault(x => x.Key == "access_logs.s3.bucket");
            if (accessLogBucket == null)
            {
                accessLogBucket = new LoadBalancerAttribute { Key = "access_logs.s3.bucket" };
                target.LoadBalancerAttributes.Add(accessLogBucket);
            }
            accessLogBucket.Value = _expectedEnvironmentName.Value;

            // Access logs S3 prefix
            var accessLogPrefix = target.LoadBalancerAttributes.FirstOrDefault(x => x.Key == "access_logs.s3.prefix");
            if (accessLogPrefix == null)
            {
                accessLogPrefix = new LoadBalancerAttribute { Key = "access_logs.s3.prefix" };
                target.LoadBalancerAttributes.Add(accessLogPrefix);
            }
            accessLogPrefix.Value = $"LoadbalancerLogs/{LoggingBucketNameFactory.ConceptName}/AccessLogs";

            // Connection logs S3 enabled
            var connectionEnabled = target.LoadBalancerAttributes.FirstOrDefault(x => x.Key == "connection_logs.s3.enabled");
            if (connectionEnabled == null)
            {
                connectionEnabled = new LoadBalancerAttribute { Key = "connection_logs.s3.enabled" };
                target.LoadBalancerAttributes.Add(connectionEnabled);
            }
            connectionEnabled.Value = "true";

            // Connection logs S3 bucket
            var connectionLogBucket = target.LoadBalancerAttributes.FirstOrDefault(x => x.Key == "connection_logs.s3.bucket");
            if (connectionLogBucket == null)
            {
                connectionLogBucket = new LoadBalancerAttribute { Key = "connection_logs.s3.bucket" };
                target.LoadBalancerAttributes.Add(connectionLogBucket);
            }
            connectionLogBucket.Value = _expectedEnvironmentName.Value;

            // Connection logs S3 prefix
            var connectionLogPrefix = target.LoadBalancerAttributes.FirstOrDefault(x => x.Key == "connection_logs.s3.prefix");
            if (connectionLogPrefix == null)
            {
                connectionLogPrefix = new LoadBalancerAttribute { Key = "connection_logs.s3.prefix" };
                target.LoadBalancerAttributes.Add(connectionLogPrefix);
            }
            connectionLogPrefix.Value = $"LoadbalancerLogs/{LoggingBucketNameFactory.ConceptName}/ConnectionLogs";

            _loadBalancers.Add(target);
        }

        public void Decorate(Bucket target)
        {

        }

        public string EnvironmentName { get; set; }
    }
}