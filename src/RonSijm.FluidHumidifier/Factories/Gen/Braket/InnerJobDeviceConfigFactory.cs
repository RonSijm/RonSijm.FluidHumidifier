// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerJobDeviceConfigFactory(Action<Humidifier.Braket.JobTypes.DeviceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Braket.JobTypes.DeviceConfig>
{

    protected override Humidifier.Braket.JobTypes.DeviceConfig Create()
    {
        var deviceConfigResult = CreateDeviceConfig();
        factoryAction?.Invoke(deviceConfigResult);

        return deviceConfigResult;
    }

    private Humidifier.Braket.JobTypes.DeviceConfig CreateDeviceConfig()
    {
        var deviceConfigResult = new Humidifier.Braket.JobTypes.DeviceConfig();

        return deviceConfigResult;
    }

} // End Of Class

public static class InnerJobDeviceConfigFactoryExtensions
{
}
