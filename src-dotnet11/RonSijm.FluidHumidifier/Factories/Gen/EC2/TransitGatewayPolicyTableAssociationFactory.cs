// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayPolicyTableAssociationFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayPolicyTableAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayPolicyTableAssociation>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayPolicyTableAssociation Create()
    {
        var transitGatewayPolicyTableAssociationResult = CreateTransitGatewayPolicyTableAssociation();
        factoryAction?.Invoke(transitGatewayPolicyTableAssociationResult);

        return transitGatewayPolicyTableAssociationResult;
    }

    private Humidifier.EC2.TransitGatewayPolicyTableAssociation CreateTransitGatewayPolicyTableAssociation()
    {
        var transitGatewayPolicyTableAssociationResult = new Humidifier.EC2.TransitGatewayPolicyTableAssociation
        {
            GivenName = InputResourceName,
        };

        return transitGatewayPolicyTableAssociationResult;
    }

} // End Of Class

public static class TransitGatewayPolicyTableAssociationFactoryExtensions
{
}
