// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class AssetFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.Asset> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.Asset>(resourceName)
{

    internal List<InnerAssetAssetPropertyFactory> AssetPropertiesFactories { get; set; } = [];

    internal List<InnerAssetAssetHierarchyFactory> AssetHierarchiesFactories { get; set; } = [];

    protected override Humidifier.IoTSiteWise.Asset Create()
    {
        var assetResult = CreateAsset();
        factoryAction?.Invoke(assetResult);

        return assetResult;
    }

    private Humidifier.IoTSiteWise.Asset CreateAsset()
    {
        var assetResult = new Humidifier.IoTSiteWise.Asset
        {
            GivenName = InputResourceName,
        };

        return assetResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.Asset result)
    {
        base.CreateChildren(result);

        result.AssetProperties = AssetPropertiesFactories.Any() ? AssetPropertiesFactories.Select(x => x.Build()).ToList() : null;
        result.AssetHierarchies = AssetHierarchiesFactories.Any() ? AssetHierarchiesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AssetFactoryExtensions
{
    public static CombinedResult<AssetFactory, InnerAssetAssetPropertyFactory> WithAssetProperties(this AssetFactory parentFactory, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null)
    {
        var factory = new InnerAssetAssetPropertyFactory(subFactoryAction);
        parentFactory.AssetPropertiesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AssetFactory, InnerAssetAssetHierarchyFactory> WithAssetHierarchies(this AssetFactory parentFactory, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null)
    {
        var factory = new InnerAssetAssetHierarchyFactory(subFactoryAction);
        parentFactory.AssetHierarchiesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AssetFactory, T1, InnerAssetAssetPropertyFactory> WithAssetProperties<T1>(this CombinedResult<AssetFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssetProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, InnerAssetAssetPropertyFactory> WithAssetProperties<T1>(this CombinedResult<T1, AssetFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssetProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AssetFactory, T1, T2, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2>(this CombinedResult<AssetFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, T2, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2>(this CombinedResult<T1, AssetFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssetFactory, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2>(this CombinedResult<T1, T2, AssetFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AssetFactory, T1, T2, T3, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2, T3>(this CombinedResult<AssetFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, T2, T3, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2, T3>(this CombinedResult<T1, AssetFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssetFactory, T3, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2, T3>(this CombinedResult<T1, T2, AssetFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssetFactory, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, AssetFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AssetFactory, T1, T2, T3, T4, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2, T3, T4>(this CombinedResult<AssetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, T2, T3, T4, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2, T3, T4>(this CombinedResult<T1, AssetFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssetFactory, T3, T4, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, AssetFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssetFactory, T4, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AssetFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AssetFactory, InnerAssetAssetPropertyFactory> WithAssetProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AssetFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssetProperties(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AssetFactory, T1, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1>(this CombinedResult<AssetFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1>(this CombinedResult<T1, AssetFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AssetFactory, T1, T2, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2>(this CombinedResult<AssetFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, T2, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2>(this CombinedResult<T1, AssetFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssetFactory, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2>(this CombinedResult<T1, T2, AssetFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AssetFactory, T1, T2, T3, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2, T3>(this CombinedResult<AssetFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, T2, T3, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2, T3>(this CombinedResult<T1, AssetFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssetFactory, T3, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2, T3>(this CombinedResult<T1, T2, AssetFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssetFactory, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2, T3>(this CombinedResult<T1, T2, T3, AssetFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AssetFactory, T1, T2, T3, T4, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2, T3, T4>(this CombinedResult<AssetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, T2, T3, T4, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2, T3, T4>(this CombinedResult<T1, AssetFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssetFactory, T3, T4, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2, T3, T4>(this CombinedResult<T1, T2, AssetFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssetFactory, T4, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AssetFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AssetFactory, InnerAssetAssetHierarchyFactory> WithAssetHierarchies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AssetFactory> combinedResult, Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssetHierarchies(combinedResult.T5, subFactoryAction));
}
