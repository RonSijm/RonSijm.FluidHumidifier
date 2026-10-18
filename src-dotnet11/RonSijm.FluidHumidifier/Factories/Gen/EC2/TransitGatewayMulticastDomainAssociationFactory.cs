// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayMulticastDomainAssociationFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayMulticastDomainAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayMulticastDomainAssociation>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayMulticastDomainAssociation Create()
    {
        var transitGatewayMulticastDomainAssociationResult = CreateTransitGatewayMulticastDomainAssociation();
        factoryAction?.Invoke(transitGatewayMulticastDomainAssociationResult);

        return transitGatewayMulticastDomainAssociationResult;
    }

    private Humidifier.EC2.TransitGatewayMulticastDomainAssociation CreateTransitGatewayMulticastDomainAssociation()
    {
        var transitGatewayMulticastDomainAssociationResult = new Humidifier.EC2.TransitGatewayMulticastDomainAssociation
        {
            GivenName = InputResourceName,
        };

        return transitGatewayMulticastDomainAssociationResult;
    }

} // End Of Class

public static class TransitGatewayMulticastDomainAssociationFactoryExtensions
{
}
