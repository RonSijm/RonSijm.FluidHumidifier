// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetSecretsManagerCertificateConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.SecretsManagerCertificateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.SecretsManagerCertificateConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.SecretsManagerCertificateConfiguration Create()
    {
        var secretsManagerCertificateConfigurationResult = CreateSecretsManagerCertificateConfiguration();
        factoryAction?.Invoke(secretsManagerCertificateConfigurationResult);

        return secretsManagerCertificateConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.SecretsManagerCertificateConfiguration CreateSecretsManagerCertificateConfiguration()
    {
        var secretsManagerCertificateConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.SecretsManagerCertificateConfiguration();

        return secretsManagerCertificateConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayTargetSecretsManagerCertificateConfigurationFactoryExtensions
{
}
