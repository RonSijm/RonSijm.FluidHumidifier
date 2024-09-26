// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class PrivateDnsNamespaceFactory(string resourceName = null, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespace> factoryAction = null) : ResourceFactory<Humidifier.ServiceDiscovery.PrivateDnsNamespace>(resourceName)
{

    internal InnerPrivateDnsNamespacePropertiesFactory PropertiesFactory { get; set; }

    protected override Humidifier.ServiceDiscovery.PrivateDnsNamespace Create()
    {
        var privateDnsNamespaceResult = CreatePrivateDnsNamespace();
        factoryAction?.Invoke(privateDnsNamespaceResult);

        return privateDnsNamespaceResult;
    }

    private Humidifier.ServiceDiscovery.PrivateDnsNamespace CreatePrivateDnsNamespace()
    {
        var privateDnsNamespaceResult = new Humidifier.ServiceDiscovery.PrivateDnsNamespace
        {
            GivenName = InputResourceName,
        };

        return privateDnsNamespaceResult;
    }
    public override void CreateChildren(Humidifier.ServiceDiscovery.PrivateDnsNamespace result)
    {
        base.CreateChildren(result);

        result.Properties ??= PropertiesFactory?.Build();
    }

} // End Of Class

public static class PrivateDnsNamespaceFactoryExtensions
{
    public static CombinedResult<PrivateDnsNamespaceFactory, InnerPrivateDnsNamespacePropertiesFactory> WithProperties(this PrivateDnsNamespaceFactory parentFactory, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null)
    {
        parentFactory.PropertiesFactory = new InnerPrivateDnsNamespacePropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PropertiesFactory);
    }

    public static CombinedResult<PrivateDnsNamespaceFactory, T1, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1>(this CombinedResult<PrivateDnsNamespaceFactory, T1> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrivateDnsNamespaceFactory, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1>(this CombinedResult<T1, PrivateDnsNamespaceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PrivateDnsNamespaceFactory, T1, T2, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2>(this CombinedResult<PrivateDnsNamespaceFactory, T1, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrivateDnsNamespaceFactory, T2, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2>(this CombinedResult<T1, PrivateDnsNamespaceFactory, T2> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrivateDnsNamespaceFactory, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2>(this CombinedResult<T1, T2, PrivateDnsNamespaceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PrivateDnsNamespaceFactory, T1, T2, T3, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<PrivateDnsNamespaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrivateDnsNamespaceFactory, T2, T3, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, PrivateDnsNamespaceFactory, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrivateDnsNamespaceFactory, T3, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, T2, PrivateDnsNamespaceFactory, T3> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PrivateDnsNamespaceFactory, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, PrivateDnsNamespaceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PrivateDnsNamespaceFactory, T1, T2, T3, T4, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<PrivateDnsNamespaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PrivateDnsNamespaceFactory, T2, T3, T4, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, PrivateDnsNamespaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PrivateDnsNamespaceFactory, T3, T4, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, PrivateDnsNamespaceFactory, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PrivateDnsNamespaceFactory, T4, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PrivateDnsNamespaceFactory, T4> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PrivateDnsNamespaceFactory, InnerPrivateDnsNamespacePropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PrivateDnsNamespaceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.PrivateDnsNamespaceTypes.Properties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T5, subFactoryAction));
}
