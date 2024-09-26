// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerDeviceDefinitionDeviceFactory(Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.DeviceDefinitionTypes.Device>
{

    protected override Humidifier.Greengrass.DeviceDefinitionTypes.Device Create()
    {
        var deviceResult = CreateDevice();
        factoryAction?.Invoke(deviceResult);

        return deviceResult;
    }

    private Humidifier.Greengrass.DeviceDefinitionTypes.Device CreateDevice()
    {
        var deviceResult = new Humidifier.Greengrass.DeviceDefinitionTypes.Device();

        return deviceResult;
    }

} // End Of Class

public static class InnerDeviceDefinitionDeviceFactoryExtensions
{
}
