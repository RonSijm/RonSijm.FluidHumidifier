// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerLifecyclePolicyActionFactory(Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.LifecyclePolicyTypes.Action>
{

    internal InnerLifecyclePolicyIncludeResourcesFactory IncludeResourcesFactory { get; set; }

    protected override Humidifier.ImageBuilder.LifecyclePolicyTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.ImageBuilder.LifecyclePolicyTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.ImageBuilder.LifecyclePolicyTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.LifecyclePolicyTypes.Action result)
    {
        base.CreateChildren(result);

        result.IncludeResources ??= IncludeResourcesFactory?.Build();
    }

} // End Of Class

public static class InnerLifecyclePolicyActionFactoryExtensions
{
    public static CombinedResult<InnerLifecyclePolicyActionFactory, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources(this InnerLifecyclePolicyActionFactory parentFactory, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null)
    {
        parentFactory.IncludeResourcesFactory = new InnerLifecyclePolicyIncludeResourcesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IncludeResourcesFactory);
    }

    public static CombinedResult<InnerLifecyclePolicyActionFactory, T1, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1>(this CombinedResult<InnerLifecyclePolicyActionFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncludeResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyActionFactory, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1>(this CombinedResult<T1, InnerLifecyclePolicyActionFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncludeResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyActionFactory, T1, T2, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2>(this CombinedResult<InnerLifecyclePolicyActionFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyActionFactory, T2, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2>(this CombinedResult<T1, InnerLifecyclePolicyActionFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyActionFactory, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2>(this CombinedResult<T1, T2, InnerLifecyclePolicyActionFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyActionFactory, T1, T2, T3, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2, T3>(this CombinedResult<InnerLifecyclePolicyActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyActionFactory, T2, T3, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2, T3>(this CombinedResult<T1, InnerLifecyclePolicyActionFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyActionFactory, T3, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2, T3>(this CombinedResult<T1, T2, InnerLifecyclePolicyActionFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyActionFactory, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyActionFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyActionFactory, T1, T2, T3, T4, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2, T3, T4>(this CombinedResult<InnerLifecyclePolicyActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyActionFactory, T2, T3, T4, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2, T3, T4>(this CombinedResult<T1, InnerLifecyclePolicyActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyActionFactory, T3, T4, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLifecyclePolicyActionFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyActionFactory, T4, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyActionFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyActionFactory, InnerLifecyclePolicyIncludeResourcesFactory> WithIncludeResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyActionFactory> combinedResult, Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeResources(combinedResult.T5, subFactoryAction));
}
