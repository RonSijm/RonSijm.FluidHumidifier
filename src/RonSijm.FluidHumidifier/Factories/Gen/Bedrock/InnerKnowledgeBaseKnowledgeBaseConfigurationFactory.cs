// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseKnowledgeBaseConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration>
{

    internal InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory VectorKnowledgeBaseConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration Create()
    {
        var knowledgeBaseConfigurationResult = CreateKnowledgeBaseConfiguration();
        factoryAction?.Invoke(knowledgeBaseConfigurationResult);

        return knowledgeBaseConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration CreateKnowledgeBaseConfiguration()
    {
        var knowledgeBaseConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration();

        return knowledgeBaseConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration result)
    {
        base.CreateChildren(result);

        result.VectorKnowledgeBaseConfiguration ??= VectorKnowledgeBaseConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseKnowledgeBaseConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration(this InnerKnowledgeBaseKnowledgeBaseConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null)
    {
        parentFactory.VectorKnowledgeBaseConfigurationFactory = new InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VectorKnowledgeBaseConfigurationFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1>(this CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1>(this CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2>(this CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2, T3, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T3, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T3, T4, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T4, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseVectorKnowledgeBaseConfigurationFactory> WithVectorKnowledgeBaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVectorKnowledgeBaseConfiguration(combinedResult.T5, subFactoryAction));
}
