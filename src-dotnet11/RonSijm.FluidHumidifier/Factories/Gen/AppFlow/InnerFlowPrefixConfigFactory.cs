// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowPrefixConfigFactory(Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.PrefixConfig>
{

    protected override Humidifier.AppFlow.FlowTypes.PrefixConfig Create()
    {
        var prefixConfigResult = CreatePrefixConfig();
        factoryAction?.Invoke(prefixConfigResult);

        return prefixConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.PrefixConfig CreatePrefixConfig()
    {
        var prefixConfigResult = new Humidifier.AppFlow.FlowTypes.PrefixConfig();

        return prefixConfigResult;
    }

} // End Of Class

public static class InnerFlowPrefixConfigFactoryExtensions
{
}
