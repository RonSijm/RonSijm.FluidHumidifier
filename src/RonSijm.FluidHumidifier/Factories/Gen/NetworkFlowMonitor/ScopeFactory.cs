// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFlowMonitor;

public class ScopeFactory(string resourceName = null, Action<Humidifier.NetworkFlowMonitor.Scope> factoryAction = null) : ResourceFactory<Humidifier.NetworkFlowMonitor.Scope>(resourceName)
{

    internal List<InnerScopeTargetResourceFactory> TargetsFactories { get; set; } = [];

    protected override Humidifier.NetworkFlowMonitor.Scope Create()
    {
        var scopeResult = CreateScope();
        factoryAction?.Invoke(scopeResult);

        return scopeResult;
    }

    private Humidifier.NetworkFlowMonitor.Scope CreateScope()
    {
        var scopeResult = new Humidifier.NetworkFlowMonitor.Scope
        {
            GivenName = InputResourceName,
        };

        return scopeResult;
    }
    public override void CreateChildren(Humidifier.NetworkFlowMonitor.Scope result)
    {
        base.CreateChildren(result);

        result.Targets = TargetsFactories.Any() ? TargetsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ScopeFactoryExtensions
{
    public static CombinedResult<ScopeFactory, InnerScopeTargetResourceFactory> WithTargets(this ScopeFactory parentFactory, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null)
    {
        var factory = new InnerScopeTargetResourceFactory(subFactoryAction);
        parentFactory.TargetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ScopeFactory, T1, InnerScopeTargetResourceFactory> WithTargets<T1>(this CombinedResult<ScopeFactory, T1> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScopeFactory, InnerScopeTargetResourceFactory> WithTargets<T1>(this CombinedResult<T1, ScopeFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ScopeFactory, T1, T2, InnerScopeTargetResourceFactory> WithTargets<T1, T2>(this CombinedResult<ScopeFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScopeFactory, T2, InnerScopeTargetResourceFactory> WithTargets<T1, T2>(this CombinedResult<T1, ScopeFactory, T2> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScopeFactory, InnerScopeTargetResourceFactory> WithTargets<T1, T2>(this CombinedResult<T1, T2, ScopeFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ScopeFactory, T1, T2, T3, InnerScopeTargetResourceFactory> WithTargets<T1, T2, T3>(this CombinedResult<ScopeFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScopeFactory, T2, T3, InnerScopeTargetResourceFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, ScopeFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScopeFactory, T3, InnerScopeTargetResourceFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, ScopeFactory, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ScopeFactory, InnerScopeTargetResourceFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScopeFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ScopeFactory, T1, T2, T3, T4, InnerScopeTargetResourceFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<ScopeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScopeFactory, T2, T3, T4, InnerScopeTargetResourceFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, ScopeFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScopeFactory, T3, T4, InnerScopeTargetResourceFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScopeFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ScopeFactory, T4, InnerScopeTargetResourceFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScopeFactory, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ScopeFactory, InnerScopeTargetResourceFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScopeFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T5, subFactoryAction).T2);
}
