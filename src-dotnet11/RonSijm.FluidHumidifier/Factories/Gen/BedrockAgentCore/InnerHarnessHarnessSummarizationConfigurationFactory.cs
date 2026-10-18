// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessSummarizationConfigurationFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSummarizationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSummarizationConfiguration>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessSummarizationConfiguration Create()
    {
        var harnessSummarizationConfigurationResult = CreateHarnessSummarizationConfiguration();
        factoryAction?.Invoke(harnessSummarizationConfigurationResult);

        return harnessSummarizationConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessSummarizationConfiguration CreateHarnessSummarizationConfiguration()
    {
        var harnessSummarizationConfigurationResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessSummarizationConfiguration();

        return harnessSummarizationConfigurationResult;
    }

} // End Of Class

public static class InnerHarnessHarnessSummarizationConfigurationFactoryExtensions
{
}
