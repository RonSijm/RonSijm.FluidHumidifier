// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetS3CertificateConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3CertificateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3CertificateConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.S3CertificateConfiguration Create()
    {
        var s3CertificateConfigurationResult = CreateS3CertificateConfiguration();
        factoryAction?.Invoke(s3CertificateConfigurationResult);

        return s3CertificateConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.S3CertificateConfiguration CreateS3CertificateConfiguration()
    {
        var s3CertificateConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.S3CertificateConfiguration();

        return s3CertificateConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayTargetS3CertificateConfigurationFactoryExtensions
{
}
