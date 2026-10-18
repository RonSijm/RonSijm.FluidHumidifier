using Humidifier;
using Humidifier.S3;
using RonSijm.FluidHumidifier.Factories.S3;
using RonSijm.FluidHumidifier.Features.Factories.Base;
using RonSijm.FluidHumidifier.VCDM.Decorators;
using RonSijm.FluidHumidifier.VCDM.Helpers;

namespace RonSijm.FluidHumidifier.Tests;

public class UnionLoggingPolicyTests
{
    [Fact]
    public void LoggingPolicyRecognizesLiteralAndFactoryReferencedBuckets()
    {
        var decorator = new LoggingBucketLoadBalancePermissionsDecorator
        {
            EnvironmentName = "dev",
            AWSRegion = "eu-central-1"
        };
        var name = LoggingBucketNameFactory.GetBucketName("dev");
        var document = new PolicyDocument { Statement = [] };
        var policy = new BucketPolicy { Bucket = name, PolicyDocument = document };
        Assert.True(decorator.CanHandle(policy));

        var factory = new BucketFactory(name)
        {
            Stack = new Stack(),
            Decorator = new DecoratorOrchestrator([])
        };
        factory.Build();
        policy.Bucket = factory.FFnREF();
        Assert.True(decorator.CanHandle(policy));
        decorator.Decorate(policy);
        Assert.Equal(3, document.Statement.Count);
        Assert.Contains(document.Statement, statement => statement.Sid == "Allow LoadBalancer Logging Account");

        policy.Bucket = Fn.Ref("ExternalBucket");
        Assert.False(decorator.CanHandle(policy));
    }
}
