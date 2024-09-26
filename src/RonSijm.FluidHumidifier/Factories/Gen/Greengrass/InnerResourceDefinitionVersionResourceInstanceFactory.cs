// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionVersionResourceInstanceFactory(Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance>
{

    internal InnerResourceDefinitionVersionResourceDataContainerFactory ResourceDataContainerFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance Create()
    {
        var resourceInstanceResult = CreateResourceInstance();
        factoryAction?.Invoke(resourceInstanceResult);

        return resourceInstanceResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance CreateResourceInstance()
    {
        var resourceInstanceResult = new Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance();

        return resourceInstanceResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance result)
    {
        base.CreateChildren(result);

        result.ResourceDataContainer ??= ResourceDataContainerFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDefinitionVersionResourceInstanceFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionVersionResourceInstanceFactory, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer(this InnerResourceDefinitionVersionResourceInstanceFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null)
    {
        parentFactory.ResourceDataContainerFactory = new InnerResourceDefinitionVersionResourceDataContainerFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceDataContainerFactory);
    }

    public static CombinedResult<InnerResourceDefinitionVersionResourceInstanceFactory, T1, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1>(this CombinedResult<InnerResourceDefinitionVersionResourceInstanceFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionResourceInstanceFactory, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1>(this CombinedResult<T1, InnerResourceDefinitionVersionResourceInstanceFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionResourceInstanceFactory, T1, T2, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2>(this CombinedResult<InnerResourceDefinitionVersionResourceInstanceFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionResourceInstanceFactory, T2, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionVersionResourceInstanceFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionResourceInstanceFactory, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionResourceInstanceFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionResourceInstanceFactory, T1, T2, T3, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionVersionResourceInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionResourceInstanceFactory, T2, T3, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionVersionResourceInstanceFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionResourceInstanceFactory, T3, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionResourceInstanceFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionResourceInstanceFactory, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionResourceInstanceFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionVersionResourceInstanceFactory, T1, T2, T3, T4, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionVersionResourceInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionVersionResourceInstanceFactory, T2, T3, T4, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionVersionResourceInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionVersionResourceInstanceFactory, T3, T4, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionVersionResourceInstanceFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionResourceInstanceFactory, T4, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionVersionResourceInstanceFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionVersionResourceInstanceFactory, InnerResourceDefinitionVersionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionVersionResourceInstanceFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T5, subFactoryAction));
}
