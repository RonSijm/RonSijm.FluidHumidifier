// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerDatasetS3SourceFactory(Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.DatasetTypes.S3Source>
{

    protected override Humidifier.BedrockAgentCore.DatasetTypes.S3Source Create()
    {
        var s3SourceResult = CreateS3Source();
        factoryAction?.Invoke(s3SourceResult);

        return s3SourceResult;
    }

    private Humidifier.BedrockAgentCore.DatasetTypes.S3Source CreateS3Source()
    {
        var s3SourceResult = new Humidifier.BedrockAgentCore.DatasetTypes.S3Source();

        return s3SourceResult;
    }

} // End Of Class

public static class InnerDatasetS3SourceFactoryExtensions
{
}
