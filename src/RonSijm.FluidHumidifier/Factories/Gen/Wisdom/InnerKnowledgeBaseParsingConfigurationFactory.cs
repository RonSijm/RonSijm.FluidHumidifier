// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseParsingConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingConfiguration>
{

    internal InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory BedrockFoundationModelConfigurationFactory { get; set; }

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.ParsingConfiguration Create()
    {
        var parsingConfigurationResult = CreateParsingConfiguration();
        factoryAction?.Invoke(parsingConfigurationResult);

        return parsingConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.ParsingConfiguration CreateParsingConfiguration()
    {
        var parsingConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.ParsingConfiguration();

        return parsingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.KnowledgeBaseTypes.ParsingConfiguration result)
    {
        base.CreateChildren(result);

        result.BedrockFoundationModelConfiguration ??= BedrockFoundationModelConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseParsingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseParsingConfigurationFactory, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration(this InnerKnowledgeBaseParsingConfigurationFactory parentFactory, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null)
    {
        parentFactory.BedrockFoundationModelConfigurationFactory = new InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BedrockFoundationModelConfigurationFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseParsingConfigurationFactory, T1, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1>(this CombinedResult<InnerKnowledgeBaseParsingConfigurationFactory, T1> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseParsingConfigurationFactory, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1>(this CombinedResult<T1, InnerKnowledgeBaseParsingConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseParsingConfigurationFactory, T1, T2, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2>(this CombinedResult<InnerKnowledgeBaseParsingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseParsingConfigurationFactory, T2, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseParsingConfigurationFactory, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseParsingConfigurationFactory, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseParsingConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseParsingConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseParsingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseParsingConfigurationFactory, T2, T3, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseParsingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseParsingConfigurationFactory, T3, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseParsingConfigurationFactory, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseParsingConfigurationFactory, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseParsingConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseParsingConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseParsingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseParsingConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseParsingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseParsingConfigurationFactory, T3, T4, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseParsingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseParsingConfigurationFactory, T4, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseParsingConfigurationFactory, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseParsingConfigurationFactory, InnerKnowledgeBaseBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseParsingConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T5, subFactoryAction));
}
