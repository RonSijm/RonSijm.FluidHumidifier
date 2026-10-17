// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetMetadataConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.MetadataConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.MetadataConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.MetadataConfiguration Create()
    {
        var metadataConfigurationResult = CreateMetadataConfiguration();
        factoryAction?.Invoke(metadataConfigurationResult);

        return metadataConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.MetadataConfiguration CreateMetadataConfiguration()
    {
        var metadataConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.MetadataConfiguration();

        return metadataConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayTargetMetadataConfigurationFactoryExtensions
{
}
