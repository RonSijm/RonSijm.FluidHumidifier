// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowAggregationConfigFactory(Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.AggregationConfig>
{

    protected override Humidifier.AppFlow.FlowTypes.AggregationConfig Create()
    {
        var aggregationConfigResult = CreateAggregationConfig();
        factoryAction?.Invoke(aggregationConfigResult);

        return aggregationConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.AggregationConfig CreateAggregationConfig()
    {
        var aggregationConfigResult = new Humidifier.AppFlow.FlowTypes.AggregationConfig();

        return aggregationConfigResult;
    }

} // End Of Class

public static class InnerFlowAggregationConfigFactoryExtensions
{
}
