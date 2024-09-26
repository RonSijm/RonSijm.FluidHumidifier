// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowIncrementalPullConfigFactory(Action<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig>
{

    protected override Humidifier.AppFlow.FlowTypes.IncrementalPullConfig Create()
    {
        var incrementalPullConfigResult = CreateIncrementalPullConfig();
        factoryAction?.Invoke(incrementalPullConfigResult);

        return incrementalPullConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.IncrementalPullConfig CreateIncrementalPullConfig()
    {
        var incrementalPullConfigResult = new Humidifier.AppFlow.FlowTypes.IncrementalPullConfig();

        return incrementalPullConfigResult;
    }

} // End Of Class

public static class InnerFlowIncrementalPullConfigFactoryExtensions
{
}
