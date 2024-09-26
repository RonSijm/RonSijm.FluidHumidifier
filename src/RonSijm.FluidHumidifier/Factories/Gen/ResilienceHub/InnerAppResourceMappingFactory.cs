// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHub;

public class InnerAppResourceMappingFactory(Action<Humidifier.ResilienceHub.AppTypes.ResourceMapping> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHub.AppTypes.ResourceMapping>
{

    internal InnerAppPhysicalResourceIdFactory PhysicalResourceIdFactory { get; set; }

    protected override Humidifier.ResilienceHub.AppTypes.ResourceMapping Create()
    {
        var resourceMappingResult = CreateResourceMapping();
        factoryAction?.Invoke(resourceMappingResult);

        return resourceMappingResult;
    }

    private Humidifier.ResilienceHub.AppTypes.ResourceMapping CreateResourceMapping()
    {
        var resourceMappingResult = new Humidifier.ResilienceHub.AppTypes.ResourceMapping();

        return resourceMappingResult;
    }
    public override void CreateChildren(Humidifier.ResilienceHub.AppTypes.ResourceMapping result)
    {
        base.CreateChildren(result);

        result.PhysicalResourceId ??= PhysicalResourceIdFactory?.Build();
    }

} // End Of Class

public static class InnerAppResourceMappingFactoryExtensions
{
    public static CombinedResult<InnerAppResourceMappingFactory, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId(this InnerAppResourceMappingFactory parentFactory, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null)
    {
        parentFactory.PhysicalResourceIdFactory = new InnerAppPhysicalResourceIdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PhysicalResourceIdFactory);
    }

    public static CombinedResult<InnerAppResourceMappingFactory, T1, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1>(this CombinedResult<InnerAppResourceMappingFactory, T1> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppResourceMappingFactory, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1>(this CombinedResult<T1, InnerAppResourceMappingFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAppResourceMappingFactory, T1, T2, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2>(this CombinedResult<InnerAppResourceMappingFactory, T1, T2> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppResourceMappingFactory, T2, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2>(this CombinedResult<T1, InnerAppResourceMappingFactory, T2> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppResourceMappingFactory, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2>(this CombinedResult<T1, T2, InnerAppResourceMappingFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAppResourceMappingFactory, T1, T2, T3, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2, T3>(this CombinedResult<InnerAppResourceMappingFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppResourceMappingFactory, T2, T3, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2, T3>(this CombinedResult<T1, InnerAppResourceMappingFactory, T2, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppResourceMappingFactory, T3, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppResourceMappingFactory, T3> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppResourceMappingFactory, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppResourceMappingFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAppResourceMappingFactory, T1, T2, T3, T4, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2, T3, T4>(this CombinedResult<InnerAppResourceMappingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppResourceMappingFactory, T2, T3, T4, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppResourceMappingFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppResourceMappingFactory, T3, T4, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppResourceMappingFactory, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppResourceMappingFactory, T4, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppResourceMappingFactory, T4> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAppResourceMappingFactory, InnerAppPhysicalResourceIdFactory> WithPhysicalResourceId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppResourceMappingFactory> combinedResult, Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPhysicalResourceId(combinedResult.T5, subFactoryAction));
}
