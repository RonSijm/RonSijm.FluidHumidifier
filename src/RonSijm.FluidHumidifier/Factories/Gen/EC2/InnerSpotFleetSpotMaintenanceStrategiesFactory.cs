// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSpotFleetSpotMaintenanceStrategiesFactory(Action<Humidifier.EC2.SpotFleetTypes.SpotMaintenanceStrategies> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SpotFleetTypes.SpotMaintenanceStrategies>
{

    internal InnerSpotFleetSpotCapacityRebalanceFactory CapacityRebalanceFactory { get; set; }

    protected override Humidifier.EC2.SpotFleetTypes.SpotMaintenanceStrategies Create()
    {
        var spotMaintenanceStrategiesResult = CreateSpotMaintenanceStrategies();
        factoryAction?.Invoke(spotMaintenanceStrategiesResult);

        return spotMaintenanceStrategiesResult;
    }

    private Humidifier.EC2.SpotFleetTypes.SpotMaintenanceStrategies CreateSpotMaintenanceStrategies()
    {
        var spotMaintenanceStrategiesResult = new Humidifier.EC2.SpotFleetTypes.SpotMaintenanceStrategies();

        return spotMaintenanceStrategiesResult;
    }
    public override void CreateChildren(Humidifier.EC2.SpotFleetTypes.SpotMaintenanceStrategies result)
    {
        base.CreateChildren(result);

        result.CapacityRebalance ??= CapacityRebalanceFactory?.Build();
    }

} // End Of Class

public static class InnerSpotFleetSpotMaintenanceStrategiesFactoryExtensions
{
    public static CombinedResult<InnerSpotFleetSpotMaintenanceStrategiesFactory, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance(this InnerSpotFleetSpotMaintenanceStrategiesFactory parentFactory, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null)
    {
        parentFactory.CapacityRebalanceFactory = new InnerSpotFleetSpotCapacityRebalanceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityRebalanceFactory);
    }

    public static CombinedResult<InnerSpotFleetSpotMaintenanceStrategiesFactory, T1, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1>(this CombinedResult<InnerSpotFleetSpotMaintenanceStrategiesFactory, T1> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetSpotMaintenanceStrategiesFactory, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1>(this CombinedResult<T1, InnerSpotFleetSpotMaintenanceStrategiesFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpotFleetSpotMaintenanceStrategiesFactory, T1, T2, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2>(this CombinedResult<InnerSpotFleetSpotMaintenanceStrategiesFactory, T1, T2> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetSpotMaintenanceStrategiesFactory, T2, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2>(this CombinedResult<T1, InnerSpotFleetSpotMaintenanceStrategiesFactory, T2> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpotFleetSpotMaintenanceStrategiesFactory, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2>(this CombinedResult<T1, T2, InnerSpotFleetSpotMaintenanceStrategiesFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpotFleetSpotMaintenanceStrategiesFactory, T1, T2, T3, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3>(this CombinedResult<InnerSpotFleetSpotMaintenanceStrategiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetSpotMaintenanceStrategiesFactory, T2, T3, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3>(this CombinedResult<T1, InnerSpotFleetSpotMaintenanceStrategiesFactory, T2, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpotFleetSpotMaintenanceStrategiesFactory, T3, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpotFleetSpotMaintenanceStrategiesFactory, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpotFleetSpotMaintenanceStrategiesFactory, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpotFleetSpotMaintenanceStrategiesFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpotFleetSpotMaintenanceStrategiesFactory, T1, T2, T3, T4, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3, T4>(this CombinedResult<InnerSpotFleetSpotMaintenanceStrategiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetSpotMaintenanceStrategiesFactory, T2, T3, T4, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpotFleetSpotMaintenanceStrategiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpotFleetSpotMaintenanceStrategiesFactory, T3, T4, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpotFleetSpotMaintenanceStrategiesFactory, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpotFleetSpotMaintenanceStrategiesFactory, T4, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpotFleetSpotMaintenanceStrategiesFactory, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpotFleetSpotMaintenanceStrategiesFactory, InnerSpotFleetSpotCapacityRebalanceFactory> WithCapacityRebalance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpotFleetSpotMaintenanceStrategiesFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityRebalance(combinedResult.T5, subFactoryAction));
}
