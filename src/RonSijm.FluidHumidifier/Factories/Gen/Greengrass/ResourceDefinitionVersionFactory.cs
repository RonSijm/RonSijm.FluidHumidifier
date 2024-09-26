// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class ResourceDefinitionVersionFactory(string resourceName = null, Action<Humidifier.Greengrass.ResourceDefinitionVersion> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.ResourceDefinitionVersion>(resourceName)
{

    internal List<InnerResourceDefinitionVersionResourceInstanceFactory> ResourcesFactories { get; set; } = [];

    protected override Humidifier.Greengrass.ResourceDefinitionVersion Create()
    {
        var resourceDefinitionVersionResult = CreateResourceDefinitionVersion();
        factoryAction?.Invoke(resourceDefinitionVersionResult);

        return resourceDefinitionVersionResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionVersion CreateResourceDefinitionVersion()
    {
        var resourceDefinitionVersionResult = new Humidifier.Greengrass.ResourceDefinitionVersion
        {
            GivenName = InputResourceName,
        };

        return resourceDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Resources = ResourcesFactories.Any() ? ResourcesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ResourceDefinitionVersionFactoryExtensions
{
    public static CombinedResult<ResourceDefinitionVersionFactory, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources(this ResourceDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null)
    {
        var factory = new InnerResourceDefinitionVersionResourceInstanceFactory(subFactoryAction);
        parentFactory.ResourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ResourceDefinitionVersionFactory, T1, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1>(this CombinedResult<ResourceDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDefinitionVersionFactory, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1>(this CombinedResult<T1, ResourceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResourceDefinitionVersionFactory, T1, T2, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2>(this CombinedResult<ResourceDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDefinitionVersionFactory, T2, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2>(this CombinedResult<T1, ResourceDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDefinitionVersionFactory, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2>(this CombinedResult<T1, T2, ResourceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResourceDefinitionVersionFactory, T1, T2, T3, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2, T3>(this CombinedResult<ResourceDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDefinitionVersionFactory, T2, T3, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, ResourceDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDefinitionVersionFactory, T3, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, ResourceDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceDefinitionVersionFactory, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResourceDefinitionVersionFactory, T1, T2, T3, T4, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<ResourceDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDefinitionVersionFactory, T2, T3, T4, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, ResourceDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDefinitionVersionFactory, T3, T4, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceDefinitionVersionFactory, T4, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResourceDefinitionVersionFactory, InnerResourceDefinitionVersionResourceInstanceFactory> WithResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResources(combinedResult.T5, subFactoryAction));
}
