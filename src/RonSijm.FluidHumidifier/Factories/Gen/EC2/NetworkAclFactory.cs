// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NetworkAclFactory(string resourceName = null, Action<Humidifier.EC2.NetworkAcl> factoryAction = null) : ResourceFactory<Humidifier.EC2.NetworkAcl>(resourceName)
{

    protected override Humidifier.EC2.NetworkAcl Create()
    {
        var networkAclResult = CreateNetworkAcl();
        factoryAction?.Invoke(networkAclResult);

        return networkAclResult;
    }

    private Humidifier.EC2.NetworkAcl CreateNetworkAcl()
    {
        var networkAclResult = new Humidifier.EC2.NetworkAcl
        {
            GivenName = InputResourceName,
        };

        return networkAclResult;
    }

} // End Of Class

public static class NetworkAclFactoryExtensions
{
}
