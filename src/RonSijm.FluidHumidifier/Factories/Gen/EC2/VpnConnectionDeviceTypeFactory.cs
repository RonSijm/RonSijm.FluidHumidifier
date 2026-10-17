// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VpnConnectionDeviceTypeFactory(string resourceName = null, Action<Humidifier.EC2.VpnConnectionDeviceType> factoryAction = null) : ResourceFactory<Humidifier.EC2.VpnConnectionDeviceType>(resourceName)
{

    protected override Humidifier.EC2.VpnConnectionDeviceType Create()
    {
        var vpnConnectionDeviceTypeResult = CreateVpnConnectionDeviceType();
        factoryAction?.Invoke(vpnConnectionDeviceTypeResult);

        return vpnConnectionDeviceTypeResult;
    }

    private Humidifier.EC2.VpnConnectionDeviceType CreateVpnConnectionDeviceType()
    {
        var vpnConnectionDeviceTypeResult = new Humidifier.EC2.VpnConnectionDeviceType
        {
            GivenName = InputResourceName,
        };

        return vpnConnectionDeviceTypeResult;
    }

} // End Of Class

public static class VpnConnectionDeviceTypeFactoryExtensions
{
}
