// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeEfsAccessPointConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.EfsAccessPointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.EfsAccessPointConfiguration>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.EfsAccessPointConfiguration Create()
    {
        var efsAccessPointConfigurationResult = CreateEfsAccessPointConfiguration();
        factoryAction?.Invoke(efsAccessPointConfigurationResult);

        return efsAccessPointConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.EfsAccessPointConfiguration CreateEfsAccessPointConfiguration()
    {
        var efsAccessPointConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.EfsAccessPointConfiguration();

        return efsAccessPointConfigurationResult;
    }

} // End Of Class

public static class InnerRuntimeEfsAccessPointConfigurationFactoryExtensions
{
}
