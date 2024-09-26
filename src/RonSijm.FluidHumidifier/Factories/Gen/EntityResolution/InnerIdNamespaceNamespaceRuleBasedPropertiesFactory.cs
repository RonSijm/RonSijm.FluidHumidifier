// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerIdNamespaceNamespaceRuleBasedPropertiesFactory(Action<Humidifier.EntityResolution.IdNamespaceTypes.NamespaceRuleBasedProperties> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.IdNamespaceTypes.NamespaceRuleBasedProperties>
{

    protected override Humidifier.EntityResolution.IdNamespaceTypes.NamespaceRuleBasedProperties Create()
    {
        var namespaceRuleBasedPropertiesResult = CreateNamespaceRuleBasedProperties();
        factoryAction?.Invoke(namespaceRuleBasedPropertiesResult);

        return namespaceRuleBasedPropertiesResult;
    }

    private Humidifier.EntityResolution.IdNamespaceTypes.NamespaceRuleBasedProperties CreateNamespaceRuleBasedProperties()
    {
        var namespaceRuleBasedPropertiesResult = new Humidifier.EntityResolution.IdNamespaceTypes.NamespaceRuleBasedProperties();

        return namespaceRuleBasedPropertiesResult;
    }

} // End Of Class

public static class InnerIdNamespaceNamespaceRuleBasedPropertiesFactoryExtensions
{
}
