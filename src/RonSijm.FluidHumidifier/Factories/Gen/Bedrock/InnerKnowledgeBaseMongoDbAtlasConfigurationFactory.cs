// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseMongoDbAtlasConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasConfiguration>
{

    internal InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory FieldMappingFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasConfiguration Create()
    {
        var mongoDbAtlasConfigurationResult = CreateMongoDbAtlasConfiguration();
        factoryAction?.Invoke(mongoDbAtlasConfigurationResult);

        return mongoDbAtlasConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasConfiguration CreateMongoDbAtlasConfiguration()
    {
        var mongoDbAtlasConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasConfiguration();

        return mongoDbAtlasConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasConfiguration result)
    {
        base.CreateChildren(result);

        result.FieldMapping ??= FieldMappingFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseMongoDbAtlasConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping(this InnerKnowledgeBaseMongoDbAtlasConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null)
    {
        parentFactory.FieldMappingFactory = new InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldMappingFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T1, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<T1, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T1, T2, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T2, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T2, T3, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T3, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T3, T4, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T4, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory, InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseMongoDbAtlasConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T5, subFactoryAction));
}
