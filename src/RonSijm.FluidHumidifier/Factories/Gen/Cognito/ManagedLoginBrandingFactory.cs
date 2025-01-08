// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class ManagedLoginBrandingFactory(string resourceName = null, Action<Humidifier.Cognito.ManagedLoginBranding> factoryAction = null) : ResourceFactory<Humidifier.Cognito.ManagedLoginBranding>(resourceName)
{

    internal List<InnerManagedLoginBrandingAssetTypeFactory> AssetsFactories { get; set; } = [];

    protected override Humidifier.Cognito.ManagedLoginBranding Create()
    {
        var managedLoginBrandingResult = CreateManagedLoginBranding();
        factoryAction?.Invoke(managedLoginBrandingResult);

        return managedLoginBrandingResult;
    }

    private Humidifier.Cognito.ManagedLoginBranding CreateManagedLoginBranding()
    {
        var managedLoginBrandingResult = new Humidifier.Cognito.ManagedLoginBranding
        {
            GivenName = InputResourceName,
        };

        return managedLoginBrandingResult;
    }
    public override void CreateChildren(Humidifier.Cognito.ManagedLoginBranding result)
    {
        base.CreateChildren(result);

        result.Assets = AssetsFactories.Any() ? AssetsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ManagedLoginBrandingFactoryExtensions
{
    public static CombinedResult<ManagedLoginBrandingFactory, InnerManagedLoginBrandingAssetTypeFactory> WithAssets(this ManagedLoginBrandingFactory parentFactory, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null)
    {
        var factory = new InnerManagedLoginBrandingAssetTypeFactory(subFactoryAction);
        parentFactory.AssetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ManagedLoginBrandingFactory, T1, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1>(this CombinedResult<ManagedLoginBrandingFactory, T1> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ManagedLoginBrandingFactory, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1>(this CombinedResult<T1, ManagedLoginBrandingFactory> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ManagedLoginBrandingFactory, T1, T2, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2>(this CombinedResult<ManagedLoginBrandingFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ManagedLoginBrandingFactory, T2, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2>(this CombinedResult<T1, ManagedLoginBrandingFactory, T2> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ManagedLoginBrandingFactory, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2>(this CombinedResult<T1, T2, ManagedLoginBrandingFactory> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ManagedLoginBrandingFactory, T1, T2, T3, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2, T3>(this CombinedResult<ManagedLoginBrandingFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ManagedLoginBrandingFactory, T2, T3, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2, T3>(this CombinedResult<T1, ManagedLoginBrandingFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ManagedLoginBrandingFactory, T3, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2, T3>(this CombinedResult<T1, T2, ManagedLoginBrandingFactory, T3> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ManagedLoginBrandingFactory, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2, T3>(this CombinedResult<T1, T2, T3, ManagedLoginBrandingFactory> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ManagedLoginBrandingFactory, T1, T2, T3, T4, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2, T3, T4>(this CombinedResult<ManagedLoginBrandingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ManagedLoginBrandingFactory, T2, T3, T4, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2, T3, T4>(this CombinedResult<T1, ManagedLoginBrandingFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ManagedLoginBrandingFactory, T3, T4, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2, T3, T4>(this CombinedResult<T1, T2, ManagedLoginBrandingFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ManagedLoginBrandingFactory, T4, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ManagedLoginBrandingFactory, T4> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ManagedLoginBrandingFactory, InnerManagedLoginBrandingAssetTypeFactory> WithAssets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ManagedLoginBrandingFactory> combinedResult, Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssets(combinedResult.T5, subFactoryAction));
}
