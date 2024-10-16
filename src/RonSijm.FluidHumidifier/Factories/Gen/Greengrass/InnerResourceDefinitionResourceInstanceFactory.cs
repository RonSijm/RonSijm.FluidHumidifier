// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerResourceDefinitionResourceInstanceFactory(Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance>
{

    internal InnerResourceDefinitionResourceDataContainerFactory ResourceDataContainerFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance Create()
    {
        var resourceInstanceResult = CreateResourceInstance();
        factoryAction?.Invoke(resourceInstanceResult);

        return resourceInstanceResult;
    }

    private Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance CreateResourceInstance()
    {
        var resourceInstanceResult = new Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance();

        return resourceInstanceResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance result)
    {
        base.CreateChildren(result);

        result.ResourceDataContainer ??= ResourceDataContainerFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDefinitionResourceInstanceFactoryExtensions
{
    public static CombinedResult<InnerResourceDefinitionResourceInstanceFactory, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer(this InnerResourceDefinitionResourceInstanceFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null)
    {
        parentFactory.ResourceDataContainerFactory = new InnerResourceDefinitionResourceDataContainerFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceDataContainerFactory);
    }

    public static CombinedResult<InnerResourceDefinitionResourceInstanceFactory, T1, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1>(this CombinedResult<InnerResourceDefinitionResourceInstanceFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionResourceInstanceFactory, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1>(this CombinedResult<T1, InnerResourceDefinitionResourceInstanceFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionResourceInstanceFactory, T1, T2, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2>(this CombinedResult<InnerResourceDefinitionResourceInstanceFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionResourceInstanceFactory, T2, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2>(this CombinedResult<T1, InnerResourceDefinitionResourceInstanceFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionResourceInstanceFactory, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2>(this CombinedResult<T1, T2, InnerResourceDefinitionResourceInstanceFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionResourceInstanceFactory, T1, T2, T3, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3>(this CombinedResult<InnerResourceDefinitionResourceInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionResourceInstanceFactory, T2, T3, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3>(this CombinedResult<T1, InnerResourceDefinitionResourceInstanceFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionResourceInstanceFactory, T3, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDefinitionResourceInstanceFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionResourceInstanceFactory, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionResourceInstanceFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDefinitionResourceInstanceFactory, T1, T2, T3, T4, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3, T4>(this CombinedResult<InnerResourceDefinitionResourceInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDefinitionResourceInstanceFactory, T2, T3, T4, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDefinitionResourceInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDefinitionResourceInstanceFactory, T3, T4, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDefinitionResourceInstanceFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDefinitionResourceInstanceFactory, T4, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDefinitionResourceInstanceFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionResourceInstanceFactory, InnerResourceDefinitionResourceDataContainerFactory> WithResourceDataContainer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDefinitionResourceInstanceFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceDataContainer(combinedResult.T5, subFactoryAction));
}
