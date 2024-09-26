// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationSMBFactory(string resourceName = null, Action<Humidifier.DataSync.LocationSMB> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationSMB>(resourceName)
{

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

        result.MountOptions ??= MountOptionsFactory?.Build();
    }

} // End Of Class

public static class LocationSMBFactoryExtensions
{
    public static CombinedResult<LocationSMBFactory, InnerLocationSMBMountOptionsFactory> WithMountOptions(this LocationSMBFactory parentFactory, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null)
    {
        parentFactory.MountOptionsFactory = new InnerLocationSMBMountOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MountOptionsFactory);
    }

    public static CombinedResult<LocationSMBFactory, T1, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<LocationSMBFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationSMBFactory, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1>(this CombinedResult<T1, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LocationSMBFactory, T1, T2, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<LocationSMBFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationSMBFactory, T2, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, LocationSMBFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationSMBFactory, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2>(this CombinedResult<T1, T2, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LocationSMBFactory, T1, T2, T3, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<LocationSMBFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationSMBFactory, T2, T3, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, LocationSMBFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationSMBFactory, T3, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, LocationSMBFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationSMBFactory, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LocationSMBFactory, T1, T2, T3, T4, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<LocationSMBFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LocationSMBFactory, T2, T3, T4, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, LocationSMBFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LocationSMBFactory, T3, T4, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationSMBFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LocationSMBFactory, T4, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationSMBFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LocationSMBFactory, InnerLocationSMBMountOptionsFactory> WithMountOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationSMBFactory> combinedResult, Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMountOptions(combinedResult.T5, subFactoryAction));
}
