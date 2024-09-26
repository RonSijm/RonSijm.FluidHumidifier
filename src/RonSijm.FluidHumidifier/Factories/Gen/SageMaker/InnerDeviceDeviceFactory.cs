// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDeviceDeviceFactory(Action<Humidifier.SageMaker.DeviceTypes.Device> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DeviceTypes.Device>
{

    protected override Humidifier.SageMaker.DeviceTypes.Device Create()
    {
        var deviceResult = CreateDevice();
        factoryAction?.Invoke(deviceResult);

        return deviceResult;
    }

    private Humidifier.SageMaker.DeviceTypes.Device CreateDevice()
    {
        var deviceResult = new Humidifier.SageMaker.DeviceTypes.Device();

        return deviceResult;
    }

} // End Of Class

public static class InnerDeviceDeviceFactoryExtensions
{
}
