// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalogAppRegistry;

public class AttributeGroupAssociationFactory(string resourceName = null, Action<Humidifier.ServiceCatalogAppRegistry.AttributeGroupAssociation> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalogAppRegistry.AttributeGroupAssociation>(resourceName)
{

    protected override Humidifier.ServiceCatalogAppRegistry.AttributeGroupAssociation Create()
    {
        var attributeGroupAssociationResult = CreateAttributeGroupAssociation();
        factoryAction?.Invoke(attributeGroupAssociationResult);

        return attributeGroupAssociationResult;
    }

    private Humidifier.ServiceCatalogAppRegistry.AttributeGroupAssociation CreateAttributeGroupAssociation()
    {
        var attributeGroupAssociationResult = new Humidifier.ServiceCatalogAppRegistry.AttributeGroupAssociation
        {
            GivenName = InputResourceName,
        };

        return attributeGroupAssociationResult;
    }

} // End Of Class

public static class AttributeGroupAssociationFactoryExtensions
{
}
