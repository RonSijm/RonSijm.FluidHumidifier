using FruitVendor.AWS.NimbusFactory.CLI.Core.Config;
using FruitVendor.AWS.NimbusFactory.CLI.Features.Helpers;

namespace FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.FrontendStack;

public class FrontendStackComposer : BaseStackComposer<FrontendStackConfig>
{
    public override StackCreateResult Create(FrontendStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();
        var stack = environmentFactory.AddStack($"Frontend");

        {
            var prodBucketName = $"{ResourceConfigSettings.ConceptNameLower}-frontend-prod";
            var s3BucketBucket = S3Helper.BucketWithPublicAccess(stack, prodBucketName, true);

            S3Helper.WithPublicCloudFrontPolicy(stack, prodBucketName, s3BucketBucket);
            S3Helper.WithPublicCloudFront(stack, prodBucketName, Environment);
        }

        {
            var devBucketName = $"{ResourceConfigSettings.ConceptNameLower}-frontend-dev";
            var devBucket = S3Helper.BucketWithPublicAccess(stack, devBucketName, true);

            S3Helper.WithPublicCloudFrontPolicy(stack, devBucketName, devBucket);
            S3Helper.WithPublicCloudFront(stack, devBucketName, Environment, "dev");
        }

        var stackResult = environmentFactory.Build().First();

        return new StackCreateResult
        {
            Stack = stackResult,
        };
    }
}