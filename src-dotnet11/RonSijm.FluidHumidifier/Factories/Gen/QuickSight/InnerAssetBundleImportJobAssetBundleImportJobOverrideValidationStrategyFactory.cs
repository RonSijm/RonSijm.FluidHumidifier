// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAssetBundleImportJobAssetBundleImportJobOverrideValidationStrategyFactory(Action<Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportJobOverrideValidationStrategy> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportJobOverrideValidationStrategy>
{

    protected override Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportJobOverrideValidationStrategy Create()
    {
        var assetBundleImportJobOverrideValidationStrategyResult = CreateAssetBundleImportJobOverrideValidationStrategy();
        factoryAction?.Invoke(assetBundleImportJobOverrideValidationStrategyResult);

        return assetBundleImportJobOverrideValidationStrategyResult;
    }

    private Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportJobOverrideValidationStrategy CreateAssetBundleImportJobOverrideValidationStrategy()
    {
        var assetBundleImportJobOverrideValidationStrategyResult = new Humidifier.QuickSight.AssetBundleImportJobTypes.AssetBundleImportJobOverrideValidationStrategy();

        return assetBundleImportJobOverrideValidationStrategyResult;
    }

} // End Of Class

public static class InnerAssetBundleImportJobAssetBundleImportJobOverrideValidationStrategyFactoryExtensions
{
}
