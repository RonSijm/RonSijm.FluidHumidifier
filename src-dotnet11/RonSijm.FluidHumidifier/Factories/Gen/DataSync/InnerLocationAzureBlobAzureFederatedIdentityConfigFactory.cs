// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationAzureBlobAzureFederatedIdentityConfigFactory(Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureFederatedIdentityConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationAzureBlobTypes.AzureFederatedIdentityConfig>
{

    internal InnerLocationAzureBlobAzureOidcConfigFactory AzureOidcFactory { get; set; }

    protected override Humidifier.DataSync.LocationAzureBlobTypes.AzureFederatedIdentityConfig Create()
    {
        var azureFederatedIdentityConfigResult = CreateAzureFederatedIdentityConfig();
        factoryAction?.Invoke(azureFederatedIdentityConfigResult);

        return azureFederatedIdentityConfigResult;
    }

    private Humidifier.DataSync.LocationAzureBlobTypes.AzureFederatedIdentityConfig CreateAzureFederatedIdentityConfig()
    {
        var azureFederatedIdentityConfigResult = new Humidifier.DataSync.LocationAzureBlobTypes.AzureFederatedIdentityConfig();

        return azureFederatedIdentityConfigResult;
    }
    public override void CreateChildren(Humidifier.DataSync.LocationAzureBlobTypes.AzureFederatedIdentityConfig result)
    {
        base.CreateChildren(result);

        result.AzureOidc ??= AzureOidcFactory?.Build();
    }

} // End Of Class

public static class InnerLocationAzureBlobAzureFederatedIdentityConfigFactoryExtensions
{
    public static CombinedResult<InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc(this InnerLocationAzureBlobAzureFederatedIdentityConfigFactory parentFactory, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null)
    {
        parentFactory.AzureOidcFactory = new InnerLocationAzureBlobAzureOidcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AzureOidcFactory);
    }

    public static CombinedResult<InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T1, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1>(this CombinedResult<InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T1> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzureOidc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1>(this CombinedResult<T1, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAzureOidc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T1, T2, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2>(this CombinedResult<InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T2, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2>(this CombinedResult<T1, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T2> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2>(this CombinedResult<T1, T2, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T1, T2, T3, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2, T3>(this CombinedResult<InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T2, T3, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2, T3>(this CombinedResult<T1, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T3, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2, T3>(this CombinedResult<T1, T2, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T3> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T1, T2, T3, T4, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2, T3, T4>(this CombinedResult<InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T2, T3, T4, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2, T3, T4>(this CombinedResult<T1, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T3, T4, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T4, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, T4> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory, InnerLocationAzureBlobAzureOidcConfigFactory> WithAzureOidc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLocationAzureBlobAzureFederatedIdentityConfigFactory> combinedResult, Action<Humidifier.DataSync.LocationAzureBlobTypes.AzureOidcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAzureOidc(combinedResult.T5, subFactoryAction).T2);
}
