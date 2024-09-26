// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory(Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable> factoryAction = null) : SubResourceFactory<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable>
{

    internal InnerPrivateDnsNamespaceSOAFactory SOAFactory { get; set; }

    protected override Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable Create()
    {
        var privateDnsPropertiesMutableResult = CreatePrivateDnsPropertiesMutable();
        factoryAction?.Invoke(privateDnsPropertiesMutableResult);

        return privateDnsPropertiesMutableResult;
    }

    private Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable CreatePrivateDnsPropertiesMutable()
    {
        var privateDnsPropertiesMutableResult = new Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable();

        return privateDnsPropertiesMutableResult;
    }
    public override void CreateChildren(Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.PrivateDnsPropertiesMutable result)
    {
        base.CreateChildren(result);

        result.SOA ??= SOAFactory?.Build();
    }

} // End Of Class

public static class InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactoryExtensions
{
    public static CombinedResult<InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, InnerPrivateDnsNamespaceSOAFactory> WithSOA(this InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory parentFactory, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null)
    {
        parentFactory.SOAFactory = new InnerPrivateDnsNamespaceSOAFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SOAFactory);
    }

    public static CombinedResult<InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T1, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1>(this CombinedResult<InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T1> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, WithSOA(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1>(this CombinedResult<T1, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, WithSOA(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T1, T2, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2>(this CombinedResult<InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T1, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T2, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2>(this CombinedResult<T1, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2>(this CombinedResult<T1, T2, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T1, T2, T3, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2, T3>(this CombinedResult<InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T2, T3, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2, T3>(this CombinedResult<T1, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T3, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2, T3>(this CombinedResult<T1, T2, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T1, T2, T3, T4, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2, T3, T4>(this CombinedResult<InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T2, T3, T4, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2, T3, T4>(this CombinedResult<T1, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T3, T4, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T4, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory, InnerPrivateDnsNamespaceSOAFactory> WithSOA<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPrivateDnsNamespacePrivateDnsPropertiesMutableFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.SOA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSOA(combinedResult.T5, subFactoryAction));
}
