// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessAfterToolCallHookFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterToolCallHook> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterToolCallHook>
{

    internal InnerHarnessHarnessHookTargetFactory TargetFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterToolCallHook Create()
    {
        var harnessAfterToolCallHookResult = CreateHarnessAfterToolCallHook();
        factoryAction?.Invoke(harnessAfterToolCallHookResult);

        return harnessAfterToolCallHookResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterToolCallHook CreateHarnessAfterToolCallHook()
    {
        var harnessAfterToolCallHookResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterToolCallHook();

        return harnessAfterToolCallHookResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterToolCallHook result)
    {
        base.CreateChildren(result);

        result.Target ??= TargetFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessAfterToolCallHookFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessAfterToolCallHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget(this InnerHarnessHarnessAfterToolCallHookFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null)
    {
        parentFactory.TargetFactory = new InnerHarnessHarnessHookTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetFactory);
    }

    public static CombinedResult<InnerHarnessHarnessAfterToolCallHookFactory, T1, InnerHarnessHarnessHookTargetFactory> WithTarget<T1>(this CombinedResult<InnerHarnessHarnessAfterToolCallHookFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAfterToolCallHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1>(this CombinedResult<T1, InnerHarnessHarnessAfterToolCallHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessAfterToolCallHookFactory, T1, T2, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<InnerHarnessHarnessAfterToolCallHookFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAfterToolCallHookFactory, T2, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessAfterToolCallHookFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessAfterToolCallHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessAfterToolCallHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessAfterToolCallHookFactory, T1, T2, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessAfterToolCallHookFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAfterToolCallHookFactory, T2, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessAfterToolCallHookFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessAfterToolCallHookFactory, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessAfterToolCallHookFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessAfterToolCallHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessAfterToolCallHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessAfterToolCallHookFactory, T1, T2, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessAfterToolCallHookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAfterToolCallHookFactory, T2, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessAfterToolCallHookFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessAfterToolCallHookFactory, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessAfterToolCallHookFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessAfterToolCallHookFactory, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessAfterToolCallHookFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessAfterToolCallHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessAfterToolCallHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T5, subFactoryAction).T2);
}
