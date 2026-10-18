// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessBeforeInvocationHookFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeInvocationHook> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeInvocationHook>
{

    internal InnerHarnessHarnessHookTargetFactory TargetFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeInvocationHook Create()
    {
        var harnessBeforeInvocationHookResult = CreateHarnessBeforeInvocationHook();
        factoryAction?.Invoke(harnessBeforeInvocationHookResult);

        return harnessBeforeInvocationHookResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeInvocationHook CreateHarnessBeforeInvocationHook()
    {
        var harnessBeforeInvocationHookResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeInvocationHook();

        return harnessBeforeInvocationHookResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessBeforeInvocationHook result)
    {
        base.CreateChildren(result);

        result.Target ??= TargetFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessBeforeInvocationHookFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessBeforeInvocationHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget(this InnerHarnessHarnessBeforeInvocationHookFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null)
    {
        parentFactory.TargetFactory = new InnerHarnessHarnessHookTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetFactory);
    }

    public static CombinedResult<InnerHarnessHarnessBeforeInvocationHookFactory, T1, InnerHarnessHarnessHookTargetFactory> WithTarget<T1>(this CombinedResult<InnerHarnessHarnessBeforeInvocationHookFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessBeforeInvocationHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1>(this CombinedResult<T1, InnerHarnessHarnessBeforeInvocationHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessBeforeInvocationHookFactory, T1, T2, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<InnerHarnessHarnessBeforeInvocationHookFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessBeforeInvocationHookFactory, T2, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessBeforeInvocationHookFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessBeforeInvocationHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessBeforeInvocationHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessBeforeInvocationHookFactory, T1, T2, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessBeforeInvocationHookFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessBeforeInvocationHookFactory, T2, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessBeforeInvocationHookFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessBeforeInvocationHookFactory, T3, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessBeforeInvocationHookFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessBeforeInvocationHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessBeforeInvocationHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessBeforeInvocationHookFactory, T1, T2, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessBeforeInvocationHookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessBeforeInvocationHookFactory, T2, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessBeforeInvocationHookFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessBeforeInvocationHookFactory, T3, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessBeforeInvocationHookFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessBeforeInvocationHookFactory, T4, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessBeforeInvocationHookFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessBeforeInvocationHookFactory, InnerHarnessHarnessHookTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessBeforeInvocationHookFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T5, subFactoryAction).T2);
}
