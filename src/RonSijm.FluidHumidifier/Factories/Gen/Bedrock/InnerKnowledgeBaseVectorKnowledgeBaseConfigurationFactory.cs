// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration>
{

    internal InnerKnowledgeBaseEmbeddingModelConfigurationFactory EmbeddingModelConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration Create()
    {
        var vectorKnowledgeBaseConfigurationResult = CreateVectorKnowledgeBaseConfiguration();
        factoryAction?.Invoke(vectorKnowledgeBaseConfigurationResult);

        return vectorKnowledgeBaseConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration CreateVectorKnowledgeBaseConfiguration()
    {
        var vectorKnowledgeBaseConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration();

        return vectorKnowledgeBaseConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration result)
    {
        base.CreateChildren(result);

        result.EmbeddingModelConfiguration ??= EmbeddingModelConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration(this InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null)
    {
        parentFactory.EmbeddingModelConfigurationFactory = new InnerKnowledgeBaseEmbeddingModelConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EmbeddingModelConfigurationFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T1, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1>(this CombinedResult<InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1>(this CombinedResult<T1, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T1, T2, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2>(this CombinedResult<InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T2, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T2, T3, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T3, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T3, T4, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T4, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseEmbeddingModelConfigurationFactory> WithEmbeddingModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmbeddingModelConfiguration(combinedResult.T5, subFactoryAction));
}
