// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationFSxWindowsFactory(string resourceName = null, Action<Humidifier.DataSync.LocationFSxWindows> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationFSxWindows>(resourceName)
{

    internal InnerLocationFSxWindowsCmkSecretConfigFactory CmkSecretConfigFactory { get; set; }

    internal InnerLocationFSxWindowsCustomSecretConfigFactory CustomSecretConfigFactory { get; set; }

    protected override Humidifier.DataSync.LocationFSxWindows Create()
    {
        var locationFSxWindowsResult = CreateLocationFSxWindows();
        factoryAction?.Invoke(locationFSxWindowsResult);

        return locationFSxWindowsResult;
    }

    private Humidifier.DataSync.LocationFSxWindows CreateLocationFSxWindows()
    {
        var locationFSxWindowsResult = new Humidifier.DataSync.LocationFSxWindows
        {
            GivenName = InputResourceName,
        };

        return locationFSxWindowsResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationFSxWindows result)
    {
        base.CreateChildren(result);

        result.CmkSecretConfig ??= CmkSecretConfigFactory?.Build();
        result.CustomSecretConfig ??= CustomSecretConfigFactory?.Build();
    }

} // End Of Class

public static class LocationFSxWindowsFactoryExtensions
{
    public static CombinedResult<LocationFSxWindowsFactory, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig(this LocationFSxWindowsFactory parentFactory, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null)
    {
        parentFactory.CmkSecretConfigFactory = new InnerLocationFSxWindowsCmkSecretConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CmkSecretConfigFactory);
    }

    public static CombinedResult<LocationFSxWindowsFactory, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig(this LocationFSxWindowsFactory parentFactory, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null)
    {
        parentFactory.CustomSecretConfigFactory = new InnerLocationFSxWindowsCustomSecretConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomSecretConfigFactory);
    }

    public static CombinedResult<LocationFSxWindowsFactory, T1, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1>(this CombinedResult<LocationFSxWindowsFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationFSxWindowsFactory, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1>(this CombinedResult<T1, LocationFSxWindowsFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LocationFSxWindowsFactory, T1, T2, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2>(this CombinedResult<LocationFSxWindowsFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationFSxWindowsFactory, T2, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2>(this CombinedResult<T1, LocationFSxWindowsFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationFSxWindowsFactory, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2>(this CombinedResult<T1, T2, LocationFSxWindowsFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LocationFSxWindowsFactory, T1, T2, T3, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3>(this CombinedResult<LocationFSxWindowsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationFSxWindowsFactory, T2, T3, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3>(this CombinedResult<T1, LocationFSxWindowsFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationFSxWindowsFactory, T3, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, LocationFSxWindowsFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LocationFSxWindowsFactory, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationFSxWindowsFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LocationFSxWindowsFactory, T1, T2, T3, T4, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3, T4>(this CombinedResult<LocationFSxWindowsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationFSxWindowsFactory, T2, T3, T4, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, LocationFSxWindowsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationFSxWindowsFactory, T3, T4, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationFSxWindowsFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LocationFSxWindowsFactory, T4, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationFSxWindowsFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LocationFSxWindowsFactory, InnerLocationFSxWindowsCmkSecretConfigFactory> WithCmkSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationFSxWindowsFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CmkSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCmkSecretConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<LocationFSxWindowsFactory, T1, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1>(this CombinedResult<LocationFSxWindowsFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationFSxWindowsFactory, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1>(this CombinedResult<T1, LocationFSxWindowsFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LocationFSxWindowsFactory, T1, T2, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2>(this CombinedResult<LocationFSxWindowsFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationFSxWindowsFactory, T2, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2>(this CombinedResult<T1, LocationFSxWindowsFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationFSxWindowsFactory, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2>(this CombinedResult<T1, T2, LocationFSxWindowsFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LocationFSxWindowsFactory, T1, T2, T3, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3>(this CombinedResult<LocationFSxWindowsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationFSxWindowsFactory, T2, T3, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3>(this CombinedResult<T1, LocationFSxWindowsFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationFSxWindowsFactory, T3, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, LocationFSxWindowsFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LocationFSxWindowsFactory, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, LocationFSxWindowsFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LocationFSxWindowsFactory, T1, T2, T3, T4, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3, T4>(this CombinedResult<LocationFSxWindowsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LocationFSxWindowsFactory, T2, T3, T4, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, LocationFSxWindowsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LocationFSxWindowsFactory, T3, T4, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, LocationFSxWindowsFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LocationFSxWindowsFactory, T4, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LocationFSxWindowsFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LocationFSxWindowsFactory, InnerLocationFSxWindowsCustomSecretConfigFactory> WithCustomSecretConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LocationFSxWindowsFactory> combinedResult, Action<Humidifier.DataSync.LocationFSxWindowsTypes.CustomSecretConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomSecretConfig(combinedResult.T5, subFactoryAction).T2);
}
