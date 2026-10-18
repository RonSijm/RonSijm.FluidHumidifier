// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerComputeNodeGroupNodeLifecycleActionsFactory(Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleActions> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleActions>
{

    internal InnerComputeNodeGroupNodeLifecycleStagesFactory StagesFactory { get; set; }

    protected override Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleActions Create()
    {
        var nodeLifecycleActionsResult = CreateNodeLifecycleActions();
        factoryAction?.Invoke(nodeLifecycleActionsResult);

        return nodeLifecycleActionsResult;
    }

    private Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleActions CreateNodeLifecycleActions()
    {
        var nodeLifecycleActionsResult = new Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleActions();

        return nodeLifecycleActionsResult;
    }
    public override void CreateChildren(Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleActions result)
    {
        base.CreateChildren(result);

        result.Stages ??= StagesFactory?.Build();
    }

} // End Of Class

public static class InnerComputeNodeGroupNodeLifecycleActionsFactoryExtensions
{
    public static CombinedResult<InnerComputeNodeGroupNodeLifecycleActionsFactory, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages(this InnerComputeNodeGroupNodeLifecycleActionsFactory parentFactory, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null)
    {
        parentFactory.StagesFactory = new InnerComputeNodeGroupNodeLifecycleStagesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StagesFactory);
    }

    public static CombinedResult<InnerComputeNodeGroupNodeLifecycleActionsFactory, T1, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1>(this CombinedResult<InnerComputeNodeGroupNodeLifecycleActionsFactory, T1> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, WithStages(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeNodeGroupNodeLifecycleActionsFactory, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1>(this CombinedResult<T1, InnerComputeNodeGroupNodeLifecycleActionsFactory> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, WithStages(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerComputeNodeGroupNodeLifecycleActionsFactory, T1, T2, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2>(this CombinedResult<InnerComputeNodeGroupNodeLifecycleActionsFactory, T1, T2> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeNodeGroupNodeLifecycleActionsFactory, T2, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2>(this CombinedResult<T1, InnerComputeNodeGroupNodeLifecycleActionsFactory, T2> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputeNodeGroupNodeLifecycleActionsFactory, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2>(this CombinedResult<T1, T2, InnerComputeNodeGroupNodeLifecycleActionsFactory> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerComputeNodeGroupNodeLifecycleActionsFactory, T1, T2, T3, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2, T3>(this CombinedResult<InnerComputeNodeGroupNodeLifecycleActionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeNodeGroupNodeLifecycleActionsFactory, T2, T3, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2, T3>(this CombinedResult<T1, InnerComputeNodeGroupNodeLifecycleActionsFactory, T2, T3> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputeNodeGroupNodeLifecycleActionsFactory, T3, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2, T3>(this CombinedResult<T1, T2, InnerComputeNodeGroupNodeLifecycleActionsFactory, T3> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerComputeNodeGroupNodeLifecycleActionsFactory, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerComputeNodeGroupNodeLifecycleActionsFactory> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerComputeNodeGroupNodeLifecycleActionsFactory, T1, T2, T3, T4, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2, T3, T4>(this CombinedResult<InnerComputeNodeGroupNodeLifecycleActionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerComputeNodeGroupNodeLifecycleActionsFactory, T2, T3, T4, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2, T3, T4>(this CombinedResult<T1, InnerComputeNodeGroupNodeLifecycleActionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerComputeNodeGroupNodeLifecycleActionsFactory, T3, T4, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerComputeNodeGroupNodeLifecycleActionsFactory, T3, T4> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerComputeNodeGroupNodeLifecycleActionsFactory, T4, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerComputeNodeGroupNodeLifecycleActionsFactory, T4> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerComputeNodeGroupNodeLifecycleActionsFactory, InnerComputeNodeGroupNodeLifecycleStagesFactory> WithStages<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerComputeNodeGroupNodeLifecycleActionsFactory> combinedResult, Action<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStages(combinedResult.T5, subFactoryAction).T2);
}
