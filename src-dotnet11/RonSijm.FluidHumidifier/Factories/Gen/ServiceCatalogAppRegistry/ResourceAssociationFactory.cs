// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalogAppRegistry;

public class ResourceAssociationFactory(string resourceName = null, Action<Humidifier.ServiceCatalogAppRegistry.ResourceAssociation> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalogAppRegistry.ResourceAssociation>(resourceName)
{

    protected override Humidifier.ServiceCatalogAppRegistry.ResourceAssociation Create()
    {
        var resourceAssociationResult = CreateResourceAssociation();
        factoryAction?.Invoke(resourceAssociationResult);

        return resourceAssociationResult;
    }

    private Humidifier.ServiceCatalogAppRegistry.ResourceAssociation CreateResourceAssociation()
    {
        var resourceAssociationResult = new Humidifier.ServiceCatalogAppRegistry.ResourceAssociation
        {
            GivenName = InputResourceName,
        };

        return resourceAssociationResult;
    }

} // End Of Class

public static class ResourceAssociationFactoryExtensions
{
}
