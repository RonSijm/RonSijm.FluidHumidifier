// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptToolChoiceFactory(Action<Humidifier.Bedrock.PromptTypes.ToolChoice> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.ToolChoice>
{

    internal InnerPromptSpecificToolChoiceFactory ToolFactory { get; set; }

    protected override Humidifier.Bedrock.PromptTypes.ToolChoice Create()
    {
        var toolChoiceResult = CreateToolChoice();
        factoryAction?.Invoke(toolChoiceResult);

        return toolChoiceResult;
    }

    private Humidifier.Bedrock.PromptTypes.ToolChoice CreateToolChoice()
    {
        var toolChoiceResult = new Humidifier.Bedrock.PromptTypes.ToolChoice();

        return toolChoiceResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.PromptTypes.ToolChoice result)
    {
        base.CreateChildren(result);

        result.Tool ??= ToolFactory?.Build();
    }

} // End Of Class

public static class InnerPromptToolChoiceFactoryExtensions
{
    public static CombinedResult<InnerPromptToolChoiceFactory, InnerPromptSpecificToolChoiceFactory> WithTool(this InnerPromptToolChoiceFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null)
    {
        parentFactory.ToolFactory = new InnerPromptSpecificToolChoiceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ToolFactory);
    }

    public static CombinedResult<InnerPromptToolChoiceFactory, T1, InnerPromptSpecificToolChoiceFactory> WithTool<T1>(this CombinedResult<InnerPromptToolChoiceFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, WithTool(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptToolChoiceFactory, InnerPromptSpecificToolChoiceFactory> WithTool<T1>(this CombinedResult<T1, InnerPromptToolChoiceFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, WithTool(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPromptToolChoiceFactory, T1, T2, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2>(this CombinedResult<InnerPromptToolChoiceFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptToolChoiceFactory, T2, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2>(this CombinedResult<T1, InnerPromptToolChoiceFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptToolChoiceFactory, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2>(this CombinedResult<T1, T2, InnerPromptToolChoiceFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPromptToolChoiceFactory, T1, T2, T3, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2, T3>(this CombinedResult<InnerPromptToolChoiceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptToolChoiceFactory, T2, T3, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2, T3>(this CombinedResult<T1, InnerPromptToolChoiceFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptToolChoiceFactory, T3, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2, T3>(this CombinedResult<T1, T2, InnerPromptToolChoiceFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptToolChoiceFactory, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPromptToolChoiceFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPromptToolChoiceFactory, T1, T2, T3, T4, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2, T3, T4>(this CombinedResult<InnerPromptToolChoiceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptToolChoiceFactory, T2, T3, T4, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2, T3, T4>(this CombinedResult<T1, InnerPromptToolChoiceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptToolChoiceFactory, T3, T4, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPromptToolChoiceFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptToolChoiceFactory, T4, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPromptToolChoiceFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPromptToolChoiceFactory, InnerPromptSpecificToolChoiceFactory> WithTool<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPromptToolChoiceFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.SpecificToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTool(combinedResult.T5, subFactoryAction));
}
