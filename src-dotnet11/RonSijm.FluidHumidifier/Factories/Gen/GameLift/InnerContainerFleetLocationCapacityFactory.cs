// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetLocationCapacityFactory(Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity>
{

    internal InnerContainerFleetManagedCapacityConfigurationFactory ManagedCapacityConfigurationFactory { get; set; }

    protected override Humidifier.GameLift.ContainerFleetTypes.LocationCapacity Create()
    {
        var locationCapacityResult = CreateLocationCapacity();
        factoryAction?.Invoke(locationCapacityResult);

        return locationCapacityResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.LocationCapacity CreateLocationCapacity()
    {
        var locationCapacityResult = new Humidifier.GameLift.ContainerFleetTypes.LocationCapacity();

        return locationCapacityResult;
    }
    public override void CreateChildren(Humidifier.GameLift.ContainerFleetTypes.LocationCapacity result)
    {
        base.CreateChildren(result);

        result.ManagedCapacityConfiguration ??= ManagedCapacityConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerContainerFleetLocationCapacityFactoryExtensions
{
    public static CombinedResult<InnerContainerFleetLocationCapacityFactory, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration(this InnerContainerFleetLocationCapacityFactory parentFactory, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null)
    {
        parentFactory.ManagedCapacityConfigurationFactory = new InnerContainerFleetManagedCapacityConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManagedCapacityConfigurationFactory);
    }

    public static CombinedResult<InnerContainerFleetLocationCapacityFactory, T1, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1>(this CombinedResult<InnerContainerFleetLocationCapacityFactory, T1> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerContainerFleetLocationCapacityFactory, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1>(this CombinedResult<T1, InnerContainerFleetLocationCapacityFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerContainerFleetLocationCapacityFactory, T1, T2, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2>(this CombinedResult<InnerContainerFleetLocationCapacityFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerContainerFleetLocationCapacityFactory, T2, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2>(this CombinedResult<T1, InnerContainerFleetLocationCapacityFactory, T2> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerContainerFleetLocationCapacityFactory, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerContainerFleetLocationCapacityFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerContainerFleetLocationCapacityFactory, T1, T2, T3, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3>(this CombinedResult<InnerContainerFleetLocationCapacityFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerContainerFleetLocationCapacityFactory, T2, T3, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerContainerFleetLocationCapacityFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerContainerFleetLocationCapacityFactory, T3, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerContainerFleetLocationCapacityFactory, T3> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerContainerFleetLocationCapacityFactory, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerContainerFleetLocationCapacityFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerContainerFleetLocationCapacityFactory, T1, T2, T3, T4, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerContainerFleetLocationCapacityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerContainerFleetLocationCapacityFactory, T2, T3, T4, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerContainerFleetLocationCapacityFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerContainerFleetLocationCapacityFactory, T3, T4, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerContainerFleetLocationCapacityFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerContainerFleetLocationCapacityFactory, T4, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerContainerFleetLocationCapacityFactory, T4> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerContainerFleetLocationCapacityFactory, InnerContainerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerContainerFleetLocationCapacityFactory> combinedResult, Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T5, subFactoryAction).T2);
}
