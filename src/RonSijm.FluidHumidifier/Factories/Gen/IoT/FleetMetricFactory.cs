// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class FleetMetricFactory(string resourceName = null, Action<Humidifier.IoT.FleetMetric> factoryAction = null) : ResourceFactory<Humidifier.IoT.FleetMetric>(resourceName)
{

    internal InnerFleetMetricAggregationTypeFactory AggregationTypeFactory { get; set; }

    protected override Humidifier.IoT.FleetMetric Create()
    {
        var fleetMetricResult = CreateFleetMetric();
        factoryAction?.Invoke(fleetMetricResult);

        return fleetMetricResult;
    }

    private Humidifier.IoT.FleetMetric CreateFleetMetric()
    {
        var fleetMetricResult = new Humidifier.IoT.FleetMetric
        {
            GivenName = InputResourceName,
        };

        return fleetMetricResult;
    }
    public override void CreateChildren(Humidifier.IoT.FleetMetric result)
    {
        base.CreateChildren(result);

        result.AggregationType ??= AggregationTypeFactory?.Build();
    }

} // End Of Class

public static class FleetMetricFactoryExtensions
{
    public static CombinedResult<FleetMetricFactory, InnerFleetMetricAggregationTypeFactory> WithAggregationType(this FleetMetricFactory parentFactory, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null)
    {
        parentFactory.AggregationTypeFactory = new InnerFleetMetricAggregationTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AggregationTypeFactory);
    }

    public static CombinedResult<FleetMetricFactory, T1, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1>(this CombinedResult<FleetMetricFactory, T1> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, WithAggregationType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetMetricFactory, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1>(this CombinedResult<T1, FleetMetricFactory> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, WithAggregationType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FleetMetricFactory, T1, T2, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2>(this CombinedResult<FleetMetricFactory, T1, T2> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetMetricFactory, T2, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2>(this CombinedResult<T1, FleetMetricFactory, T2> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetMetricFactory, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2>(this CombinedResult<T1, T2, FleetMetricFactory> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FleetMetricFactory, T1, T2, T3, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2, T3>(this CombinedResult<FleetMetricFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetMetricFactory, T2, T3, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2, T3>(this CombinedResult<T1, FleetMetricFactory, T2, T3> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetMetricFactory, T3, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2, T3>(this CombinedResult<T1, T2, FleetMetricFactory, T3> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetMetricFactory, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2, T3>(this CombinedResult<T1, T2, T3, FleetMetricFactory> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FleetMetricFactory, T1, T2, T3, T4, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2, T3, T4>(this CombinedResult<FleetMetricFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FleetMetricFactory, T2, T3, T4, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2, T3, T4>(this CombinedResult<T1, FleetMetricFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FleetMetricFactory, T3, T4, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2, T3, T4>(this CombinedResult<T1, T2, FleetMetricFactory, T3, T4> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FleetMetricFactory, T4, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FleetMetricFactory, T4> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FleetMetricFactory, InnerFleetMetricAggregationTypeFactory> WithAggregationType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FleetMetricFactory> combinedResult, Action<Humidifier.IoT.FleetMetricTypes.AggregationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationType(combinedResult.T5, subFactoryAction));
}
