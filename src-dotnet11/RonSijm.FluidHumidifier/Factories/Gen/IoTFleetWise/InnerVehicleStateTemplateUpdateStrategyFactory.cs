// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerVehicleStateTemplateUpdateStrategyFactory(Action<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy>
{

    internal InnerVehiclePeriodicStateTemplateUpdateStrategyFactory PeriodicFactory { get; set; }

    protected override Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy Create()
    {
        var stateTemplateUpdateStrategyResult = CreateStateTemplateUpdateStrategy();
        factoryAction?.Invoke(stateTemplateUpdateStrategyResult);

        return stateTemplateUpdateStrategyResult;
    }

    private Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy CreateStateTemplateUpdateStrategy()
    {
        var stateTemplateUpdateStrategyResult = new Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy();

        return stateTemplateUpdateStrategyResult;
    }
    public override void CreateChildren(Humidifier.IoTFleetWise.VehicleTypes.StateTemplateUpdateStrategy result)
    {
        base.CreateChildren(result);

        result.Periodic ??= PeriodicFactory?.Build();
    }

} // End Of Class

public static class InnerVehicleStateTemplateUpdateStrategyFactoryExtensions
{
    public static CombinedResult<InnerVehicleStateTemplateUpdateStrategyFactory, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic(this InnerVehicleStateTemplateUpdateStrategyFactory parentFactory, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null)
    {
        parentFactory.PeriodicFactory = new InnerVehiclePeriodicStateTemplateUpdateStrategyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PeriodicFactory);
    }

    public static CombinedResult<InnerVehicleStateTemplateUpdateStrategyFactory, T1, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1>(this CombinedResult<InnerVehicleStateTemplateUpdateStrategyFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPeriodic(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehicleStateTemplateUpdateStrategyFactory, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1>(this CombinedResult<T1, InnerVehicleStateTemplateUpdateStrategyFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPeriodic(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerVehicleStateTemplateUpdateStrategyFactory, T1, T2, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2>(this CombinedResult<InnerVehicleStateTemplateUpdateStrategyFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehicleStateTemplateUpdateStrategyFactory, T2, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2>(this CombinedResult<T1, InnerVehicleStateTemplateUpdateStrategyFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVehicleStateTemplateUpdateStrategyFactory, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2>(this CombinedResult<T1, T2, InnerVehicleStateTemplateUpdateStrategyFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerVehicleStateTemplateUpdateStrategyFactory, T1, T2, T3, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2, T3>(this CombinedResult<InnerVehicleStateTemplateUpdateStrategyFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehicleStateTemplateUpdateStrategyFactory, T2, T3, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2, T3>(this CombinedResult<T1, InnerVehicleStateTemplateUpdateStrategyFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVehicleStateTemplateUpdateStrategyFactory, T3, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2, T3>(this CombinedResult<T1, T2, InnerVehicleStateTemplateUpdateStrategyFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerVehicleStateTemplateUpdateStrategyFactory, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVehicleStateTemplateUpdateStrategyFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerVehicleStateTemplateUpdateStrategyFactory, T1, T2, T3, T4, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2, T3, T4>(this CombinedResult<InnerVehicleStateTemplateUpdateStrategyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVehicleStateTemplateUpdateStrategyFactory, T2, T3, T4, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2, T3, T4>(this CombinedResult<T1, InnerVehicleStateTemplateUpdateStrategyFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVehicleStateTemplateUpdateStrategyFactory, T3, T4, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVehicleStateTemplateUpdateStrategyFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerVehicleStateTemplateUpdateStrategyFactory, T4, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVehicleStateTemplateUpdateStrategyFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerVehicleStateTemplateUpdateStrategyFactory, InnerVehiclePeriodicStateTemplateUpdateStrategyFactory> WithPeriodic<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVehicleStateTemplateUpdateStrategyFactory> combinedResult, Action<Humidifier.IoTFleetWise.VehicleTypes.PeriodicStateTemplateUpdateStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPeriodic(combinedResult.T5, subFactoryAction).T2);
}
