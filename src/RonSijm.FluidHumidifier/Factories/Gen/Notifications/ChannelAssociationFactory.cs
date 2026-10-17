// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Notifications;

public class ChannelAssociationFactory(string resourceName = null, Action<Humidifier.Notifications.ChannelAssociation> factoryAction = null) : ResourceFactory<Humidifier.Notifications.ChannelAssociation>(resourceName)
{

    protected override Humidifier.Notifications.ChannelAssociation Create()
    {
        var channelAssociationResult = CreateChannelAssociation();
        factoryAction?.Invoke(channelAssociationResult);

        return channelAssociationResult;
    }

    private Humidifier.Notifications.ChannelAssociation CreateChannelAssociation()
    {
        var channelAssociationResult = new Humidifier.Notifications.ChannelAssociation
        {
            GivenName = InputResourceName,
        };

        return channelAssociationResult;
    }

} // End Of Class

public static class ChannelAssociationFactoryExtensions
{
}
