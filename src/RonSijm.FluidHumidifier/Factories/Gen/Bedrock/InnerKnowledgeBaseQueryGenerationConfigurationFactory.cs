// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseQueryGenerationConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationConfiguration>
{

    internal InnerKnowledgeBaseQueryGenerationContextFactory GenerationContextFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationConfiguration Create()
    {
        var queryGenerationConfigurationResult = CreateQueryGenerationConfiguration();
        factoryAction?.Invoke(queryGenerationConfigurationResult);

        return queryGenerationConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationConfiguration CreateQueryGenerationConfiguration()
    {
        var queryGenerationConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationConfiguration();

        return queryGenerationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationConfiguration result)
    {
        base.CreateChildren(result);

        result.GenerationContext ??= GenerationContextFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseQueryGenerationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseQueryGenerationConfigurationFactory, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext(this InnerKnowledgeBaseQueryGenerationConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null)
    {
        parentFactory.GenerationContextFactory = new InnerKnowledgeBaseQueryGenerationContextFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GenerationContextFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseQueryGenerationConfigurationFactory, T1, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1>(this CombinedResult<InnerKnowledgeBaseQueryGenerationConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, WithGenerationContext(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseQueryGenerationConfigurationFactory, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1>(this CombinedResult<T1, InnerKnowledgeBaseQueryGenerationConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, WithGenerationContext(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseQueryGenerationConfigurationFactory, T1, T2, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2>(this CombinedResult<InnerKnowledgeBaseQueryGenerationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T2, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseQueryGenerationConfigurationFactory, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseQueryGenerationConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseQueryGenerationConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseQueryGenerationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T2, T3, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T3, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseQueryGenerationConfigurationFactory, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseQueryGenerationConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseQueryGenerationConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseQueryGenerationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T3, T4, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T4, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseQueryGenerationConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseQueryGenerationConfigurationFactory, InnerKnowledgeBaseQueryGenerationContextFactory> WithGenerationContext<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseQueryGenerationConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGenerationContext(combinedResult.T5, subFactoryAction).T2);
}
