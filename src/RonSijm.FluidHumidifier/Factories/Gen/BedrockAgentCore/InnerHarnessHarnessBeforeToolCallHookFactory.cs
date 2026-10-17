// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessBeforeToolCallHookFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeToolCallHook> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeToolCallHook>
{

    internal InnerHarnessHarnessHookTargetFactory TargetFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeToolCallHook Create()
    {
        var harnessBeforeToolCallHookResult = CreateHarnessBeforeToolCallHook();
        factoryAction?.Invoke(harnessBeforeToolCallHookResult);

        return harnessBeforeToolCallHookResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeToolCallHook CreateHarnessBeforeToolCallHook()
    {
        var harnessBeforeToolCallHookResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeToolCallHook();

        return harnessBeforeToolCallHookResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeToolCallHook result)
    {
        base.CreateChildren(result);

        result.Target ??= TargetFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessBeforeToolCallHookFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessBeforeToolCallHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget(this InnerHarnessHarnessBeforeToolCallHookFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null)
    {
        parentFactory.TargetFactory = new InnerHarnessHarnessHookTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetFactory);
    }

    public static CombinedResult<InnerHarnessHarnessBeforeToolCallHookFactory, T1, InnerHarnessHarnessHookTargetFactory> WithTarget<T1>(this CombinedResult<InnerHarnessHarnessBeforeToolCallHookFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessBeforeToolCallHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1>(this CombinedResult<T1, InnerHarnessHarnessBeforeToolCallHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessBeforeToolCallHookFactory, T1, T2, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<InnerHarnessHarnessBeforeToolCallHookFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessBeforeToolCallHookFactory, T2, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessBeforeToolCallHookFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessBeforeToolCallHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessBeforeToolCallHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessBeforeToolCallHookFactory, T1, T2, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessBeforeToolCallHookFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessBeforeToolCallHookFactory, T2, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessBeforeToolCallHookFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessBeforeToolCallHookFactory, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessBeforeToolCallHookFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessBeforeToolCallHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessBeforeToolCallHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessBeforeToolCallHookFactory, T1, T2, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessBeforeToolCallHookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessBeforeToolCallHookFactory, T2, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessBeforeToolCallHookFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessBeforeToolCallHookFactory, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessBeforeToolCallHookFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessBeforeToolCallHookFactory, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessBeforeToolCallHookFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessBeforeToolCallHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessBeforeToolCallHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T5, subFactoryAction).T2);
}
