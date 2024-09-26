// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetSpotOptionsRequestFactory(Action<Humidifier.EC2.EC2FleetTypes.SpotOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.SpotOptionsRequest>
{

    internal InnerEC2FleetMaintenanceStrategiesFactory MaintenanceStrategiesFactory { get; set; }

    protected override Humidifier.EC2.EC2FleetTypes.SpotOptionsRequest Create()
    {
        var spotOptionsRequestResult = CreateSpotOptionsRequest();
        factoryAction?.Invoke(spotOptionsRequestResult);

        return spotOptionsRequestResult;
    }

    private Humidifier.EC2.EC2FleetTypes.SpotOptionsRequest CreateSpotOptionsRequest()
    {
        var spotOptionsRequestResult = new Humidifier.EC2.EC2FleetTypes.SpotOptionsRequest();

        return spotOptionsRequestResult;
    }
    public override void CreateChildren(Humidifier.EC2.EC2FleetTypes.SpotOptionsRequest result)
    {
        base.CreateChildren(result);

        result.MaintenanceStrategies ??= MaintenanceStrategiesFactory?.Build();
    }

} // End Of Class

public static class InnerEC2FleetSpotOptionsRequestFactoryExtensions
{
    public static CombinedResult<InnerEC2FleetSpotOptionsRequestFactory, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies(this InnerEC2FleetSpotOptionsRequestFactory parentFactory, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null)
    {
        parentFactory.MaintenanceStrategiesFactory = new InnerEC2FleetMaintenanceStrategiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MaintenanceStrategiesFactory);
    }

    public static CombinedResult<InnerEC2FleetSpotOptionsRequestFactory, T1, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1>(this CombinedResult<InnerEC2FleetSpotOptionsRequestFactory, T1> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetSpotOptionsRequestFactory, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1>(this CombinedResult<T1, InnerEC2FleetSpotOptionsRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEC2FleetSpotOptionsRequestFactory, T1, T2, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2>(this CombinedResult<InnerEC2FleetSpotOptionsRequestFactory, T1, T2> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetSpotOptionsRequestFactory, T2, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2>(this CombinedResult<T1, InnerEC2FleetSpotOptionsRequestFactory, T2> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetSpotOptionsRequestFactory, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2>(this CombinedResult<T1, T2, InnerEC2FleetSpotOptionsRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEC2FleetSpotOptionsRequestFactory, T1, T2, T3, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2, T3>(this CombinedResult<InnerEC2FleetSpotOptionsRequestFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetSpotOptionsRequestFactory, T2, T3, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2, T3>(this CombinedResult<T1, InnerEC2FleetSpotOptionsRequestFactory, T2, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetSpotOptionsRequestFactory, T3, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2, T3>(this CombinedResult<T1, T2, InnerEC2FleetSpotOptionsRequestFactory, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEC2FleetSpotOptionsRequestFactory, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEC2FleetSpotOptionsRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEC2FleetSpotOptionsRequestFactory, T1, T2, T3, T4, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2, T3, T4>(this CombinedResult<InnerEC2FleetSpotOptionsRequestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetSpotOptionsRequestFactory, T2, T3, T4, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2, T3, T4>(this CombinedResult<T1, InnerEC2FleetSpotOptionsRequestFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetSpotOptionsRequestFactory, T3, T4, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEC2FleetSpotOptionsRequestFactory, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEC2FleetSpotOptionsRequestFactory, T4, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEC2FleetSpotOptionsRequestFactory, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEC2FleetSpotOptionsRequestFactory, InnerEC2FleetMaintenanceStrategiesFactory> WithMaintenanceStrategies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEC2FleetSpotOptionsRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceStrategies(combinedResult.T5, subFactoryAction));
}
