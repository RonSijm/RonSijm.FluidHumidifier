// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class CustomerGatewayAssociationFactory(string resourceName = null, Action<Humidifier.NetworkManager.CustomerGatewayAssociation> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.CustomerGatewayAssociation>(resourceName)
{

    protected override Humidifier.NetworkManager.CustomerGatewayAssociation Create()
    {
        var customerGatewayAssociationResult = CreateCustomerGatewayAssociation();
        factoryAction?.Invoke(customerGatewayAssociationResult);

        return customerGatewayAssociationResult;
    }

    private Humidifier.NetworkManager.CustomerGatewayAssociation CreateCustomerGatewayAssociation()
    {
        var customerGatewayAssociationResult = new Humidifier.NetworkManager.CustomerGatewayAssociation
        {
            GivenName = InputResourceName,
        };

        return customerGatewayAssociationResult;
    }

} // End Of Class

public static class CustomerGatewayAssociationFactoryExtensions
{
}
