// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessAgentCoreCodeInterpreterConfigFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreCodeInterpreterConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreCodeInterpreterConfig>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreCodeInterpreterConfig Create()
    {
        var harnessAgentCoreCodeInterpreterConfigResult = CreateHarnessAgentCoreCodeInterpreterConfig();
        factoryAction?.Invoke(harnessAgentCoreCodeInterpreterConfigResult);

        return harnessAgentCoreCodeInterpreterConfigResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreCodeInterpreterConfig CreateHarnessAgentCoreCodeInterpreterConfig()
    {
        var harnessAgentCoreCodeInterpreterConfigResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreCodeInterpreterConfig();

        return harnessAgentCoreCodeInterpreterConfigResult;
    }

} // End Of Class

public static class InnerHarnessHarnessAgentCoreCodeInterpreterConfigFactoryExtensions
{
}
