// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseEmbeddingModelConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration>
{

    internal InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory BedrockEmbeddingModelConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration Create()
    {
        var embeddingModelConfigurationResult = CreateEmbeddingModelConfiguration();
        factoryAction?.Invoke(embeddingModelConfigurationResult);

        return embeddingModelConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration CreateEmbeddingModelConfiguration()
    {
        var embeddingModelConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration();

        return embeddingModelConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration result)
    {
        base.CreateChildren(result);

        result.BedrockEmbeddingModelConfiguration ??= BedrockEmbeddingModelConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseEmbeddingModelConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseEmbeddingModelConfigurationFactory, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration(this InnerKnowledgeBaseEmbeddingModelConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null)
    {
        parentFactory.BedrockEmbeddingModelConfigurationFactory = new InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BedrockEmbeddingModelConfigurationFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T1, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1>(this CombinedResult<InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1>(this CombinedResult<T1, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T1, T2, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2>(this CombinedResult<InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T2, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T2, T3, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T3, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T3, T4, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T4, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseEmbeddingModelConfigurationFactory, InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory> WithBedrockEmbeddingModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockEmbeddingModelConfiguration(combinedResult.T5, subFactoryAction));
}
