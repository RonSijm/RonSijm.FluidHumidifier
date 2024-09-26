// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetModelAssetModelCompositeModelFactory(Action<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelCompositeModel> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetModelTypes.AssetModelCompositeModel>
{

    protected override Humidifier.IoTSiteWise.AssetModelTypes.AssetModelCompositeModel Create()
    {
        var assetModelCompositeModelResult = CreateAssetModelCompositeModel();
        factoryAction?.Invoke(assetModelCompositeModelResult);

        return assetModelCompositeModelResult;
    }

    private Humidifier.IoTSiteWise.AssetModelTypes.AssetModelCompositeModel CreateAssetModelCompositeModel()
    {
        var assetModelCompositeModelResult = new Humidifier.IoTSiteWise.AssetModelTypes.AssetModelCompositeModel();

        return assetModelCompositeModelResult;
    }

} // End Of Class

public static class InnerAssetModelAssetModelCompositeModelFactoryExtensions
{
}
