// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerBrowserCustomS3LocationFactory(Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location>
{

    protected override Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerBrowserCustomS3LocationFactoryExtensions
{
}
