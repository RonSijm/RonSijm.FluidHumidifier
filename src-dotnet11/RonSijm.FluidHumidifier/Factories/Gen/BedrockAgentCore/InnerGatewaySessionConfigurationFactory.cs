// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewaySessionConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.SessionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.SessionConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTypes.SessionConfiguration Create()
    {
        var sessionConfigurationResult = CreateSessionConfiguration();
        factoryAction?.Invoke(sessionConfigurationResult);

        return sessionConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.SessionConfiguration CreateSessionConfiguration()
    {
        var sessionConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTypes.SessionConfiguration();

        return sessionConfigurationResult;
    }

} // End Of Class

public static class InnerGatewaySessionConfigurationFactoryExtensions
{
}
