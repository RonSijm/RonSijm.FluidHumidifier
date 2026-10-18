// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class InnerPrivateDnsNamespaceSOAFactory(Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> factoryAction = null) : SubResourceFactory<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA>
{

    protected override Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA Create()
    {
        var sOAResult = CreateSOA();
        factoryAction?.Invoke(sOAResult);

        return sOAResult;
    }

    private Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA CreateSOA()
    {
        var sOAResult = new Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA();

        return sOAResult;
    }

} // End Of Class

public static class InnerPrivateDnsNamespaceSOAFactoryExtensions
{
}
