// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Notifications;

public class ManagedNotificationAccountContactAssociationFactory(string resourceName = null, Action<Humidifier.Notifications.ManagedNotificationAccountContactAssociation> factoryAction = null) : ResourceFactory<Humidifier.Notifications.ManagedNotificationAccountContactAssociation>(resourceName)
{

    protected override Humidifier.Notifications.ManagedNotificationAccountContactAssociation Create()
    {
        var managedNotificationAccountContactAssociationResult = CreateManagedNotificationAccountContactAssociation();
        factoryAction?.Invoke(managedNotificationAccountContactAssociationResult);

        return managedNotificationAccountContactAssociationResult;
    }

    private Humidifier.Notifications.ManagedNotificationAccountContactAssociation CreateManagedNotificationAccountContactAssociation()
    {
        var managedNotificationAccountContactAssociationResult = new Humidifier.Notifications.ManagedNotificationAccountContactAssociation
        {
            GivenName = InputResourceName,
        };

        return managedNotificationAccountContactAssociationResult;
    }

} // End Of Class

public static class ManagedNotificationAccountContactAssociationFactoryExtensions
{
}
