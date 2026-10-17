using FruitVendor.AWS.NimbusFactory.CLI.Features.Helpers;

namespace FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ImageProcessor;

public class ImageProcessorStackComposer : BaseStackComposer<ImageProcessorStackConfig>
{
    public override StackCreateResult Create(ImageProcessorStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory.AddStack($"{Environment.EnvironmentName} Image Processing");

        var dropboxBucket = stack.WithS3Bucket($"{Environment.EnvironmentName}-image-dropbox");
        var processedBucket = stack.WithS3Bucket($"{Environment.EnvironmentName}-image-processed");
        var resizeBucket = stack.WithS3Bucket($"{Environment.EnvironmentName}-image-resize");
        var trashBucket = stack.WithS3Bucket($"{Environment.EnvironmentName}-image-trash");

        {
            var userDataEUBucketName = $"{Environment.EnvironmentName}-image-userdata-eu";
            var userDataEU = S3Helper.BucketWithPublicAccess(stack, userDataEUBucketName);
            S3Helper.WithPublicCloudFrontPolicy(stack, userDataEUBucketName, userDataEU);
            S3Helper.WithPublicCloudFront(stack, userDataEUBucketName, Environment, "userdata-eu");
        }


        {
            var userDataGlobalBucketName = $"{Environment.EnvironmentName}-image-userdata-global";
            var userDataGlobal = S3Helper.BucketWithPublicAccess(stack, userDataGlobalBucketName);
            S3Helper.WithPublicCloudFrontPolicy(stack, userDataGlobalBucketName, userDataGlobal);
            S3Helper.WithPublicCloudFront(stack, userDataGlobalBucketName, Environment, "userdata-global");
        }


        var export = new ExportModel();

        var stackResult = environmentFactory.Build().First();

        var result = new StackCreateResult
        {
            Stack = stackResult,
            Export = export
        };

        return result;
    }
}