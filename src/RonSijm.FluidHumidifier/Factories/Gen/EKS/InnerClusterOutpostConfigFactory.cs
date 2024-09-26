// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterOutpostConfigFactory(Action<Humidifier.EKS.ClusterTypes.OutpostConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.OutpostConfig>
{

    internal InnerClusterControlPlanePlacementFactory ControlPlanePlacementFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.OutpostConfig Create()
    {
        var outpostConfigResult = CreateOutpostConfig();
        factoryAction?.Invoke(outpostConfigResult);

        return outpostConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.OutpostConfig CreateOutpostConfig()
    {
        var outpostConfigResult = new Humidifier.EKS.ClusterTypes.OutpostConfig();

        return outpostConfigResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.OutpostConfig result)
    {
        base.CreateChildren(result);

        result.ControlPlanePlacement ??= ControlPlanePlacementFactory?.Build();
    }

} // End Of Class

public static class InnerClusterOutpostConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterOutpostConfigFactory, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement(this InnerClusterOutpostConfigFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null)
    {
        parentFactory.ControlPlanePlacementFactory = new InnerClusterControlPlanePlacementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ControlPlanePlacementFactory);
    }

    public static CombinedResult<InnerClusterOutpostConfigFactory, T1, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1>(this CombinedResult<InnerClusterOutpostConfigFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOutpostConfigFactory, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1>(this CombinedResult<T1, InnerClusterOutpostConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterOutpostConfigFactory, T1, T2, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2>(this CombinedResult<InnerClusterOutpostConfigFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOutpostConfigFactory, T2, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2>(this CombinedResult<T1, InnerClusterOutpostConfigFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOutpostConfigFactory, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2>(this CombinedResult<T1, T2, InnerClusterOutpostConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterOutpostConfigFactory, T1, T2, T3, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2, T3>(this CombinedResult<InnerClusterOutpostConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOutpostConfigFactory, T2, T3, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2, T3>(this CombinedResult<T1, InnerClusterOutpostConfigFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOutpostConfigFactory, T3, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterOutpostConfigFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterOutpostConfigFactory, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterOutpostConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterOutpostConfigFactory, T1, T2, T3, T4, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2, T3, T4>(this CombinedResult<InnerClusterOutpostConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOutpostConfigFactory, T2, T3, T4, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterOutpostConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOutpostConfigFactory, T3, T4, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterOutpostConfigFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterOutpostConfigFactory, T4, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterOutpostConfigFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterOutpostConfigFactory, InnerClusterControlPlanePlacementFactory> WithControlPlanePlacement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterOutpostConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ControlPlanePlacement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlPlanePlacement(combinedResult.T5, subFactoryAction));
}
