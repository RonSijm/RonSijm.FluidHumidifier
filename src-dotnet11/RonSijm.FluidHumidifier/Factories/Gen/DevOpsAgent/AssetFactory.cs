// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class AssetFactory(string resourceName = null, Action<Humidifier.DevOpsAgent.Asset> factoryAction = null) : ResourceFactory<Humidifier.DevOpsAgent.Asset>(resourceName)
{

    internal List<InnerAssetAssetFileFactory> FilesFactories { get; set; } = [];

    protected override Humidifier.DevOpsAgent.Asset Create()
    {
        var assetResult = CreateAsset();
        factoryAction?.Invoke(assetResult);

        return assetResult;
    }

    private Humidifier.DevOpsAgent.Asset CreateAsset()
    {
        var assetResult = new Humidifier.DevOpsAgent.Asset
        {
            GivenName = InputResourceName,
        };

        return assetResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.Asset result)
    {
        base.CreateChildren(result);

        result.Files = FilesFactories.Any() ? FilesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AssetFactoryExtensions
{
    public static CombinedResult<AssetFactory, InnerAssetAssetFileFactory> WithFiles(this AssetFactory parentFactory, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null)
    {
        var factory = new InnerAssetAssetFileFactory(subFactoryAction);
        parentFactory.FilesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AssetFactory, T1, InnerAssetAssetFileFactory> WithFiles<T1>(this CombinedResult<AssetFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, WithFiles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssetFactory, InnerAssetAssetFileFactory> WithFiles<T1>(this CombinedResult<T1, AssetFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, WithFiles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AssetFactory, T1, T2, InnerAssetAssetFileFactory> WithFiles<T1, T2>(this CombinedResult<AssetFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssetFactory, T2, InnerAssetAssetFileFactory> WithFiles<T1, T2>(this CombinedResult<T1, AssetFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AssetFactory, InnerAssetAssetFileFactory> WithFiles<T1, T2>(this CombinedResult<T1, T2, AssetFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AssetFactory, T1, T2, T3, InnerAssetAssetFileFactory> WithFiles<T1, T2, T3>(this CombinedResult<AssetFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssetFactory, T2, T3, InnerAssetAssetFileFactory> WithFiles<T1, T2, T3>(this CombinedResult<T1, AssetFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AssetFactory, T3, InnerAssetAssetFileFactory> WithFiles<T1, T2, T3>(this CombinedResult<T1, T2, AssetFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AssetFactory, InnerAssetAssetFileFactory> WithFiles<T1, T2, T3>(this CombinedResult<T1, T2, T3, AssetFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AssetFactory, T1, T2, T3, T4, InnerAssetAssetFileFactory> WithFiles<T1, T2, T3, T4>(this CombinedResult<AssetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssetFactory, T2, T3, T4, InnerAssetAssetFileFactory> WithFiles<T1, T2, T3, T4>(this CombinedResult<T1, AssetFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AssetFactory, T3, T4, InnerAssetAssetFileFactory> WithFiles<T1, T2, T3, T4>(this CombinedResult<T1, T2, AssetFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AssetFactory, T4, InnerAssetAssetFileFactory> WithFiles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AssetFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AssetFactory, InnerAssetAssetFileFactory> WithFiles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AssetFactory> combinedResult, Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T5, subFactoryAction).T2);
}
