// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerDashboardWidgetFactory(Action<Humidifier.CloudTrail.DashboardTypes.Widget> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.DashboardTypes.Widget>
{

    protected override Humidifier.CloudTrail.DashboardTypes.Widget Create()
    {
        var widgetResult = CreateWidget();
        factoryAction?.Invoke(widgetResult);

        return widgetResult;
    }

    private Humidifier.CloudTrail.DashboardTypes.Widget CreateWidget()
    {
        var widgetResult = new Humidifier.CloudTrail.DashboardTypes.Widget();

        return widgetResult;
    }

} // End Of Class

public static class InnerDashboardWidgetFactoryExtensions
{
}
