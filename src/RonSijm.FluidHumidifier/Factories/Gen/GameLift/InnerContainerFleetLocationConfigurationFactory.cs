// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetLocationConfigurationFactory(Action<Humidifier.GameLift.ContainerFleetTypes.LocationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.LocationConfiguration>
{

    internal InnerContainerFleetLocationCapacityFactory LocationCapacityFactory { get; set; }

    protected override Humidifier.GameLift.ContainerFleetTypes.LocationConfiguration Create()
    {
        var locationConfigurationResult = CreateLocationConfiguration();
        factoryAction?.Invoke(locationConfigurationResult);

        return locationConfigurationResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.LocationConfiguration CreateLocationConfiguration()
    {
        var locationConfigurationResult = new Humidifier.GameLift.ContainerFleetTypes.LocationConfiguration();

        return locationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.GameLift.ContainerFleetTypes.LocationConfiguration result)
    {
        base.CreateChildren(result);

        result.LocationCapacity ??= LocationCapacityFactory?.Build();
    }

} // End Of Class

public static class InnerContainerFleetLocationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerContainerFleetLocationConfigurationFactory, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity(this InnerContainerFleetLocationConfigurationFactory parentFactory, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null)
    {
        parentFactory.LocationCapacityFactory = new InnerContainerFleetLocationCapacityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationCapacityFactory);
    }

    public static CombinedResult<InnerContainerFleetLocationConfigurationFactory, T1, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1>(this CombinedResult<InnerContainerFleetLocationConfigurationFactory, T1> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocationCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerFleetLocationConfigurationFactory, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1>(this CombinedResult<T1, InnerContainerFleetLocationConfigurationFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocationCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerContainerFleetLocationConfigurationFactory, T1, T2, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2>(this CombinedResult<InnerContainerFleetLocationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerFleetLocationConfigurationFactory, T2, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2>(this CombinedResult<T1, InnerContainerFleetLocationConfigurationFactory, T2> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerFleetLocationConfigurationFactory, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2>(this CombinedResult<T1, T2, InnerContainerFleetLocationConfigurationFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerContainerFleetLocationConfigurationFactory, T1, T2, T3, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3>(this CombinedResult<InnerContainerFleetLocationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerFleetLocationConfigurationFactory, T2, T3, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3>(this CombinedResult<T1, InnerContainerFleetLocationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerFleetLocationConfigurationFactory, T3, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3>(this CombinedResult<T1, T2, InnerContainerFleetLocationConfigurationFactory, T3> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerFleetLocationConfigurationFactory, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerContainerFleetLocationConfigurationFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerContainerFleetLocationConfigurationFactory, T1, T2, T3, T4, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3, T4>(this CombinedResult<InnerContainerFleetLocationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerFleetLocationConfigurationFactory, T2, T3, T4, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3, T4>(this CombinedResult<T1, InnerContainerFleetLocationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerFleetLocationConfigurationFactory, T3, T4, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerContainerFleetLocationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerFleetLocationConfigurationFactory, T4, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerContainerFleetLocationConfigurationFactory, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerContainerFleetLocationConfigurationFactory, InnerContainerFleetLocationCapacityFactory> WithLocationCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerContainerFleetLocationConfigurationFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocationCapacity(combinedResult.T5, subFactoryAction));
}
