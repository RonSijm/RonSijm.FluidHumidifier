// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class TargetGroupFactory(string resourceName = null, Action<Humidifier.VpcLattice.TargetGroup> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.TargetGroup>(resourceName)
{

    internal List<InnerTargetGroupTargetFactory> TargetsFactories { get; set; } = [];

    internal InnerTargetGroupTargetGroupConfigFactory ConfigFactory { get; set; }

    protected override Humidifier.VpcLattice.TargetGroup Create()
    {
        var targetGroupResult = CreateTargetGroup();
        factoryAction?.Invoke(targetGroupResult);

        return targetGroupResult;
    }

    private Humidifier.VpcLattice.TargetGroup CreateTargetGroup()
    {
        var targetGroupResult = new Humidifier.VpcLattice.TargetGroup
        {
            GivenName = InputResourceName,
        };

        return targetGroupResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.TargetGroup result)
    {
        base.CreateChildren(result);

        result.Targets = TargetsFactories.Any() ? TargetsFactories.Select(x => x.Build()).ToList() : null;
        result.Config ??= ConfigFactory?.Build();
    }

} // End Of Class

public static class TargetGroupFactoryExtensions
{
    public static CombinedResult<TargetGroupFactory, InnerTargetGroupTargetFactory> WithTargets(this TargetGroupFactory parentFactory, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null)
    {
        var factory = new InnerTargetGroupTargetFactory(subFactoryAction);
        parentFactory.TargetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TargetGroupFactory, InnerTargetGroupTargetGroupConfigFactory> WithConfig(this TargetGroupFactory parentFactory, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null)
    {
        parentFactory.ConfigFactory = new InnerTargetGroupTargetGroupConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigFactory);
    }

    public static CombinedResult<TargetGroupFactory, T1, InnerTargetGroupTargetFactory> WithTargets<T1>(this CombinedResult<TargetGroupFactory, T1> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, InnerTargetGroupTargetFactory> WithTargets<T1>(this CombinedResult<T1, TargetGroupFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, InnerTargetGroupTargetFactory> WithTargets<T1, T2>(this CombinedResult<TargetGroupFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, InnerTargetGroupTargetFactory> WithTargets<T1, T2>(this CombinedResult<T1, TargetGroupFactory, T2> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, InnerTargetGroupTargetFactory> WithTargets<T1, T2>(this CombinedResult<T1, T2, TargetGroupFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, T3, InnerTargetGroupTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<TargetGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, T3, InnerTargetGroupTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, TargetGroupFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, T3, InnerTargetGroupTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, TargetGroupFactory, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TargetGroupFactory, InnerTargetGroupTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, TargetGroupFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, T3, T4, InnerTargetGroupTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<TargetGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, T3, T4, InnerTargetGroupTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, TargetGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, T3, T4, InnerTargetGroupTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, TargetGroupFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TargetGroupFactory, T4, InnerTargetGroupTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TargetGroupFactory, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TargetGroupFactory, InnerTargetGroupTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TargetGroupFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1>(this CombinedResult<TargetGroupFactory, T1> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1>(this CombinedResult<T1, TargetGroupFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2>(this CombinedResult<TargetGroupFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2>(this CombinedResult<T1, TargetGroupFactory, T2> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2>(this CombinedResult<T1, T2, TargetGroupFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, T3, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<TargetGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, T3, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, TargetGroupFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, T3, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, T2, TargetGroupFactory, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TargetGroupFactory, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, TargetGroupFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TargetGroupFactory, T1, T2, T3, T4, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<TargetGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TargetGroupFactory, T2, T3, T4, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, TargetGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TargetGroupFactory, T3, T4, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, TargetGroupFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TargetGroupFactory, T4, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TargetGroupFactory, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TargetGroupFactory, InnerTargetGroupTargetGroupConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TargetGroupFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T5, subFactoryAction));
}
