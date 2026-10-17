// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RUM;

public class InnerAppMonitorJavaScriptSourceMapsFactory(Action<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps> factoryAction = null) : SubResourceFactory<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps>
{

    protected override Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps Create()
    {
        var javaScriptSourceMapsResult = CreateJavaScriptSourceMaps();
        factoryAction?.Invoke(javaScriptSourceMapsResult);

        return javaScriptSourceMapsResult;
    }

    private Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps CreateJavaScriptSourceMaps()
    {
        var javaScriptSourceMapsResult = new Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps();

        return javaScriptSourceMapsResult;
    }

} // End Of Class

public static class InnerAppMonitorJavaScriptSourceMapsFactoryExtensions
{
}
