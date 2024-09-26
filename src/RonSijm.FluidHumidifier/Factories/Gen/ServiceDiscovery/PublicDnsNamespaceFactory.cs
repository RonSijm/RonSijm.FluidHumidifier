// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class PublicDnsNamespaceFactory(string resourceName = null, Action<Humidifier.ServiceDiscovery.PublicDnsNamespace> factoryAction = null) : ResourceFactory<Humidifier.ServiceDiscovery.PublicDnsNamespace>(resourceName)
{

    internal InnerPublicDnsNamespacePropertiesFactory PropertiesFactory { get; set; }

    protected override Humidifier.ServiceDiscovery.PublicDnsNamespace Create()
    {
        var publicDnsNamespaceResult = CreatePublicDnsNamespace();
        factoryAction?.Invoke(publicDnsNamespaceResult);

        return publicDnsNamespaceResult;
    }

    private Humidifier.ServiceDiscovery.PublicDnsNamespace CreatePublicDnsNamespace()
    {
        var publicDnsNamespaceResult = new Humidifier.ServiceDiscovery.PublicDnsNamespace
        {
            GivenName = InputResourceName,
        };

        return publicDnsNamespaceResult;
    }
    public override void CreateChildren(Humidifier.ServiceDiscovery.PublicDnsNamespace result)
    {
        base.CreateChildren(result);

        result.Properties ??= PropertiesFactory?.Build();
    }

} // End Of Class

public static class PublicDnsNamespaceFactoryExtensions
{
    public static CombinedResult<PublicDnsNamespaceFactory, InnerPublicDnsNamespacePropertiesFactory> WithProperties(this PublicDnsNamespaceFactory parentFactory, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null)
    {
        parentFactory.PropertiesFactory = new InnerPublicDnsNamespacePropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PropertiesFactory);
    }

    public static CombinedResult<PublicDnsNamespaceFactory, T1, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1>(this CombinedResult<PublicDnsNamespaceFactory, T1> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicDnsNamespaceFactory, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1>(this CombinedResult<T1, PublicDnsNamespaceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PublicDnsNamespaceFactory, T1, T2, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2>(this CombinedResult<PublicDnsNamespaceFactory, T1, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicDnsNamespaceFactory, T2, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2>(this CombinedResult<T1, PublicDnsNamespaceFactory, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PublicDnsNamespaceFactory, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2>(this CombinedResult<T1, T2, PublicDnsNamespaceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PublicDnsNamespaceFactory, T1, T2, T3, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<PublicDnsNamespaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicDnsNamespaceFactory, T2, T3, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, PublicDnsNamespaceFactory, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PublicDnsNamespaceFactory, T3, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, T2, PublicDnsNamespaceFactory, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PublicDnsNamespaceFactory, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, PublicDnsNamespaceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PublicDnsNamespaceFactory, T1, T2, T3, T4, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<PublicDnsNamespaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicDnsNamespaceFactory, T2, T3, T4, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, PublicDnsNamespaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PublicDnsNamespaceFactory, T3, T4, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, PublicDnsNamespaceFactory, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PublicDnsNamespaceFactory, T4, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PublicDnsNamespaceFactory, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PublicDnsNamespaceFactory, InnerPublicDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PublicDnsNamespaceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PublicDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T5, subFactoryAction));
}
