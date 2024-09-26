// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCPeeringConnectionFactory(string resourceName = null, Action<Humidifier.EC2.VPCPeeringConnection> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCPeeringConnection>(resourceName)
{

    protected override Humidifier.EC2.VPCPeeringConnection Create()
    {
        var vPCPeeringConnectionResult = CreateVPCPeeringConnection();
        factoryAction?.Invoke(vPCPeeringConnectionResult);

        return vPCPeeringConnectionResult;
    }

    private Humidifier.EC2.VPCPeeringConnection CreateVPCPeeringConnection()
    {
        var vPCPeeringConnectionResult = new Humidifier.EC2.VPCPeeringConnection
        {
            GivenName = InputResourceName,
        };

        return vPCPeeringConnectionResult;
    }

} // End Of Class

public static class VPCPeeringConnectionFactoryExtensions
{
}
