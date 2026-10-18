// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetIpPermissionFactory(Action<Humidifier.GameLift.ContainerFleetTypes.IpPermission> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.IpPermission>
{

    protected override Humidifier.GameLift.ContainerFleetTypes.IpPermission Create()
    {
        var ipPermissionResult = CreateIpPermission();
        factoryAction?.Invoke(ipPermissionResult);

        return ipPermissionResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.IpPermission CreateIpPermission()
    {
        var ipPermissionResult = new Humidifier.GameLift.ContainerFleetTypes.IpPermission();

        return ipPermissionResult;
    }

} // End Of Class

public static class InnerContainerFleetIpPermissionFactoryExtensions
{
}
