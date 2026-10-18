// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerDeviceAWSLocationFactory(Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.DeviceTypes.AWSLocation>
{

    protected override Humidifier.NetworkManager.DeviceTypes.AWSLocation Create()
    {
        var aWSLocationResult = CreateAWSLocation();
        factoryAction?.Invoke(aWSLocationResult);

        return aWSLocationResult;
    }

    private Humidifier.NetworkManager.DeviceTypes.AWSLocation CreateAWSLocation()
    {
        var aWSLocationResult = new Humidifier.NetworkManager.DeviceTypes.AWSLocation();

        return aWSLocationResult;
    }

} // End Of Class

public static class InnerDeviceAWSLocationFactoryExtensions
{
}
