// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactory(Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange>
{

    protected override Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange Create()
    {
        var proposedNetworkFunctionGroupChangeResult = CreateProposedNetworkFunctionGroupChange();
        factoryAction?.Invoke(proposedNetworkFunctionGroupChangeResult);

        return proposedNetworkFunctionGroupChangeResult;
    }

    private Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange CreateProposedNetworkFunctionGroupChange()
    {
        var proposedNetworkFunctionGroupChangeResult = new Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedNetworkFunctionGroupChange();

        return proposedNetworkFunctionGroupChangeResult;
    }

} // End Of Class

public static class InnerConnectAttachmentProposedNetworkFunctionGroupChangeFactoryExtensions
{
}
