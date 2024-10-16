// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalogAppRegistry;

public class AttributeGroupFactory(string resourceName = null, Action<Humidifier.ServiceCatalogAppRegistry.AttributeGroup> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalogAppRegistry.AttributeGroup>(resourceName)
{

    protected override Humidifier.ServiceCatalogAppRegistry.AttributeGroup Create()
    {
        var attributeGroupResult = CreateAttributeGroup();
        factoryAction?.Invoke(attributeGroupResult);

        return attributeGroupResult;
    }

    private Humidifier.ServiceCatalogAppRegistry.AttributeGroup CreateAttributeGroup()
    {
        var attributeGroupResult = new Humidifier.ServiceCatalogAppRegistry.AttributeGroup
        {
            GivenName = InputResourceName,
        };

        return attributeGroupResult;
    }

} // End Of Class

public static class AttributeGroupFactoryExtensions
{
}
