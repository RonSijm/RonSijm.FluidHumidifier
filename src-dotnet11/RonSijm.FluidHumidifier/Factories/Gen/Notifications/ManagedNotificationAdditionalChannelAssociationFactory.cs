// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Notifications;

public class ManagedNotificationAdditionalChannelAssociationFactory(string resourceName = null, Action<Humidifier.Notifications.ManagedNotificationAdditionalChannelAssociation> factoryAction = null) : ResourceFactory<Humidifier.Notifications.ManagedNotificationAdditionalChannelAssociation>(resourceName)
{

    protected override Humidifier.Notifications.ManagedNotificationAdditionalChannelAssociation Create()
    {
        var managedNotificationAdditionalChannelAssociationResult = CreateManagedNotificationAdditionalChannelAssociation();
        factoryAction?.Invoke(managedNotificationAdditionalChannelAssociationResult);

        return managedNotificationAdditionalChannelAssociationResult;
    }

    private Humidifier.Notifications.ManagedNotificationAdditionalChannelAssociation CreateManagedNotificationAdditionalChannelAssociation()
    {
        var managedNotificationAdditionalChannelAssociationResult = new Humidifier.Notifications.ManagedNotificationAdditionalChannelAssociation
        {
            GivenName = InputResourceName,
        };

        return managedNotificationAdditionalChannelAssociationResult;
    }

} // End Of Class

public static class ManagedNotificationAdditionalChannelAssociationFactoryExtensions
{
}
