// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class InnerPublicDnsNamespacePropertiesFactory(Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> factoryAction = null) : SubResourceFactory<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties>
{

    internal InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory DnsPropertiesFactory { get; set; }

    protected override Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties Create()
    {
        var propertiesResult = CreateProperties();
        factoryAction?.Invoke(propertiesResult);

        return propertiesResult;
    }

    private Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties CreateProperties()
    {
        var propertiesResult = new Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties();

        return propertiesResult;
    }
    public override void CreateChildren(Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties result)
    {
        base.CreateChildren(result);

        result.DnsProperties ??= DnsPropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerPublicDnsNamespacePropertiesFactoryExtensions
{
    public static CombinedResult<InnerPublicDnsNamespacePropertiesFactory, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties(this InnerPublicDnsNamespacePropertiesFactory parentFactory, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null)
    {
        parentFactory.DnsPropertiesFactory = new InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DnsPropertiesFactory);
    }

    public static CombinedResult<InnerPublicDnsNamespacePropertiesFactory, T1, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1>(this CombinedResult<InnerPublicDnsNamespacePropertiesFactory, T1> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPublicDnsNamespacePropertiesFactory, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1>(this CombinedResult<T1, InnerPublicDnsNamespacePropertiesFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPublicDnsNamespacePropertiesFactory, T1, T2, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2>(this CombinedResult<InnerPublicDnsNamespacePropertiesFactory, T1, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPublicDnsNamespacePropertiesFactory, T2, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2>(this CombinedResult<T1, InnerPublicDnsNamespacePropertiesFactory, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPublicDnsNamespacePropertiesFactory, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2>(this CombinedResult<T1, T2, InnerPublicDnsNamespacePropertiesFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPublicDnsNamespacePropertiesFactory, T1, T2, T3, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3>(this CombinedResult<InnerPublicDnsNamespacePropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPublicDnsNamespacePropertiesFactory, T2, T3, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3>(this CombinedResult<T1, InnerPublicDnsNamespacePropertiesFactory, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPublicDnsNamespacePropertiesFactory, T3, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerPublicDnsNamespacePropertiesFactory, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPublicDnsNamespacePropertiesFactory, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPublicDnsNamespacePropertiesFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPublicDnsNamespacePropertiesFactory, T1, T2, T3, T4, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3, T4>(this CombinedResult<InnerPublicDnsNamespacePropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPublicDnsNamespacePropertiesFactory, T2, T3, T4, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerPublicDnsNamespacePropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPublicDnsNamespacePropertiesFactory, T3, T4, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPublicDnsNamespacePropertiesFactory, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPublicDnsNamespacePropertiesFactory, T4, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPublicDnsNamespacePropertiesFactory, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPublicDnsNamespacePropertiesFactory, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> WithDnsProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPublicDnsNamespacePropertiesFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsProperties(combinedResult.T5, subFactoryAction));
}
