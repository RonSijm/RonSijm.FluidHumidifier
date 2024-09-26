// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessConfiguration>
{

    internal InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory FieldMappingFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessConfiguration Create()
    {
        var openSearchServerlessConfigurationResult = CreateOpenSearchServerlessConfiguration();
        factoryAction?.Invoke(openSearchServerlessConfigurationResult);

        return openSearchServerlessConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessConfiguration CreateOpenSearchServerlessConfiguration()
    {
        var openSearchServerlessConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessConfiguration();

        return openSearchServerlessConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessConfiguration result)
    {
        base.CreateChildren(result);

        result.FieldMapping ??= FieldMappingFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseOpenSearchServerlessConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping(this InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null)
    {
        parentFactory.FieldMappingFactory = new InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldMappingFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T1, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<T1, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T1, T2, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T2, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T2, T3, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T3, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T3, T4, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T4, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory, InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseOpenSearchServerlessConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T5, subFactoryAction));
}
