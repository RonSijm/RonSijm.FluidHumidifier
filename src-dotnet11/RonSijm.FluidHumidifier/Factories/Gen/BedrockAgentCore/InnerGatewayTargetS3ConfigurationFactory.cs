// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetS3ConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration Create()
    {
        var s3ConfigurationResult = CreateS3Configuration();
        factoryAction?.Invoke(s3ConfigurationResult);

        return s3ConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration CreateS3Configuration()
    {
        var s3ConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration();

        return s3ConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayTargetS3ConfigurationFactoryExtensions
{
}
