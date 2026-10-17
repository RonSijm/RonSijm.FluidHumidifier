// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationSMBFactory(string resourceName = null, Action<Humidifier.DataSync.LocationSMB> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationSMB>(resourceName)
{

    internal InnerLocationSMBCmkSecretConfigFactory CmkSecretConfigFactory { get; set; }

    internal InnerLocationSMBCustomSecretConfigFactory CustomSecretConfigFactory { get; set; }

    internal InnerLocationSMBMountOptionsFactory MountOptionsFactory { get; set; }

    protected override Humidifier.DataSync.LocationSMB Create()
    {
        var locationSMBResult = CreateLocationSMB();
        factoryAction?.Invoke(locationSMBResult);

        return locationSMBResult;
    }

    private Humidifier.DataSync.LocationSMB CreateLocationSMB()
    {
        var locationSMBResult = new Humidifier.DataSync.LocationSMB
        {
            GivenName = InputResourceName,
        };

        return locationSMBResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationSMB result)
    {
        base.CreateChildren(result);

        result.CmkSecretConfig ??= CmkSecretConfigFactory?.Build();
        result.CustomSecretConfig ??= CustomSecretConfigFactory?.Build();
        result.MountOptions ??= MountOptionsFactory?.Build();
    }

} // End Of Class

public static class LocationSMBFactoryExtensions
{
    public static CombinedResult<LocationSMBFactory, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig(this LocationSMBFactory parentFactory, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null)
    {
        parentFactory.CmkSecretConfigFactory = new InnerLocationSMBCmkSecretConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CmkSecretConfigFactory);
    }

    public static CombinedResult<LocationSMBFactory, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig(this LocationSMBFactory parentFactory, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null)
    {
        parentFactory.CustomSecretConfigFactory = new InnerLocationSMBCustomSecretConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomSecretConfigFactory);
    }

    public static CombinedResult<LocationSMBFactory, InnerLocationSMBMountOptionsFactory> WithMountOptions(this LocationSMBFactory parentFactory, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null)
    {
        parentFactory.MountOptionsFactory = new InnerLocationSMBMountOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MountOptionsFactory);
    }

    public static CombinedResult<LocationSMBFactory, T1, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1>(this CombinedResult<LocationSMBFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1>(this CombinedResult<T1, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, T2, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2>(this CombinedResult<LocationSMBFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, T2, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2>(this CombinedResult<T1, LocationSMBFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationSMBFactory, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2>(this CombinedResult<T1, T2, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, T2, T3, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3>(this CombinedResult<LocationSMBFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, T2, T3, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3>(this CombinedResult<T1, LocationSMBFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationSMBFactory, T3, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, LocationSMBFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LocationSMBFactory, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, T2, T3, T4, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3, T4>(this CombinedResult<LocationSMBFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, T2, T3, T4, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, LocationSMBFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationSMBFactory, T3, T4, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationSMBFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LocationSMBFactory, T4, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationSMBFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LocationSMBFactory, InnerLocationSMBCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1>(this CombinedResult<LocationSMBFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1>(this CombinedResult<T1, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, T2, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2>(this CombinedResult<LocationSMBFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, T2, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2>(this CombinedResult<T1, LocationSMBFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationSMBFactory, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2>(this CombinedResult<T1, T2, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, T2, T3, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3>(this CombinedResult<LocationSMBFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, T2, T3, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3>(this CombinedResult<T1, LocationSMBFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationSMBFactory, T3, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, LocationSMBFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LocationSMBFactory, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, T2, T3, T4, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3, T4>(this CombinedResult<LocationSMBFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, T2, T3, T4, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, LocationSMBFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationSMBFactory, T3, T4, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationSMBFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LocationSMBFactory, T4, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationSMBFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LocationSMBFactory, InnerLocationSMBCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<LocationSMBFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<T1, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, T2, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<LocationSMBFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, T2, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, LocationSMBFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationSMBFactory, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, T2, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, T2, T3, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<LocationSMBFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, T2, T3, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, LocationSMBFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationSMBFactory, T3, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, LocationSMBFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LocationSMBFactory, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LocationSMBFactory, T1, T2, T3, T4, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<LocationSMBFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationSMBFactory, T2, T3, T4, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, LocationSMBFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationSMBFactory, T3, T4, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationSMBFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LocationSMBFactory, T4, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationSMBFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LocationSMBFactory, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T5, subFactoryAction).T2);
}
