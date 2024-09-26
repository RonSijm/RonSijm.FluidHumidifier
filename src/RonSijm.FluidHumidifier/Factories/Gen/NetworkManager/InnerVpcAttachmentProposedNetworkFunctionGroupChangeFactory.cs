// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerVpcAttachmentProposedNetworkFunctionGroupChangeFactory(Action<Humidifier.NetworkManager.VpcAttachmentTypes.ProposedNetworkFunctionGroupChange> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.VpcAttachmentTypes.ProposedNetworkFunctionGroupChange>
{

    protected override Humidifier.NetworkManager.VpcAttachmentTypes.ProposedNetworkFunctionGroupChange Create()
    {
        var proposedNetworkFunctionGroupChangeResult = CreateProposedNetworkFunctionGroupChange();
        factoryAction?.Invoke(proposedNetworkFunctionGroupChangeResult);

        return proposedNetworkFunctionGroupChangeResult;
    }

    private Humidifier.NetworkManager.VpcAttachmentTypes.ProposedNetworkFunctionGroupChange CreateProposedNetworkFunctionGroupChange()
    {
        var proposedNetworkFunctionGroupChangeResult = new Humidifier.NetworkManager.VpcAttachmentTypes.ProposedNetworkFunctionGroupChange();

        return proposedNetworkFunctionGroupChangeResult;
    }

} // End Of Class

public static class InnerVpcAttachmentProposedNetworkFunctionGroupChangeFactoryExtensions
{
}
