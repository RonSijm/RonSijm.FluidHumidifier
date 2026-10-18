// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerWirelessDeviceImportTaskSidewalkFactory(Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk>
{

    protected override Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk Create()
    {
        var sidewalkResult = CreateSidewalk();
        factoryAction?.Invoke(sidewalkResult);

        return sidewalkResult;
    }

    private Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk CreateSidewalk()
    {
        var sidewalkResult = new Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk();

        return sidewalkResult;
    }

} // End Of Class

public static class InnerWirelessDeviceImportTaskSidewalkFactoryExtensions
{
}
