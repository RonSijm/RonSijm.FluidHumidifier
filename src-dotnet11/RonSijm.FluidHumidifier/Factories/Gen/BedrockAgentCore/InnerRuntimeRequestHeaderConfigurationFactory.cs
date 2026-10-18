// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeRequestHeaderConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.RequestHeaderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.RequestHeaderConfiguration>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.RequestHeaderConfiguration Create()
    {
        var requestHeaderConfigurationResult = CreateRequestHeaderConfiguration();
        factoryAction?.Invoke(requestHeaderConfigurationResult);

        return requestHeaderConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.RequestHeaderConfiguration CreateRequestHeaderConfiguration()
    {
        var requestHeaderConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.RequestHeaderConfiguration();

        return requestHeaderConfigurationResult;
    }

} // End Of Class

public static class InnerRuntimeRequestHeaderConfigurationFactoryExtensions
{
}
