// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessTrustProviderDeviceOptionsFactory(Action<Humidifier.EC2.VerifiedAccessTrustProviderTypes.DeviceOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessTrustProviderTypes.DeviceOptions>
{

    protected override Humidifier.EC2.VerifiedAccessTrustProviderTypes.DeviceOptions Create()
    {
        var deviceOptionsResult = CreateDeviceOptions();
        factoryAction?.Invoke(deviceOptionsResult);

        return deviceOptionsResult;
    }

    private Humidifier.EC2.VerifiedAccessTrustProviderTypes.DeviceOptions CreateDeviceOptions()
    {
        var deviceOptionsResult = new Humidifier.EC2.VerifiedAccessTrustProviderTypes.DeviceOptions();

        return deviceOptionsResult;
    }

} // End Of Class

public static class InnerVerifiedAccessTrustProviderDeviceOptionsFactoryExtensions
{
}
