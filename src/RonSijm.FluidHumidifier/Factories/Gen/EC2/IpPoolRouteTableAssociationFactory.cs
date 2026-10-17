// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IpPoolRouteTableAssociationFactory(string resourceName = null, Action<Humidifier.EC2.IpPoolRouteTableAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.IpPoolRouteTableAssociation>(resourceName)
{

    protected override Humidifier.EC2.IpPoolRouteTableAssociation Create()
    {
        var ipPoolRouteTableAssociationResult = CreateIpPoolRouteTableAssociation();
        factoryAction?.Invoke(ipPoolRouteTableAssociationResult);

        return ipPoolRouteTableAssociationResult;
    }

    private Humidifier.EC2.IpPoolRouteTableAssociation CreateIpPoolRouteTableAssociation()
    {
        var ipPoolRouteTableAssociationResult = new Humidifier.EC2.IpPoolRouteTableAssociation
        {
            GivenName = InputResourceName,
        };

        return ipPoolRouteTableAssociationResult;
    }

} // End Of Class

public static class IpPoolRouteTableAssociationFactoryExtensions
{
}
