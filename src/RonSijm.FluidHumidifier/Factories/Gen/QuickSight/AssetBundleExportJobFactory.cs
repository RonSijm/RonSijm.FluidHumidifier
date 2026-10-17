// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class AssetBundleExportJobFactory(string resourceName = null, Action<Humidifier.QuickSight.AssetBundleExportJob> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.AssetBundleExportJob>(resourceName)
{

    protected override Humidifier.QuickSight.AssetBundleExportJob Create()
    {
        var assetBundleExportJobResult = CreateAssetBundleExportJob();
        factoryAction?.Invoke(assetBundleExportJobResult);

        return assetBundleExportJobResult;
    }

    private Humidifier.QuickSight.AssetBundleExportJob CreateAssetBundleExportJob()
    {
        var assetBundleExportJobResult = new Humidifier.QuickSight.AssetBundleExportJob
        {
            GivenName = InputResourceName,
        };

        return assetBundleExportJobResult;
    }

} // End Of Class

public static class AssetBundleExportJobFactoryExtensions
{
}
