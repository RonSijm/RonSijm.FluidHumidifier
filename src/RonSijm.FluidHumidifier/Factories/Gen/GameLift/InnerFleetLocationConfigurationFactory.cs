// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetLocationConfigurationFactory(Action<Humidifier.GameLift.FleetTypes.LocationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.LocationConfiguration>
{

    internal InnerFleetLocationCapacityFactory LocationCapacityFactory { get; set; }

    protected override Humidifier.GameLift.FleetTypes.LocationConfiguration Create()
    {
        var locationConfigurationResult = CreateLocationConfiguration();
        factoryAction?.Invoke(locationConfigurationResult);

        return locationConfigurationResult;
    }

    private Humidifier.GameLift.FleetTypes.LocationConfiguration CreateLocationConfiguration()
    {
        var locationConfigurationResult = new Humidifier.GameLift.FleetTypes.LocationConfiguration();

        return locationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.GameLift.FleetTypes.LocationConfiguration result)
    {
        base.CreateChildren(result);

        result.LocationCapacity ??= LocationCapacityFactory?.Build();
    }

} // End Of Class

public static class InnerFleetLocationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFleetLocationConfigurationFactory, InnerFleetLocationCapacityFactory> WithLocationCapacity(this InnerFleetLocationConfigurationFactory parentFactory, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null)
    {
        parentFactory.LocationCapacityFactory = new InnerFleetLocationCapacityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationCapacityFactory);
    }

    public static CombinedResult<InnerFleetLocationConfigurationFactory, T1, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1>(this CombinedResult<InnerFleetLocationConfigurationFactory, T1> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocationCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetLocationConfigurationFactory, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1>(this CombinedResult<T1, InnerFleetLocationConfigurationFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocationCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFleetLocationConfigurationFactory, T1, T2, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2>(this CombinedResult<InnerFleetLocationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetLocationConfigurationFactory, T2, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2>(this CombinedResult<T1, InnerFleetLocationConfigurationFactory, T2> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetLocationConfigurationFactory, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2>(this CombinedResult<T1, T2, InnerFleetLocationConfigurationFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFleetLocationConfigurationFactory, T1, T2, T3, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3>(this CombinedResult<InnerFleetLocationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetLocationConfigurationFactory, T2, T3, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3>(this CombinedResult<T1, InnerFleetLocationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetLocationConfigurationFactory, T3, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetLocationConfigurationFactory, T3> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetLocationConfigurationFactory, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetLocationConfigurationFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFleetLocationConfigurationFactory, T1, T2, T3, T4, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3, T4>(this CombinedResult<InnerFleetLocationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetLocationConfigurationFactory, T2, T3, T4, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetLocationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetLocationConfigurationFactory, T3, T4, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetLocationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetLocationConfigurationFactory, T4, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetLocationConfigurationFactory, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFleetLocationConfigurationFactory, InnerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetLocationConfigurationFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T5, subFactoryAction));
}
