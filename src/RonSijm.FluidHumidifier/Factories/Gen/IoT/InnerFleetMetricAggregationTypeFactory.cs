// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerFleetMetricAggregationTypeFactory(Action<Humidifier.IoT.FleetMetricTypes.AggregationType> factoryAction = null) : SubResourceFactory<Humidifier.IoT.FleetMetricTypes.AggregationType>
{

    protected override Humidifier.IoT.FleetMetricTypes.AggregationType Create()
    {
        var aggregationTypeResult = CreateAggregationType();
        factoryAction?.Invoke(aggregationTypeResult);

        return aggregationTypeResult;
    }

    private Humidifier.IoT.FleetMetricTypes.AggregationType CreateAggregationType()
    {
        var aggregationTypeResult = new Humidifier.IoT.FleetMetricTypes.AggregationType();

        return aggregationTypeResult;
    }

} // End Of Class

public static class InnerFleetMetricAggregationTypeFactoryExtensions
{
}
