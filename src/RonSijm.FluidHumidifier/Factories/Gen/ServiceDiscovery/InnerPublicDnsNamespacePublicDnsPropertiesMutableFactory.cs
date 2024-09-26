// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory(Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable> factoryAction = null) : SubResourceFactory<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable>
{

    internal InnerPublicDnsNamespaceSOAFactory SOAFactory { get; set; }

    protected override Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable Create()
    {
        var publicDnsPropertiesMutableResult = CreatePublicDnsPropertiesMutable();
        factoryAction?.Invoke(publicDnsPropertiesMutableResult);

        return publicDnsPropertiesMutableResult;
    }

    private Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable CreatePublicDnsPropertiesMutable()
    {
        var publicDnsPropertiesMutableResult = new Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable();

        return publicDnsPropertiesMutableResult;
    }
    public override void CreateChildren(Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.PublicDnsPropertiesMutable result)
    {
        base.CreateChildren(result);

        result.SOA ??= SOAFactory?.Build();
    }

} // End Of Class

public static class InnerPublicDnsNamespacePublicDnsPropertiesMutableFactoryExtensions
{
    public static CombinedResult<InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, InnerPublicDnsNamespaceSOAFactory> WithSOA(this InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory parentFactory, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null)
    {
        parentFactory.SOAFactory = new InnerPublicDnsNamespaceSOAFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SOAFactory);
    }

    public static CombinedResult<InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T1, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1>(this CombinedResult<InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T1> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, WithSOA(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1>(this CombinedResult<T1, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, WithSOA(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T1, T2, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2>(this CombinedResult<InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T1, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T2, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2>(this CombinedResult<T1, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2>(this CombinedResult<T1, T2, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T1, T2, T3, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2, T3>(this CombinedResult<InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T2, T3, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2, T3>(this CombinedResult<T1, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T3, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2, T3>(this CombinedResult<T1, T2, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T1, T2, T3, T4, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2, T3, T4>(this CombinedResult<InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T2, T3, T4, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2, T3, T4>(this CombinedResult<T1, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T3, T4, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T4, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory, InnerPublicDnsNamespaceSOAFactory> WithSOA<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPublicDnsNamespacePublicDnsPropertiesMutableFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T5, subFactoryAction));
}
