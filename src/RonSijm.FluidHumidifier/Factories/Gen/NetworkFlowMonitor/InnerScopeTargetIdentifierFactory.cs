// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFlowMonitor;

public class InnerScopeTargetIdentifierFactory(Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier>
{

    internal InnerScopeTargetIdFactory TargetIdFactory { get; set; }

    protected override Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier Create()
    {
        var targetIdentifierResult = CreateTargetIdentifier();
        factoryAction?.Invoke(targetIdentifierResult);

        return targetIdentifierResult;
    }

    private Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier CreateTargetIdentifier()
    {
        var targetIdentifierResult = new Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier();

        return targetIdentifierResult;
    }
    public override void CreateChildren(Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier result)
    {
        base.CreateChildren(result);

        result.TargetId ??= TargetIdFactory?.Build();
    }

} // End Of Class

public static class InnerScopeTargetIdentifierFactoryExtensions
{
    public static CombinedResult<InnerScopeTargetIdentifierFactory, InnerScopeTargetIdFactory> WithTargetId(this InnerScopeTargetIdentifierFactory parentFactory, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null)
    {
        parentFactory.TargetIdFactory = new InnerScopeTargetIdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetIdFactory);
    }

    public static CombinedResult<InnerScopeTargetIdentifierFactory, T1, InnerScopeTargetIdFactory> WithTargetId<T1>(this CombinedResult<InnerScopeTargetIdentifierFactory, T1> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetId(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScopeTargetIdentifierFactory, InnerScopeTargetIdFactory> WithTargetId<T1>(this CombinedResult<T1, InnerScopeTargetIdentifierFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetId(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerScopeTargetIdentifierFactory, T1, T2, InnerScopeTargetIdFactory> WithTargetId<T1, T2>(this CombinedResult<InnerScopeTargetIdentifierFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScopeTargetIdentifierFactory, T2, InnerScopeTargetIdFactory> WithTargetId<T1, T2>(this CombinedResult<T1, InnerScopeTargetIdentifierFactory, T2> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScopeTargetIdentifierFactory, InnerScopeTargetIdFactory> WithTargetId<T1, T2>(this CombinedResult<T1, T2, InnerScopeTargetIdentifierFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerScopeTargetIdentifierFactory, T1, T2, T3, InnerScopeTargetIdFactory> WithTargetId<T1, T2, T3>(this CombinedResult<InnerScopeTargetIdentifierFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScopeTargetIdentifierFactory, T2, T3, InnerScopeTargetIdFactory> WithTargetId<T1, T2, T3>(this CombinedResult<T1, InnerScopeTargetIdentifierFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScopeTargetIdentifierFactory, T3, InnerScopeTargetIdFactory> WithTargetId<T1, T2, T3>(this CombinedResult<T1, T2, InnerScopeTargetIdentifierFactory, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScopeTargetIdentifierFactory, InnerScopeTargetIdFactory> WithTargetId<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScopeTargetIdentifierFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerScopeTargetIdentifierFactory, T1, T2, T3, T4, InnerScopeTargetIdFactory> WithTargetId<T1, T2, T3, T4>(this CombinedResult<InnerScopeTargetIdentifierFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScopeTargetIdentifierFactory, T2, T3, T4, InnerScopeTargetIdFactory> WithTargetId<T1, T2, T3, T4>(this CombinedResult<T1, InnerScopeTargetIdentifierFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScopeTargetIdentifierFactory, T3, T4, InnerScopeTargetIdFactory> WithTargetId<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScopeTargetIdentifierFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScopeTargetIdentifierFactory, T4, InnerScopeTargetIdFactory> WithTargetId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScopeTargetIdentifierFactory, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerScopeTargetIdentifierFactory, InnerScopeTargetIdFactory> WithTargetId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScopeTargetIdentifierFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetId(combinedResult.T5, subFactoryAction).T2);
}
