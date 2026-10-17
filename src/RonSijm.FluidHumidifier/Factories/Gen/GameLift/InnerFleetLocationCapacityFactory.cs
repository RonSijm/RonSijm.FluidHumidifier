// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetLocationCapacityFactory(Action<Humidifier.GameLift.FleetTypes.LocationCapacity> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.LocationCapacity>
{

    internal InnerFleetManagedCapacityConfigurationFactory ManagedCapacityConfigurationFactory { get; set; }

    protected override Humidifier.GameLift.FleetTypes.LocationCapacity Create()
    {
        var locationCapacityResult = CreateLocationCapacity();
        factoryAction?.Invoke(locationCapacityResult);

        return locationCapacityResult;
    }

    private Humidifier.GameLift.FleetTypes.LocationCapacity CreateLocationCapacity()
    {
        var locationCapacityResult = new Humidifier.GameLift.FleetTypes.LocationCapacity();

        return locationCapacityResult;
    }
    public override void CreateChildren(Humidifier.GameLift.FleetTypes.LocationCapacity result)
    {
        base.CreateChildren(result);

        result.ManagedCapacityConfiguration ??= ManagedCapacityConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerFleetLocationCapacityFactoryExtensions
{
    public static CombinedResult<InnerFleetLocationCapacityFactory, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration(this InnerFleetLocationCapacityFactory parentFactory, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null)
    {
        parentFactory.ManagedCapacityConfigurationFactory = new InnerFleetManagedCapacityConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManagedCapacityConfigurationFactory);
    }

    public static CombinedResult<InnerFleetLocationCapacityFactory, T1, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1>(this CombinedResult<InnerFleetLocationCapacityFactory, T1> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFleetLocationCapacityFactory, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1>(this CombinedResult<T1, InnerFleetLocationCapacityFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFleetLocationCapacityFactory, T1, T2, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2>(this CombinedResult<InnerFleetLocationCapacityFactory, T1, T2> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFleetLocationCapacityFactory, T2, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2>(this CombinedResult<T1, InnerFleetLocationCapacityFactory, T2> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFleetLocationCapacityFactory, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFleetLocationCapacityFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFleetLocationCapacityFactory, T1, T2, T3, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3>(this CombinedResult<InnerFleetLocationCapacityFactory, T1, T2, T3> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFleetLocationCapacityFactory, T2, T3, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFleetLocationCapacityFactory, T2, T3> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFleetLocationCapacityFactory, T3, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetLocationCapacityFactory, T3> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFleetLocationCapacityFactory, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetLocationCapacityFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFleetLocationCapacityFactory, T1, T2, T3, T4, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFleetLocationCapacityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFleetLocationCapacityFactory, T2, T3, T4, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetLocationCapacityFactory, T2, T3, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFleetLocationCapacityFactory, T3, T4, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetLocationCapacityFactory, T3, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFleetLocationCapacityFactory, T4, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetLocationCapacityFactory, T4> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFleetLocationCapacityFactory, InnerFleetManagedCapacityConfigurationFactory> WithManagedCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetLocationCapacityFactory> combinedResult, Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedCapacityConfiguration(combinedResult.T5, subFactoryAction).T2);
}
