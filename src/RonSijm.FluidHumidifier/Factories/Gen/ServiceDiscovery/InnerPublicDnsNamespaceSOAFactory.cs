// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class InnerPublicDnsNamespaceSOAFactory(Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> factoryAction = null) : SubResourceFactory<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA>
{

    protected override Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA Create()
    {
        var sOAResult = CreateSOA();
        factoryAction?.Invoke(sOAResult);

        return sOAResult;
    }

    private Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA CreateSOA()
    {
        var sOAResult = new Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA();

        return sOAResult;
    }

} // End Of Class

public static class InnerPublicDnsNamespaceSOAFactoryExtensions
{
}
