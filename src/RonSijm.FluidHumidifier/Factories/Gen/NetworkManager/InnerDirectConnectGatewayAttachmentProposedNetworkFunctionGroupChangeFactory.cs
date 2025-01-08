// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerDirectConnectGatewayAttachmentProposedNetworkFunctionGroupChangeFactory(Action<Humidifier.NetworkManager.DirectConnectGatewayAttachmentTypes.ProposedNetworkFunctionGroupChange> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.DirectConnectGatewayAttachmentTypes.ProposedNetworkFunctionGroupChange>
{

    protected override Humidifier.NetworkManager.DirectConnectGatewayAttachmentTypes.ProposedNetworkFunctionGroupChange Create()
    {
        var proposedNetworkFunctionGroupChangeResult = CreateProposedNetworkFunctionGroupChange();
        factoryAction?.Invoke(proposedNetworkFunctionGroupChangeResult);

        return proposedNetworkFunctionGroupChangeResult;
    }

    private Humidifier.NetworkManager.DirectConnectGatewayAttachmentTypes.ProposedNetworkFunctionGroupChange CreateProposedNetworkFunctionGroupChange()
    {
        var proposedNetworkFunctionGroupChangeResult = new Humidifier.NetworkManager.DirectConnectGatewayAttachmentTypes.ProposedNetworkFunctionGroupChange();

        return proposedNetworkFunctionGroupChangeResult;
    }

} // End Of Class

public static class InnerDirectConnectGatewayAttachmentProposedNetworkFunctionGroupChangeFactoryExtensions
{
}
