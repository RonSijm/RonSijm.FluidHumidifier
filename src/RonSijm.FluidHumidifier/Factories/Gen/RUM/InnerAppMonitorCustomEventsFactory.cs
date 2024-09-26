// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RUM;

public class InnerAppMonitorCustomEventsFactory(Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> factoryAction = null) : SubResourceFactory<Humidifier.RUM.AppMonitorTypes.CustomEvents>
{

    protected override Humidifier.RUM.AppMonitorTypes.CustomEvents Create()
    {
        var customEventsResult = CreateCustomEvents();
        factoryAction?.Invoke(customEventsResult);

        return customEventsResult;
    }

    private Humidifier.RUM.AppMonitorTypes.CustomEvents CreateCustomEvents()
    {
        var customEventsResult = new Humidifier.RUM.AppMonitorTypes.CustomEvents();

        return customEventsResult;
    }

} // End Of Class

public static class InnerAppMonitorCustomEventsFactoryExtensions
{
}
