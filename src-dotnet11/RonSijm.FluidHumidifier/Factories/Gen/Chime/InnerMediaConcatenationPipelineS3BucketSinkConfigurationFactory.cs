// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration>
{

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration Create()
    {
        var s3BucketSinkConfigurationResult = CreateS3BucketSinkConfiguration();
        factoryAction?.Invoke(s3BucketSinkConfigurationResult);

        return s3BucketSinkConfigurationResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration CreateS3BucketSinkConfiguration()
    {
        var s3BucketSinkConfigurationResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration();

        return s3BucketSinkConfigurationResult;
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactoryExtensions
{
}
