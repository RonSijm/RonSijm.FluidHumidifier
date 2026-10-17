// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectConnect;

public class DirectConnectGatewayAssociationFactory(string resourceName = null, Action<Humidifier.DirectConnect.DirectConnectGatewayAssociation> factoryAction = null) : ResourceFactory<Humidifier.DirectConnect.DirectConnectGatewayAssociation>(resourceName)
{

    protected override Humidifier.DirectConnect.DirectConnectGatewayAssociation Create()
    {
        var directConnectGatewayAssociationResult = CreateDirectConnectGatewayAssociation();
        factoryAction?.Invoke(directConnectGatewayAssociationResult);

        return directConnectGatewayAssociationResult;
    }

    private Humidifier.DirectConnect.DirectConnectGatewayAssociation CreateDirectConnectGatewayAssociation()
    {
        var directConnectGatewayAssociationResult = new Humidifier.DirectConnect.DirectConnectGatewayAssociation
        {
            GivenName = InputResourceName,
        };

        return directConnectGatewayAssociationResult;
    }

} // End Of Class

public static class DirectConnectGatewayAssociationFactoryExtensions
{
}
