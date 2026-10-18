// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessAfterInvocationHookFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterInvocationHook> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterInvocationHook>
{

    internal InnerHarnessHarnessHookTargetFactory TargetFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterInvocationHook Create()
    {
        var harnessAfterInvocationHookResult = CreateHarnessAfterInvocationHook();
        factoryAction?.Invoke(harnessAfterInvocationHookResult);

        return harnessAfterInvocationHookResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterInvocationHook CreateHarnessAfterInvocationHook()
    {
        var harnessAfterInvocationHookResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterInvocationHook();

        return harnessAfterInvocationHookResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessAfterInvocationHook result)
    {
        base.CreateChildren(result);

        result.Target ??= TargetFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessAfterInvocationHookFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessAfterInvocationHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget(this InnerHarnessHarnessAfterInvocationHookFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null)
    {
        parentFactory.TargetFactory = new InnerHarnessHarnessHookTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetFactory);
    }

    public static CombinedResult<InnerHarnessHarnessAfterInvocationHookFactory, T1, InnerHarnessHarnessHookTargetFactory> WithTarget<T1>(this CombinedResult<InnerHarnessHarnessAfterInvocationHookFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAfterInvocationHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1>(this CombinedResult<T1, InnerHarnessHarnessAfterInvocationHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessAfterInvocationHookFactory, T1, T2, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<InnerHarnessHarnessAfterInvocationHookFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAfterInvocationHookFactory, T2, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessAfterInvocationHookFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessAfterInvocationHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessAfterInvocationHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessAfterInvocationHookFactory, T1, T2, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessAfterInvocationHookFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAfterInvocationHookFactory, T2, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessAfterInvocationHookFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessAfterInvocationHookFactory, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessAfterInvocationHookFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessAfterInvocationHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessAfterInvocationHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessAfterInvocationHookFactory, T1, T2, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessAfterInvocationHookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessAfterInvocationHookFactory, T2, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessAfterInvocationHookFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessAfterInvocationHookFactory, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessAfterInvocationHookFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessAfterInvocationHookFactory, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessAfterInvocationHookFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessAfterInvocationHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessAfterInvocationHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T5, subFactoryAction).T2);
}
