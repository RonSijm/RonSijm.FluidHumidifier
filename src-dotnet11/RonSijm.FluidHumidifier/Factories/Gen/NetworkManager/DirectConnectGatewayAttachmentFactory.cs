// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class DirectConnectGatewayAttachmentFactory(string resourceName = null, Action<Humidifier.NetworkManager.DirectConnectGatewayAttachment> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.DirectConnectGatewayAttachment>(resourceName)
{

    protected override Humidifier.NetworkManager.DirectConnectGatewayAttachment Create()
    {
        var directConnectGatewayAttachmentResult = CreateDirectConnectGatewayAttachment();
        factoryAction?.Invoke(directConnectGatewayAttachmentResult);

        return directConnectGatewayAttachmentResult;
    }

    private Humidifier.NetworkManager.DirectConnectGatewayAttachment CreateDirectConnectGatewayAttachment()
    {
        var directConnectGatewayAttachmentResult = new Humidifier.NetworkManager.DirectConnectGatewayAttachment
        {
            GivenName = InputResourceName,
        };

        return directConnectGatewayAttachmentResult;
    }

} // End Of Class

public static class DirectConnectGatewayAttachmentFactoryExtensions
{
}
