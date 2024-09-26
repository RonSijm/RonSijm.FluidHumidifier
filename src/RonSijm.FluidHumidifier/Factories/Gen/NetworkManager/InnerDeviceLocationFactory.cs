// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerDeviceLocationFactory(Action<Humidifier.NetworkManager.DeviceTypes.Location> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.DeviceTypes.Location>
{

    protected override Humidifier.NetworkManager.DeviceTypes.Location Create()
    {
        var locationResult = CreateLocation();
        factoryAction?.Invoke(locationResult);

        return locationResult;
    }

    private Humidifier.NetworkManager.DeviceTypes.Location CreateLocation()
    {
        var locationResult = new Humidifier.NetworkManager.DeviceTypes.Location();

        return locationResult;
    }

} // End Of Class

public static class InnerDeviceLocationFactoryExtensions
{
}
