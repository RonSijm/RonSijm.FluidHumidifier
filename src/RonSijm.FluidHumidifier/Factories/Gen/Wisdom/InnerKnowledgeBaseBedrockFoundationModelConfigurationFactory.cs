// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration>
{

    internal InnerKnowledgeBaseParsingPromptFactory ParsingPromptFactory { get; set; }

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration Create()
    {
        var bedrockFoundationModelConfigurationResult = CreateBedrockFoundationModelConfiguration();
        factoryAction?.Invoke(bedrockFoundationModelConfigurationResult);

        return bedrockFoundationModelConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration CreateBedrockFoundationModelConfiguration()
    {
        var bedrockFoundationModelConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration();

        return bedrockFoundationModelConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration result)
    {
        base.CreateChildren(result);

        result.ParsingPrompt ??= ParsingPromptFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseBedrockFoundationModelConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt(this InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory parentFactory, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null)
    {
        parentFactory.ParsingPromptFactory = new InnerKnowledgeBaseParsingPromptFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParsingPromptFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T1, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1>(this CombinedResult<InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T1> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, WithParsingPrompt(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1>(this CombinedResult<T1, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, WithParsingPrompt(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T1, T2, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2>(this CombinedResult<InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T2, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T2, T3, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T3, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T3, T4, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T4, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory, InnerKnowledgeBaseParsingPromptFactory> WithParsingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T5, subFactoryAction));
}
