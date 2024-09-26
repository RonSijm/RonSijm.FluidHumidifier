// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class LoadBalancerFactory(string resourceName = null, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancer> factoryAction = null) : ResourceFactory<Humidifier.ElasticLoadBalancingV2.LoadBalancer>(resourceName)
{

    internal List<InnerLoadBalancerLoadBalancerAttributeFactory> LoadBalancerAttributesFactories { get; set; } = [];

    internal List<InnerLoadBalancerSubnetMappingFactory> SubnetMappingsFactories { get; set; } = [];

    protected override Humidifier.ElasticLoadBalancingV2.LoadBalancer Create()
    {
        var loadBalancerResult = CreateLoadBalancer();
        factoryAction?.Invoke(loadBalancerResult);

        return loadBalancerResult;
    }

    private Humidifier.ElasticLoadBalancingV2.LoadBalancer CreateLoadBalancer()
    {
        var loadBalancerResult = new Humidifier.ElasticLoadBalancingV2.LoadBalancer
        {
            GivenName = InputResourceName,
        };

        return loadBalancerResult;
    }
    public override void CreateChildren(Humidifier.ElasticLoadBalancingV2.LoadBalancer result)
    {
        base.CreateChildren(result);

        result.LoadBalancerAttributes = LoadBalancerAttributesFactories.Any() ? LoadBalancerAttributesFactories.Select(x => x.Build()).ToList() : null;
        result.SubnetMappings = SubnetMappingsFactories.Any() ? SubnetMappingsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class LoadBalancerFactoryExtensions
{
    public static CombinedResult<LoadBalancerFactory, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes(this LoadBalancerFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null)
    {
        var factory = new InnerLoadBalancerLoadBalancerAttributeFactory(subFactoryAction);
        parentFactory.LoadBalancerAttributesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LoadBalancerFactory, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings(this LoadBalancerFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null)
    {
        var factory = new InnerLoadBalancerSubnetMappingFactory(subFactoryAction);
        parentFactory.SubnetMappingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LoadBalancerFactory, T1, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1>(this CombinedResult<LoadBalancerFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoadBalancerFactory, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1>(this CombinedResult<T1, LoadBalancerFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LoadBalancerFactory, T1, T2, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2>(this CombinedResult<LoadBalancerFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoadBalancerFactory, T2, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2>(this CombinedResult<T1, LoadBalancerFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoadBalancerFactory, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2>(this CombinedResult<T1, T2, LoadBalancerFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LoadBalancerFactory, T1, T2, T3, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2, T3>(this CombinedResult<LoadBalancerFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoadBalancerFactory, T2, T3, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2, T3>(this CombinedResult<T1, LoadBalancerFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoadBalancerFactory, T3, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2, T3>(this CombinedResult<T1, T2, LoadBalancerFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoadBalancerFactory, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, LoadBalancerFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LoadBalancerFactory, T1, T2, T3, T4, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2, T3, T4>(this CombinedResult<LoadBalancerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoadBalancerFactory, T2, T3, T4, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2, T3, T4>(this CombinedResult<T1, LoadBalancerFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoadBalancerFactory, T3, T4, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, LoadBalancerFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoadBalancerFactory, T4, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LoadBalancerFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LoadBalancerFactory, InnerLoadBalancerLoadBalancerAttributeFactory> WithLoadBalancerAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LoadBalancerFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancerAttributes(combinedResult.T5, subFactoryAction));
    public static CombinedResult<LoadBalancerFactory, T1, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1>(this CombinedResult<LoadBalancerFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubnetMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoadBalancerFactory, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1>(this CombinedResult<T1, LoadBalancerFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubnetMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LoadBalancerFactory, T1, T2, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2>(this CombinedResult<LoadBalancerFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoadBalancerFactory, T2, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2>(this CombinedResult<T1, LoadBalancerFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoadBalancerFactory, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2>(this CombinedResult<T1, T2, LoadBalancerFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LoadBalancerFactory, T1, T2, T3, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2, T3>(this CombinedResult<LoadBalancerFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoadBalancerFactory, T2, T3, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2, T3>(this CombinedResult<T1, LoadBalancerFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoadBalancerFactory, T3, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2, T3>(this CombinedResult<T1, T2, LoadBalancerFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoadBalancerFactory, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, LoadBalancerFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LoadBalancerFactory, T1, T2, T3, T4, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2, T3, T4>(this CombinedResult<LoadBalancerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoadBalancerFactory, T2, T3, T4, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2, T3, T4>(this CombinedResult<T1, LoadBalancerFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoadBalancerFactory, T3, T4, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, LoadBalancerFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoadBalancerFactory, T4, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LoadBalancerFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LoadBalancerFactory, InnerLoadBalancerSubnetMappingFactory> WithSubnetMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LoadBalancerFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubnetMappings(combinedResult.T5, subFactoryAction));
}
