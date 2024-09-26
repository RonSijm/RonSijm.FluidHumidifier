// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerTransitGatewayRouteTableAttachmentProposedNetworkFunctionGroupChangeFactory(Action<Humidifier.NetworkManager.TransitGatewayRouteTableAttachmentTypes.ProposedNetworkFunctionGroupChange> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.TransitGatewayRouteTableAttachmentTypes.ProposedNetworkFunctionGroupChange>
{

    protected override Humidifier.NetworkManager.TransitGatewayRouteTableAttachmentTypes.ProposedNetworkFunctionGroupChange Create()
    {
        var proposedNetworkFunctionGroupChangeResult = CreateProposedNetworkFunctionGroupChange();
        factoryAction?.Invoke(proposedNetworkFunctionGroupChangeResult);

        return proposedNetworkFunctionGroupChangeResult;
    }

    private Humidifier.NetworkManager.TransitGatewayRouteTableAttachmentTypes.ProposedNetworkFunctionGroupChange CreateProposedNetworkFunctionGroupChange()
    {
        var proposedNetworkFunctionGroupChangeResult = new Humidifier.NetworkManager.TransitGatewayRouteTableAttachmentTypes.ProposedNetworkFunctionGroupChange();

        return proposedNetworkFunctionGroupChangeResult;
    }

} // End Of Class

public static class InnerTransitGatewayRouteTableAttachmentProposedNetworkFunctionGroupChangeFactoryExtensions
{
}
