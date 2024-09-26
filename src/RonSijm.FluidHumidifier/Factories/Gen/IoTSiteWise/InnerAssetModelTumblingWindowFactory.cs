// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetModelTumblingWindowFactory(Action<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow>
{

    protected override Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow Create()
    {
        var tumblingWindowResult = CreateTumblingWindow();
        factoryAction?.Invoke(tumblingWindowResult);

        return tumblingWindowResult;
    }

    private Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow CreateTumblingWindow()
    {
        var tumblingWindowResult = new Humidifier.IoTSiteWise.AssetModelTypes.TumblingWindow();

        return tumblingWindowResult;
    }

} // End Of Class

public static class InnerAssetModelTumblingWindowFactoryExtensions
{
}
