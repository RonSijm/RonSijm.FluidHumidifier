// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptToolConfigurationFactory(Action<Humidifier.Bedrock.PromptTypes.ToolConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.ToolConfiguration>
{

    internal InnerPromptToolChoiceFactory ToolChoiceFactory { get; set; }

    protected override Humidifier.Bedrock.PromptTypes.ToolConfiguration Create()
    {
        var toolConfigurationResult = CreateToolConfiguration();
        factoryAction?.Invoke(toolConfigurationResult);

        return toolConfigurationResult;
    }

    private Humidifier.Bedrock.PromptTypes.ToolConfiguration CreateToolConfiguration()
    {
        var toolConfigurationResult = new Humidifier.Bedrock.PromptTypes.ToolConfiguration();

        return toolConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.PromptTypes.ToolConfiguration result)
    {
        base.CreateChildren(result);

        result.ToolChoice ??= ToolChoiceFactory?.Build();
    }

} // End Of Class

public static class InnerPromptToolConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPromptToolConfigurationFactory, InnerPromptToolChoiceFactory> WithToolChoice(this InnerPromptToolConfigurationFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null)
    {
        parentFactory.ToolChoiceFactory = new InnerPromptToolChoiceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ToolChoiceFactory);
    }

    public static CombinedResult<InnerPromptToolConfigurationFactory, T1, InnerPromptToolChoiceFactory> WithToolChoice<T1>(this CombinedResult<InnerPromptToolConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, WithToolChoice(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptToolConfigurationFactory, InnerPromptToolChoiceFactory> WithToolChoice<T1>(this CombinedResult<T1, InnerPromptToolConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, WithToolChoice(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPromptToolConfigurationFactory, T1, T2, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2>(this CombinedResult<InnerPromptToolConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptToolConfigurationFactory, T2, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2>(this CombinedResult<T1, InnerPromptToolConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptToolConfigurationFactory, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2>(this CombinedResult<T1, T2, InnerPromptToolConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPromptToolConfigurationFactory, T1, T2, T3, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2, T3>(this CombinedResult<InnerPromptToolConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptToolConfigurationFactory, T2, T3, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2, T3>(this CombinedResult<T1, InnerPromptToolConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptToolConfigurationFactory, T3, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2, T3>(this CombinedResult<T1, T2, InnerPromptToolConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptToolConfigurationFactory, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPromptToolConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPromptToolConfigurationFactory, T1, T2, T3, T4, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2, T3, T4>(this CombinedResult<InnerPromptToolConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptToolConfigurationFactory, T2, T3, T4, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2, T3, T4>(this CombinedResult<T1, InnerPromptToolConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptToolConfigurationFactory, T3, T4, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPromptToolConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptToolConfigurationFactory, T4, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPromptToolConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPromptToolConfigurationFactory, InnerPromptToolChoiceFactory> WithToolChoice<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPromptToolConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.ToolChoice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithToolChoice(combinedResult.T5, subFactoryAction));
}
