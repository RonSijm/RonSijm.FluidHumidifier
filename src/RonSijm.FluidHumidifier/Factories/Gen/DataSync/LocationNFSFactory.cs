// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationNFSFactory(string resourceName = null, Action<Humidifier.DataSync.LocationNFS> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationNFS>(resourceName)
{

    internal InnerLocationNFSMountOptionsFactory MountOptionsFactory { get; set; }

    internal InnerLocationNFSOnPremConfigFactory OnPremConfigFactory { get; set; }

    protected override Humidifier.DataSync.LocationNFS Create()
    {
        var locationNFSResult = CreateLocationNFS();
        factoryAction?.Invoke(locationNFSResult);

        return locationNFSResult;
    }

    private Humidifier.DataSync.LocationNFS CreateLocationNFS()
    {
        var locationNFSResult = new Humidifier.DataSync.LocationNFS
        {
            GivenName = InputResourceName,
        };

        return locationNFSResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationNFS result)
    {
        base.CreateChildren(result);

        result.MountOptions ??= MountOptionsFactory?.Build();
        result.OnPremConfig ??= OnPremConfigFactory?.Build();
    }

} // End Of Class

public static class LocationNFSFactoryExtensions
{
    public static CombinedResult<LocationNFSFactory, InnerLocationNFSMountOptionsFactory> WithMountOptions(this LocationNFSFactory parentFactory, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null)
    {
        parentFactory.MountOptionsFactory = new InnerLocationNFSMountOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MountOptionsFactory);
    }

    public static CombinedResult<LocationNFSFactory, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig(this LocationNFSFactory parentFactory, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null)
    {
        parentFactory.OnPremConfigFactory = new InnerLocationNFSOnPremConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OnPremConfigFactory);
    }

    public static CombinedResult<LocationNFSFactory, T1, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<LocationNFSFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationNFSFactory, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<T1, LocationNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LocationNFSFactory, T1, T2, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<LocationNFSFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationNFSFactory, T2, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, LocationNFSFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationNFSFactory, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, T2, LocationNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LocationNFSFactory, T1, T2, T3, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<LocationNFSFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationNFSFactory, T2, T3, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, LocationNFSFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationNFSFactory, T3, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, LocationNFSFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationNFSFactory, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LocationNFSFactory, T1, T2, T3, T4, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<LocationNFSFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationNFSFactory, T2, T3, T4, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, LocationNFSFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationNFSFactory, T3, T4, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationNFSFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationNFSFactory, T4, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationNFSFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LocationNFSFactory, InnerLocationNFSMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<LocationNFSFactory, T1, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1>(this CombinedResult<LocationNFSFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnPremConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationNFSFactory, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1>(this CombinedResult<T1, LocationNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnPremConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LocationNFSFactory, T1, T2, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2>(this CombinedResult<LocationNFSFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationNFSFactory, T2, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2>(this CombinedResult<T1, LocationNFSFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationNFSFactory, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2>(this CombinedResult<T1, T2, LocationNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LocationNFSFactory, T1, T2, T3, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2, T3>(this CombinedResult<LocationNFSFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationNFSFactory, T2, T3, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2, T3>(this CombinedResult<T1, LocationNFSFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationNFSFactory, T3, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2, T3>(this CombinedResult<T1, T2, LocationNFSFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationNFSFactory, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LocationNFSFactory, T1, T2, T3, T4, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2, T3, T4>(this CombinedResult<LocationNFSFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationNFSFactory, T2, T3, T4, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2, T3, T4>(this CombinedResult<T1, LocationNFSFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationNFSFactory, T3, T4, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationNFSFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationNFSFactory, T4, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationNFSFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LocationNFSFactory, InnerLocationNFSOnPremConfigFactory> WithOnPremConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationNFSFactory> combinedResult, Action<Humidifier.DataSync.LocationNFSTypes.OnPremConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnPremConfig(combinedResult.T5, subFactoryAction));
}
