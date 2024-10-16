// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetMaintenanceStrategiesFactory(Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies>
{

    internal InnerEC2FleetCapacityRebalanceFactory CapacityRebalanceFactory { get; set; }

    protected override Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies Create()
    {
        var maintenanceStrategiesResult = CreateMaintenanceStrategies();
        factoryAction?.Invoke(maintenanceStrategiesResult);

        return maintenanceStrategiesResult;
    }

    private Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies CreateMaintenanceStrategies()
    {
        var maintenanceStrategiesResult = new Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies();

        return maintenanceStrategiesResult;
    }
    public override void CreateChildren(Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies result)
    {
        base.CreateChildren(result);

        result.CapacityRebalance ??= CapacityRebalanceFactory?.Build();
    }

} // End Of Class

public static class InnerEC2FleetMaintenanceStrategiesFactoryExtensions
{
    public static CombinedResult<InnerEC2FleetMaintenanceStrategiesFactory, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance(this InnerEC2FleetMaintenanceStrategiesFactory parentFactory, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null)
    {
        parentFactory.CapacityRebalanceFactory = new InnerEC2FleetCapacityRebalanceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityRebalanceFactory);
    }

    public static CombinedResult<InnerEC2FleetMaintenanceStrategiesFactory, T1, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1>(this CombinedResult<InnerEC2FleetMaintenanceStrategiesFactory, T1> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetMaintenanceStrategiesFactory, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1>(this CombinedResult<T1, InnerEC2FleetMaintenanceStrategiesFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEC2FleetMaintenanceStrategiesFactory, T1, T2, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2>(this CombinedResult<InnerEC2FleetMaintenanceStrategiesFactory, T1, T2> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetMaintenanceStrategiesFactory, T2, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2>(this CombinedResult<T1, InnerEC2FleetMaintenanceStrategiesFactory, T2> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetMaintenanceStrategiesFactory, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2>(this CombinedResult<T1, T2, InnerEC2FleetMaintenanceStrategiesFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEC2FleetMaintenanceStrategiesFactory, T1, T2, T3, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3>(this CombinedResult<InnerEC2FleetMaintenanceStrategiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetMaintenanceStrategiesFactory, T2, T3, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3>(this CombinedResult<T1, InnerEC2FleetMaintenanceStrategiesFactory, T2, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetMaintenanceStrategiesFactory, T3, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3>(this CombinedResult<T1, T2, InnerEC2FleetMaintenanceStrategiesFactory, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEC2FleetMaintenanceStrategiesFactory, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEC2FleetMaintenanceStrategiesFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEC2FleetMaintenanceStrategiesFactory, T1, T2, T3, T4, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3, T4>(this CombinedResult<InnerEC2FleetMaintenanceStrategiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetMaintenanceStrategiesFactory, T2, T3, T4, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3, T4>(this CombinedResult<T1, InnerEC2FleetMaintenanceStrategiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetMaintenanceStrategiesFactory, T3, T4, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEC2FleetMaintenanceStrategiesFactory, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEC2FleetMaintenanceStrategiesFactory, T4, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEC2FleetMaintenanceStrategiesFactory, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEC2FleetMaintenanceStrategiesFactory, InnerEC2FleetCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEC2FleetMaintenanceStrategiesFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T5, subFactoryAction));
}
