// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCM;

public class InnerDashboardWidgetFactory(Action<Humidifier.BCM.DashboardTypes.Widget> factoryAction = null) : SubResourceFactory<Humidifier.BCM.DashboardTypes.Widget>
{

    protected override Humidifier.BCM.DashboardTypes.Widget Create()
    {
        var widgetResult = CreateWidget();
        factoryAction?.Invoke(widgetResult);

        return widgetResult;
    }

    private Humidifier.BCM.DashboardTypes.Widget CreateWidget()
    {
        var widgetResult = new Humidifier.BCM.DashboardTypes.Widget();

        return widgetResult;
    }

} // End Of Class

public static class InnerDashboardWidgetFactoryExtensions
{
}
