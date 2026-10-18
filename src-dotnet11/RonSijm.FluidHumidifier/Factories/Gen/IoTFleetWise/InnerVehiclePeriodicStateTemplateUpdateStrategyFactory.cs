// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerVehiclePeriodicStateTemplateUpdateStrategyFactory(Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy>
{

    internal InnerVehicleTimePeriodFactory StateTemplateUpdateRateFactory { get; set; }

    protected override Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy Create()
    {
        var periodicStateTemplateUpdateStrategyResult = CreatePeriodicStateTemplateUpdateStrategy();
        factoryAction?.Invoke(periodicStateTemplateUpdateStrategyResult);

        return periodicStateTemplateUpdateStrategyResult;
    }

    private Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy CreatePeriodicStateTemplateUpdateStrategy()
    {
        var periodicStateTemplateUpdateStrategyResult = new Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy();

        return periodicStateTemplateUpdateStrategyResult;
    }
    public override void CreateChildren(Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy result)
    {
        base.CreateChildren(result);

        result.StateTemplateUpdateRate ??= StateTemplateUpdateRateFactory?.Build();
    }

} // End Of Class

public static class InnerVehiclePeriodicStateTemplateUpdateStrategyFactoryExtensions
{
    public static CombinedResult<InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate(this InnerVehiclePeriodicStateTemplateUpdateStrategyFactory parentFactory, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null)
    {
        parentFactory.StateTemplateUpdateRateFactory = new InnerVehicleTimePeriodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StateTemplateUpdateRateFactory);
    }

    public static CombinedResult<InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T1, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1>(this CombinedResult<InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1>(this CombinedResult<T1, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T1, T2, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2>(this CombinedResult<InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T2, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2>(this CombinedResult<T1, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2>(this CombinedResult<T1, T2, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T1, T2, T3, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2, T3>(this CombinedResult<InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T2, T3, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2, T3>(this CombinedResult<T1, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T3, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2, T3>(this CombinedResult<T1, T2, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T1, T2, T3, T4, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2, T3, T4>(this CombinedResult<InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T2, T3, T4, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2, T3, T4>(this CombinedResult<T1, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T3, T4, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T4, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory, InnerVehicleTimePeriodFactory> WithStateTemplateUpdateRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStateTemplateUpdateRate(combinedResult.T5, subFactoryAction).T2);
}
