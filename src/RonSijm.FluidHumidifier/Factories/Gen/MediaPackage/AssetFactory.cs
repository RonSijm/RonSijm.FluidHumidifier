// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class AssetFactory(string resourceName = null, Action<Humidifier.MediaPackage.Asset> factoryAction = null) : ResourceFactory<Humidifier.MediaPackage.Asset>(resourceName)
{

    internal List<InnerAssetEgressEndpointFactory> EgressEndpointsFactories { get; set; } = [];

    protected override Humidifier.MediaPackage.Asset Create()
    {
        var assetResult = CreateAsset();
        factoryAction?.Invoke(assetResult);

        return assetResult;
    }

    private Humidifier.MediaPackage.Asset CreateAsset()
    {
        var assetResult = new Humidifier.MediaPackage.Asset
        {
            GivenName = InputResourceName,
        };

        return assetResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.Asset result)
    {
        base.CreateChildren(result);

        result.EgressEndpoints = EgressEndpointsFactories.Any() ? EgressEndpointsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AssetFactoryExtensions
{
    public static CombinedResult<AssetFactory, InnerAssetEgressEndpointFactory> WithEgressEndpoints(this AssetFactory parentFactory, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null)
    {
        var factory = new InnerAssetEgressEndpointFactory(subFactoryAction);
        parentFactory.EgressEndpointsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AssetFactory, T1, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1>(this CombinedResult<AssetFactory, T1> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1>(this CombinedResult<T1, AssetFactory> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AssetFactory, T1, T2, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2>(this CombinedResult<AssetFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, T2, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2>(this CombinedResult<T1, AssetFactory, T2> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssetFactory, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2>(this CombinedResult<T1, T2, AssetFactory> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AssetFactory, T1, T2, T3, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2, T3>(this CombinedResult<AssetFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, T2, T3, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2, T3>(this CombinedResult<T1, AssetFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssetFactory, T3, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, AssetFactory, T3> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssetFactory, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, T3, AssetFactory> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AssetFactory, T1, T2, T3, T4, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2, T3, T4>(this CombinedResult<AssetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AssetFactory, T2, T3, T4, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, AssetFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AssetFactory, T3, T4, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, AssetFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AssetFactory, T4, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AssetFactory, T4> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AssetFactory, InnerAssetEgressEndpointFactory> WithEgressEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AssetFactory> combinedResult, Action<Humidifier.MediaPackage.AssetTypes.EgressEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressEndpoints(combinedResult.T5, subFactoryAction));
}
