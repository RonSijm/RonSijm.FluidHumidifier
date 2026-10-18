// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAssetBundleImportJobAssetBundleImportSourceDescriptionFactory(Action<Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportSourceDescription> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportSourceDescription>
{

    protected override Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportSourceDescription Create()
    {
        var assetBundleImportSourceDescriptionResult = CreateAssetBundleImportSourceDescription();
        factoryAction?.Invoke(assetBundleImportSourceDescriptionResult);

        return assetBundleImportSourceDescriptionResult;
    }

    private Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportSourceDescription CreateAssetBundleImportSourceDescription()
    {
        var assetBundleImportSourceDescriptionResult = new Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportSourceDescription();

        return assetBundleImportSourceDescriptionResult;
    }

} // End Of Class

public static class InnerAssetBundleImportJobAssetBundleImportSourceDescriptionFactoryExtensions
{
}
