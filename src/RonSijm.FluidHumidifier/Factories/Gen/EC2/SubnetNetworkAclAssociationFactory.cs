// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SubnetNetworkAclAssociationFactory(string resourceName = null, Action<Humidifier.EC2.SubnetNetworkAclAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.SubnetNetworkAclAssociation>(resourceName)
{

    protected override Humidifier.EC2.SubnetNetworkAclAssociation Create()
    {
        var subnetNetworkAclAssociationResult = CreateSubnetNetworkAclAssociation();
        factoryAction?.Invoke(subnetNetworkAclAssociationResult);

        return subnetNetworkAclAssociationResult;
    }

    private Humidifier.EC2.SubnetNetworkAclAssociation CreateSubnetNetworkAclAssociation()
    {
        var subnetNetworkAclAssociationResult = new Humidifier.EC2.SubnetNetworkAclAssociation
        {
            GivenName = InputResourceName,
        };

        return subnetNetworkAclAssociationResult;
    }

} // End Of Class

public static class SubnetNetworkAclAssociationFactoryExtensions
{
}
