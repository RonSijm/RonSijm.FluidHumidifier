// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetAssetHierarchyFactory(Action<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy>
{

    protected override Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy Create()
    {
        var assetHierarchyResult = CreateAssetHierarchy();
        factoryAction?.Invoke(assetHierarchyResult);

        return assetHierarchyResult;
    }

    private Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy CreateAssetHierarchy()
    {
        var assetHierarchyResult = new Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy();

        return assetHierarchyResult;
    }

} // End Of Class

public static class InnerAssetAssetHierarchyFactoryExtensions
{
}
