// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class ApplicationEntitlementAssociationFactory(string resourceName = null, Action<Humidifier.AppStream.ApplicationEntitlementAssociation> factoryAction = null) : ResourceFactory<Humidifier.AppStream.ApplicationEntitlementAssociation>(resourceName)
{

    protected override Humidifier.AppStream.ApplicationEntitlementAssociation Create()
    {
        var applicationEntitlementAssociationResult = CreateApplicationEntitlementAssociation();
        factoryAction?.Invoke(applicationEntitlementAssociationResult);

        return applicationEntitlementAssociationResult;
    }

    private Humidifier.AppStream.ApplicationEntitlementAssociation CreateApplicationEntitlementAssociation()
    {
        var applicationEntitlementAssociationResult = new Humidifier.AppStream.ApplicationEntitlementAssociation
        {
            GivenName = InputResourceName,
        };

        return applicationEntitlementAssociationResult;
    }

} // End Of Class

public static class ApplicationEntitlementAssociationFactoryExtensions
{
}
