// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SubnetRouteTableAssociationFactory(string resourceName = null, Action<Humidifier.EC2.SubnetRouteTableAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.SubnetRouteTableAssociation>(resourceName)
{

    protected override Humidifier.EC2.SubnetRouteTableAssociation Create()
    {
        var subnetRouteTableAssociationResult = CreateSubnetRouteTableAssociation();
        factoryAction?.Invoke(subnetRouteTableAssociationResult);

        return subnetRouteTableAssociationResult;
    }

    private Humidifier.EC2.SubnetRouteTableAssociation CreateSubnetRouteTableAssociation()
    {
        var subnetRouteTableAssociationResult = new Humidifier.EC2.SubnetRouteTableAssociation
        {
            GivenName = InputResourceName,
        };

        return subnetRouteTableAssociationResult;
    }

} // End Of Class

public static class SubnetRouteTableAssociationFactoryExtensions
{
}
