// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class DeviceFactory(string resourceName = null, Action<Humidifier.StorageGateway.Device> factoryAction = null) : ResourceFactory<Humidifier.StorageGateway.Device>(resourceName)
{

    protected override Humidifier.StorageGateway.Device Create()
    {
        var deviceResult = CreateDevice();
        factoryAction?.Invoke(deviceResult);

        return deviceResult;
    }

    private Humidifier.StorageGateway.Device CreateDevice()
    {
        var deviceResult = new Humidifier.StorageGateway.Device
        {
            GivenName = InputResourceName,
        };

        return deviceResult;
    }

} // End Of Class

public static class DeviceFactoryExtensions
{
}
