// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerPortalAlarmsFactory(Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.PortalTypes.Alarms>
{

    protected override Humidifier.IoTSiteWise.PortalTypes.Alarms Create()
    {
        var alarmsResult = CreateAlarms();
        factoryAction?.Invoke(alarmsResult);

        return alarmsResult;
    }

    private Humidifier.IoTSiteWise.PortalTypes.Alarms CreateAlarms()
    {
        var alarmsResult = new Humidifier.IoTSiteWise.PortalTypes.Alarms();

        return alarmsResult;
    }

} // End Of Class

public static class InnerPortalAlarmsFactoryExtensions
{
}
