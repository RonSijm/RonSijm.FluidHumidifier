// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Notifications;

public class OrganizationalUnitAssociationFactory(string resourceName = null, Action<Humidifier.Notifications.OrganizationalUnitAssociation> factoryAction = null) : ResourceFactory<Humidifier.Notifications.OrganizationalUnitAssociation>(resourceName)
{

    protected override Humidifier.Notifications.OrganizationalUnitAssociation Create()
    {
        var organizationalUnitAssociationResult = CreateOrganizationalUnitAssociation();
        factoryAction?.Invoke(organizationalUnitAssociationResult);

        return organizationalUnitAssociationResult;
    }

    private Humidifier.Notifications.OrganizationalUnitAssociation CreateOrganizationalUnitAssociation()
    {
        var organizationalUnitAssociationResult = new Humidifier.Notifications.OrganizationalUnitAssociation
        {
            GivenName = InputResourceName,
        };

        return organizationalUnitAssociationResult;
    }

} // End Of Class

public static class OrganizationalUnitAssociationFactoryExtensions
{
}
