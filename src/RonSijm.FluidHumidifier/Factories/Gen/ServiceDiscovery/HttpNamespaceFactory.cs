// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class HttpNamespaceFactory(string resourceName = null, Action<Humidifier.ServiceDiscovery.HttpNamespace> factoryAction = null) : ResourceFactory<Humidifier.ServiceDiscovery.HttpNamespace>(resourceName)
{

    protected override Humidifier.ServiceDiscovery.HttpNamespace Create()
    {
        var httpNamespaceResult = CreateHttpNamespace();
        factoryAction?.Invoke(httpNamespaceResult);

        return httpNamespaceResult;
    }

    private Humidifier.ServiceDiscovery.HttpNamespace CreateHttpNamespace()
    {
        var httpNamespaceResult = new Humidifier.ServiceDiscovery.HttpNamespace
        {
            GivenName = InputResourceName,
        };

        return httpNamespaceResult;
    }

} // End Of Class

public static class HttpNamespaceFactoryExtensions
{
}
