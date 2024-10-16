// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class InnerPrivateDnsNamespacePropertiesFactory(Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> factoryAction = null) : SubResourceFactory<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties>
{

    internal InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory DnsPropertiesFactory { get; set; }

    protected override Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties Create()
    {
        var propertiesResult = CreateProperties();
        factoryAction?.Invoke(propertiesResult);

        return propertiesResult;
    }

    private Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties CreateProperties()
    {
        var propertiesResult = new Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties();

        return propertiesResult;
    }
    public override void CreateChildren(Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties result)
    {
        base.CreateChildren(result);

        result.DnsProperties ??= DnsPropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerPrivateDnsNamespacePropertiesFactoryExtensions
{
    public static CombinedResult<InnerPrivateDnsNamespacePropertiesFactory, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties(this InnerPrivateDnsNamespacePropertiesFactory parentFactory, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null)
    {
        parentFactory.DnsPropertiesFactory = new InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DnsPropertiesFactory);
    }

    public static CombinedResult<InnerPrivateDnsNamespacePropertiesFactory, T1, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1>(this CombinedResult<InnerPrivateDnsNamespacePropertiesFactory, T1> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrivateDnsNamespacePropertiesFactory, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1>(this CombinedResult<T1, InnerPrivateDnsNamespacePropertiesFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPrivateDnsNamespacePropertiesFactory, T1, T2, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2>(this CombinedResult<InnerPrivateDnsNamespacePropertiesFactory, T1, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrivateDnsNamespacePropertiesFactory, T2, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2>(this CombinedResult<T1, InnerPrivateDnsNamespacePropertiesFactory, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPrivateDnsNamespacePropertiesFactory, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2>(this CombinedResult<T1, T2, InnerPrivateDnsNamespacePropertiesFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPrivateDnsNamespacePropertiesFactory, T1, T2, T3, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3>(this CombinedResult<InnerPrivateDnsNamespacePropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrivateDnsNamespacePropertiesFactory, T2, T3, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3>(this CombinedResult<T1, InnerPrivateDnsNamespacePropertiesFactory, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPrivateDnsNamespacePropertiesFactory, T3, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerPrivateDnsNamespacePropertiesFactory, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPrivateDnsNamespacePropertiesFactory, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPrivateDnsNamespacePropertiesFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPrivateDnsNamespacePropertiesFactory, T1, T2, T3, T4, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3, T4>(this CombinedResult<InnerPrivateDnsNamespacePropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrivateDnsNamespacePropertiesFactory, T2, T3, T4, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerPrivateDnsNamespacePropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPrivateDnsNamespacePropertiesFactory, T3, T4, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPrivateDnsNamespacePropertiesFactory, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPrivateDnsNamespacePropertiesFactory, T4, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPrivateDnsNamespacePropertiesFactory, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPrivateDnsNamespacePropertiesFactory, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPrivateDnsNamespacePropertiesFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T5, subFactoryAction));
}
