// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessSlidingWindowConfigurationFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSlidingWindowConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSlidingWindowConfiguration>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessSlidingWindowConfiguration Create()
    {
        var harnessSlidingWindowConfigurationResult = CreateHarnessSlidingWindowConfiguration();
        factoryAction?.Invoke(harnessSlidingWindowConfigurationResult);

        return harnessSlidingWindowConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessSlidingWindowConfiguration CreateHarnessSlidingWindowConfiguration()
    {
        var harnessSlidingWindowConfigurationResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessSlidingWindowConfiguration();

        return harnessSlidingWindowConfigurationResult;
    }

} // End Of Class

public static class InnerHarnessHarnessSlidingWindowConfigurationFactoryExtensions
{
}
