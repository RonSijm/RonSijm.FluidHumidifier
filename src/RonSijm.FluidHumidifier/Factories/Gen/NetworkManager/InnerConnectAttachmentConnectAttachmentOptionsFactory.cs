// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerConnectAttachmentConnectAttachmentOptionsFactory(Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions>
{

    protected override Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions Create()
    {
        var connectAttachmentOptionsResult = CreateConnectAttachmentOptions();
        factoryAction?.Invoke(connectAttachmentOptionsResult);

        return connectAttachmentOptionsResult;
    }

    private Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions CreateConnectAttachmentOptions()
    {
        var connectAttachmentOptionsResult = new Humidifier.NetworkManager.ConnectAttachmentTypes.ConnectAttachmentOptions();

        return connectAttachmentOptionsResult;
    }

} // End Of Class

public static class InnerConnectAttachmentConnectAttachmentOptionsFactoryExtensions
{
}
