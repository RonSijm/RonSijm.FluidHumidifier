// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetModelAssetModelHierarchyFactory(Action<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelHierarchy> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelHierarchy>
{

    protected override Humidifier.IoTSiteWise.AssetModelTypes.AssetModelHierarchy Create()
    {
        var assetModelHierarchyResult = CreateAssetModelHierarchy();
        factoryAction?.Invoke(assetModelHierarchyResult);

        return assetModelHierarchyResult;
    }

    private Humidifier.IoTSiteWise.AssetModelTypes.AssetModelHierarchy CreateAssetModelHierarchy()
    {
        var assetModelHierarchyResult = new Humidifier.IoTSiteWise.AssetModelTypes.AssetModelHierarchy();

        return assetModelHierarchyResult;
    }

} // End Of Class

public static class InnerAssetModelAssetModelHierarchyFactoryExtensions
{
}
