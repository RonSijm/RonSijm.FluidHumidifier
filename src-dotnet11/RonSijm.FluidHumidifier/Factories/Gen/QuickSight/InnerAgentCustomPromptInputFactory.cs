// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAgentCustomPromptInputFactory(Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AgentTypes.CustomPromptInput>
{

    internal InnerAgentCustomPromptInputParametersFactory NewPromptFactory { get; set; }

    internal InnerAgentCustomPromptProfileFactory ExistingPromptFactory { get; set; }

    protected override Humidifier.QuickSight.AgentTypes.CustomPromptInput Create()
    {
        var customPromptInputResult = CreateCustomPromptInput();
        factoryAction?.Invoke(customPromptInputResult);

        return customPromptInputResult;
    }

    private Humidifier.QuickSight.AgentTypes.CustomPromptInput CreateCustomPromptInput()
    {
        var customPromptInputResult = new Humidifier.QuickSight.AgentTypes.CustomPromptInput();

        return customPromptInputResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AgentTypes.CustomPromptInput result)
    {
        base.CreateChildren(result);

        result.NewPrompt ??= NewPromptFactory?.Build();
        result.ExistingPrompt ??= ExistingPromptFactory?.Build();
    }

} // End Of Class

public static class InnerAgentCustomPromptInputFactoryExtensions
{
    public static CombinedResult<InnerAgentCustomPromptInputFactory, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt(this InnerAgentCustomPromptInputFactory parentFactory, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null)
    {
        parentFactory.NewPromptFactory = new InnerAgentCustomPromptInputParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NewPromptFactory);
    }

    public static CombinedResult<InnerAgentCustomPromptInputFactory, InnerAgentCustomPromptProfileFactory> WithExistingPrompt(this InnerAgentCustomPromptInputFactory parentFactory, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null)
    {
        parentFactory.ExistingPromptFactory = new InnerAgentCustomPromptProfileFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExistingPromptFactory);
    }

    public static CombinedResult<InnerAgentCustomPromptInputFactory, T1, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1>(this CombinedResult<InnerAgentCustomPromptInputFactory, T1> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithNewPrompt(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomPromptInputFactory, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1>(this CombinedResult<T1, InnerAgentCustomPromptInputFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithNewPrompt(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2>(this CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2>(this CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2>(this CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2, T3, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2, T3>(this CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2, T3, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2, T3>(this CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory, T3, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2, T3>(this CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAgentCustomPromptInputFactory, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAgentCustomPromptInputFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2, T3, T4, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2, T3, T4>(this CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2, T3, T4, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2, T3, T4>(this CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory, T3, T4, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAgentCustomPromptInputFactory, T4, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAgentCustomPromptInputFactory, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAgentCustomPromptInputFactory, InnerAgentCustomPromptInputParametersFactory> WithNewPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAgentCustomPromptInputFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNewPrompt(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerAgentCustomPromptInputFactory, T1, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1>(this CombinedResult<InnerAgentCustomPromptInputFactory, T1> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, WithExistingPrompt(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomPromptInputFactory, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1>(this CombinedResult<T1, InnerAgentCustomPromptInputFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, WithExistingPrompt(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2>(this CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2>(this CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2>(this CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2, T3, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2, T3>(this CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2, T3, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2, T3>(this CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory, T3, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2, T3>(this CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAgentCustomPromptInputFactory, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAgentCustomPromptInputFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2, T3, T4, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2, T3, T4>(this CombinedResult<InnerAgentCustomPromptInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2, T3, T4, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, InnerAgentCustomPromptInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory, T3, T4, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAgentCustomPromptInputFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAgentCustomPromptInputFactory, T4, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAgentCustomPromptInputFactory, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAgentCustomPromptInputFactory, InnerAgentCustomPromptProfileFactory> WithExistingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAgentCustomPromptInputFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExistingPrompt(combinedResult.T5, subFactoryAction).T2);
}
