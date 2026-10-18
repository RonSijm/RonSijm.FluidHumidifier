// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerDeviceDefinitionVersionDeviceFactory(Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device>
{

    protected override Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device Create()
    {
        var deviceResult = CreateDevice();
        factoryAction?.Invoke(deviceResult);

        return deviceResult;
    }

    private Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device CreateDevice()
    {
        var deviceResult = new Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device();

        return deviceResult;
    }

} // End Of Class

public static class InnerDeviceDefinitionVersionDeviceFactoryExtensions
{
}
