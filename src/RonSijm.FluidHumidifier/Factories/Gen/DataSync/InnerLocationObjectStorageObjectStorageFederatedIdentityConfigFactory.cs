// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory(Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageFederatedIdentityConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageFederatedIdentityConfig>
{

    internal InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory ExternalIdentityFactory { get; set; }

    protected override Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageFederatedIdentityConfig Create()
    {
        var objectStorageFederatedIdentityConfigResult = CreateObjectStorageFederatedIdentityConfig();
        factoryAction?.Invoke(objectStorageFederatedIdentityConfigResult);

        return objectStorageFederatedIdentityConfigResult;
    }

    private Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageFederatedIdentityConfig CreateObjectStorageFederatedIdentityConfig()
    {
        var objectStorageFederatedIdentityConfigResult = new Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageFederatedIdentityConfig();

        return objectStorageFederatedIdentityConfigResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageFederatedIdentityConfig result)
    {
        base.CreateChildren(result);

        result.ExternalIdentity ??= ExternalIdentityFactory?.Build();
    }

} // End Of Class

public static class InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactoryExtensions
{
    public static CombinedResult<InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity(this InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory parentFactory, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null)
    {
        parentFactory.ExternalIdentityFactory = new InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExternalIdentityFactory);
    }

    public static CombinedResult<InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T1, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1>(this CombinedResult<InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExternalIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1>(this CombinedResult<T1, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExternalIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T1, T2, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2>(this CombinedResult<InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T2, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2>(this CombinedResult<T1, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2>(this CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T1, T2, T3, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2, T3>(this CombinedResult<InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T2, T3, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2, T3>(this CombinedResult<T1, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T3, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2, T3>(this CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T1, T2, T3, T4, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2, T3, T4>(this CombinedResult<InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T2, T3, T4, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2, T3, T4>(this CombinedResult<T1, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T3, T4, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T4, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> WithExternalIdentity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLocationObjectStorageObjectStorageFederatedIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalIdentity(combinedResult.T5, subFactoryAction).T2);
}
