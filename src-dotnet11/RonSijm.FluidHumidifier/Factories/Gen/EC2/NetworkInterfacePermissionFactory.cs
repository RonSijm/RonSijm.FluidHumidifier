// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NetworkInterfacePermissionFactory(string resourceName = null, Action<Humidifier.EC2.NetworkInterfacePermission> factoryAction = null) : ResourceFactory<Humidifier.EC2.NetworkInterfacePermission>(resourceName)
{

    protected override Humidifier.EC2.NetworkInterfacePermission Create()
    {
        var networkInterfacePermissionResult = CreateNetworkInterfacePermission();
        factoryAction?.Invoke(networkInterfacePermissionResult);

        return networkInterfacePermissionResult;
    }

    private Humidifier.EC2.NetworkInterfacePermission CreateNetworkInterfacePermission()
    {
        var networkInterfacePermissionResult = new Humidifier.EC2.NetworkInterfacePermission
        {
            GivenName = InputResourceName,
        };

        return networkInterfacePermissionResult;
    }

} // End Of Class

public static class NetworkInterfacePermissionFactoryExtensions
{
}
