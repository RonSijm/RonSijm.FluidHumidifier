// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeS3FilesAccessPointConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.S3FilesAccessPointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.S3FilesAccessPointConfiguration>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.S3FilesAccessPointConfiguration Create()
    {
        var s3FilesAccessPointConfigurationResult = CreateS3FilesAccessPointConfiguration();
        factoryAction?.Invoke(s3FilesAccessPointConfigurationResult);

        return s3FilesAccessPointConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.S3FilesAccessPointConfiguration CreateS3FilesAccessPointConfiguration()
    {
        var s3FilesAccessPointConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.S3FilesAccessPointConfiguration();

        return s3FilesAccessPointConfigurationResult;
    }

} // End Of Class

public static class InnerRuntimeS3FilesAccessPointConfigurationFactoryExtensions
{
}
