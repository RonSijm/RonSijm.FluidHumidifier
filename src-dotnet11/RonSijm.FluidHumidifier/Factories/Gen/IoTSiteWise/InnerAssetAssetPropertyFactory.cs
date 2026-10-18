// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetAssetPropertyFactory(Action<Humidifier.IoTSiteWise.AssetTypes.AssetProperty> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetTypes.AssetProperty>
{

    protected override Humidifier.IoTSiteWise.AssetTypes.AssetProperty Create()
    {
        var assetPropertyResult = CreateAssetProperty();
        factoryAction?.Invoke(assetPropertyResult);

        return assetPropertyResult;
    }

    private Humidifier.IoTSiteWise.AssetTypes.AssetProperty CreateAssetProperty()
    {
        var assetPropertyResult = new Humidifier.IoTSiteWise.AssetTypes.AssetProperty();

        return assetPropertyResult;
    }

} // End Of Class

public static class InnerAssetAssetPropertyFactoryExtensions
{
}
