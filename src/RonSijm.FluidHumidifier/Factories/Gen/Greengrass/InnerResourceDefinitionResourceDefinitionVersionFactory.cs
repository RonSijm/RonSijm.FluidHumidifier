// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionResourceDefinitionVersionFactory(Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion>
{

    internal List<InnerResourceDefinitionResourceInstanceFactory> ResourcesFactories { get; set; } = [];

    protected override Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion Create()
    {
        var resourceDefinitionVersionResult = CreateResourceDefinitionVersion();
        factoryAction?.Invoke(resourceDefinitionVersionResult);

        return resourceDefinitionVersionResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion CreateResourceDefinitionVersion()
    {
        var resourceDefinitionVersionResult = new Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion();

        return resourceDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Resources = ResourcesFactories.Any() ? ResourcesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerResourceDefinitionResourceDefinitionVersionFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionResourceDefinitionVersionFactory, InnerResourceDefinitionResourceInstanceFactory> WithResources(this InnerResourceDefinitionResourceDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null)
    {
        var factory = new InnerResourceDefinitionResourceInstanceFactory(subFactoryAction);
        parentFactory.ResourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerResourceDefinitionResourceDefinitionVersionFactory, T1, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1>(this CombinedResult<InnerResourceDefinitionResourceDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionResourceDefinitionVersionFactory, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1>(this CombinedResult<T1, InnerResourceDefinitionResourceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionResourceDefinitionVersionFactory, T1, T2, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2>(this CombinedResult<InnerResourceDefinitionResourceDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionResourceDefinitionVersionFactory, T2, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionResourceDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionResourceDefinitionVersionFactory, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionResourceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionResourceDefinitionVersionFactory, T1, T2, T3, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionResourceDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionResourceDefinitionVersionFactory, T2, T3, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionResourceDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionResourceDefinitionVersionFactory, T3, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionResourceDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionResourceDefinitionVersionFactory, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionResourceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionResourceDefinitionVersionFactory, T1, T2, T3, T4, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionResourceDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionResourceDefinitionVersionFactory, T2, T3, T4, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionResourceDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionResourceDefinitionVersionFactory, T3, T4, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionResourceDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionResourceDefinitionVersionFactory, T4, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionResourceDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionResourceDefinitionVersionFactory, InnerResourceDefinitionResourceInstanceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionResourceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T5, subFactoryAction));
}
