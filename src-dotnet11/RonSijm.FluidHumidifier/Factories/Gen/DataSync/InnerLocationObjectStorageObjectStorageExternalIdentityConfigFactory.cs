// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory(Action<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig>
{

    internal InnerLocationObjectStorageGoogleOidcConfigFactory GoogleOidcFactory { get; set; }

    protected override Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig Create()
    {
        var objectStorageExternalIdentityConfigResult = CreateObjectStorageExternalIdentityConfig();
        factoryAction?.Invoke(objectStorageExternalIdentityConfigResult);

        return objectStorageExternalIdentityConfigResult;
    }

    private Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig CreateObjectStorageExternalIdentityConfig()
    {
        var objectStorageExternalIdentityConfigResult = new Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig();

        return objectStorageExternalIdentityConfigResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationObjectStorageTypes.ObjectStorageExternalIdentityConfig result)
    {
        base.CreateChildren(result);

        result.GoogleOidc ??= GoogleOidcFactory?.Build();
    }

} // End Of Class

public static class InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactoryExtensions
{
    public static CombinedResult<InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc(this InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory parentFactory, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null)
    {
        parentFactory.GoogleOidcFactory = new InnerLocationObjectStorageGoogleOidcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GoogleOidcFactory);
    }

    public static CombinedResult<InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T1, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1>(this CombinedResult<InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithGoogleOidc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1>(this CombinedResult<T1, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithGoogleOidc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T1, T2, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2>(this CombinedResult<InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T2, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2>(this CombinedResult<T1, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2>(this CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T1, T2, T3, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2, T3>(this CombinedResult<InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T2, T3, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2, T3>(this CombinedResult<T1, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T3, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2, T3>(this CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T1, T2, T3, T4, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2, T3, T4>(this CombinedResult<InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T2, T3, T4, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2, T3, T4>(this CombinedResult<T1, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T3, T4, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T4, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory, InnerLocationObjectStorageGoogleOidcConfigFactory> WithGoogleOidc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLocationObjectStorageObjectStorageExternalIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGoogleOidc(combinedResult.T5, subFactoryAction).T2);
}
