// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFlowMonitor;

public class InnerScopeTargetResourceFactory(Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource>
{

    internal InnerScopeTargetIdentifierFactory TargetIdentifierFactory { get; set; }

    protected override Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource Create()
    {
        var targetResourceResult = CreateTargetResource();
        factoryAction?.Invoke(targetResourceResult);

        return targetResourceResult;
    }

    private Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource CreateTargetResource()
    {
        var targetResourceResult = new Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource();

        return targetResourceResult;
    }
    public override void CreateChildren(Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource result)
    {
        base.CreateChildren(result);

        result.TargetIdentifier ??= TargetIdentifierFactory?.Build();
    }

} // End Of Class

public static class InnerScopeTargetResourceFactoryExtensions
{
    public static CombinedResult<InnerScopeTargetResourceFactory, InnerScopeTargetIdentifierFactory> WithTargetIdentifier(this InnerScopeTargetResourceFactory parentFactory, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null)
    {
        parentFactory.TargetIdentifierFactory = new InnerScopeTargetIdentifierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetIdentifierFactory);
    }

    public static CombinedResult<InnerScopeTargetResourceFactory, T1, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1>(this CombinedResult<InnerScopeTargetResourceFactory, T1> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScopeTargetResourceFactory, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1>(this CombinedResult<T1, InnerScopeTargetResourceFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerScopeTargetResourceFactory, T1, T2, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2>(this CombinedResult<InnerScopeTargetResourceFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScopeTargetResourceFactory, T2, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2>(this CombinedResult<T1, InnerScopeTargetResourceFactory, T2> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScopeTargetResourceFactory, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2>(this CombinedResult<T1, T2, InnerScopeTargetResourceFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerScopeTargetResourceFactory, T1, T2, T3, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2, T3>(this CombinedResult<InnerScopeTargetResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScopeTargetResourceFactory, T2, T3, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2, T3>(this CombinedResult<T1, InnerScopeTargetResourceFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScopeTargetResourceFactory, T3, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2, T3>(this CombinedResult<T1, T2, InnerScopeTargetResourceFactory, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScopeTargetResourceFactory, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScopeTargetResourceFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerScopeTargetResourceFactory, T1, T2, T3, T4, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2, T3, T4>(this CombinedResult<InnerScopeTargetResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScopeTargetResourceFactory, T2, T3, T4, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2, T3, T4>(this CombinedResult<T1, InnerScopeTargetResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScopeTargetResourceFactory, T3, T4, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScopeTargetResourceFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScopeTargetResourceFactory, T4, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScopeTargetResourceFactory, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerScopeTargetResourceFactory, InnerScopeTargetIdentifierFactory> WithTargetIdentifier<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScopeTargetResourceFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetIdentifier(combinedResult.T5, subFactoryAction).T2);
}
