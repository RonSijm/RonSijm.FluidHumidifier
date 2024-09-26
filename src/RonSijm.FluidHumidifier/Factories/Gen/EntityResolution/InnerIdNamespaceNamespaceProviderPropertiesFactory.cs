// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerIdNamespaceNamespaceProviderPropertiesFactory(Action<Humidifier.EntityResolution.IdNamespaceTypes.NamespaceProviderProperties> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.IdNamespaceTypes.NamespaceProviderProperties>
{

    protected override Humidifier.EntityResolution.IdNamespaceTypes.NamespaceProviderProperties Create()
    {
        var namespaceProviderPropertiesResult = CreateNamespaceProviderProperties();
        factoryAction?.Invoke(namespaceProviderPropertiesResult);

        return namespaceProviderPropertiesResult;
    }

    private Humidifier.EntityResolution.IdNamespaceTypes.NamespaceProviderProperties CreateNamespaceProviderProperties()
    {
        var namespaceProviderPropertiesResult = new Humidifier.EntityResolution.IdNamespaceTypes.NamespaceProviderProperties();

        return namespaceProviderPropertiesResult;
    }

} // End Of Class

public static class InnerIdNamespaceNamespaceProviderPropertiesFactoryExtensions
{
}
