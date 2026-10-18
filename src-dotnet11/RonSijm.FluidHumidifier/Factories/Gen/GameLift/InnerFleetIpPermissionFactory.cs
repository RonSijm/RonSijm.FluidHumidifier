// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetIpPermissionFactory(Action<Humidifier.GameLift.FleetTypes.IpPermission> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.IpPermission>
{

    protected override Humidifier.GameLift.FleetTypes.IpPermission Create()
    {
        var ipPermissionResult = CreateIpPermission();
        factoryAction?.Invoke(ipPermissionResult);

        return ipPermissionResult;
    }

    private Humidifier.GameLift.FleetTypes.IpPermission CreateIpPermission()
    {
        var ipPermissionResult = new Humidifier.GameLift.FleetTypes.IpPermission();

        return ipPermissionResult;
    }

} // End Of Class

public static class InnerFleetIpPermissionFactoryExtensions
{
}
