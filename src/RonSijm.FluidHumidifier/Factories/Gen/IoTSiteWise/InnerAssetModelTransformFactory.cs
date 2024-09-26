// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetModelTransformFactory(Action<Humidifier.IoTSiteWise.AssetModelTypes.Transform> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetModelTypes.Transform>
{

    protected override Humidifier.IoTSiteWise.AssetModelTypes.Transform Create()
    {
        var transformResult = CreateTransform();
        factoryAction?.Invoke(transformResult);

        return transformResult;
    }

    private Humidifier.IoTSiteWise.AssetModelTypes.Transform CreateTransform()
    {
        var transformResult = new Humidifier.IoTSiteWise.AssetModelTypes.Transform();

        return transformResult;
    }

} // End Of Class

public static class InnerAssetModelTransformFactoryExtensions
{
}
