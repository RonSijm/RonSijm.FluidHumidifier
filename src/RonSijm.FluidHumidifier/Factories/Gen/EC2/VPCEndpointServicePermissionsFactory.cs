// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCEndpointServicePermissionsFactory(string resourceName = null, Action<Humidifier.EC2.VPCEndpointServicePermissions> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCEndpointServicePermissions>(resourceName)
{

    protected override Humidifier.EC2.VPCEndpointServicePermissions Create()
    {
        var vPCEndpointServicePermissionsResult = CreateVPCEndpointServicePermissions();
        factoryAction?.Invoke(vPCEndpointServicePermissionsResult);

        return vPCEndpointServicePermissionsResult;
    }

    private Humidifier.EC2.VPCEndpointServicePermissions CreateVPCEndpointServicePermissions()
    {
        var vPCEndpointServicePermissionsResult = new Humidifier.EC2.VPCEndpointServicePermissions
        {
            GivenName = InputResourceName,
        };

        return vPCEndpointServicePermissionsResult;
    }

} // End Of Class

public static class VPCEndpointServicePermissionsFactoryExtensions
{
}
