// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBasePineconeConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeConfiguration>
{

    internal InnerKnowledgeBasePineconeFieldMappingFactory FieldMappingFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.PineconeConfiguration Create()
    {
        var pineconeConfigurationResult = CreatePineconeConfiguration();
        factoryAction?.Invoke(pineconeConfigurationResult);

        return pineconeConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.PineconeConfiguration CreatePineconeConfiguration()
    {
        var pineconeConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.PineconeConfiguration();

        return pineconeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.PineconeConfiguration result)
    {
        base.CreateChildren(result);

        result.FieldMapping ??= FieldMappingFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBasePineconeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBasePineconeConfigurationFactory, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping(this InnerKnowledgeBasePineconeConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null)
    {
        parentFactory.FieldMappingFactory = new InnerKnowledgeBasePineconeFieldMappingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldMappingFactory);
    }

    public static CombinedResult<InnerKnowledgeBasePineconeConfigurationFactory, T1, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<InnerKnowledgeBasePineconeConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBasePineconeConfigurationFactory, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<T1, InnerKnowledgeBasePineconeConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBasePineconeConfigurationFactory, T1, T2, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<InnerKnowledgeBasePineconeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBasePineconeConfigurationFactory, T2, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, InnerKnowledgeBasePineconeConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBasePineconeConfigurationFactory, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBasePineconeConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBasePineconeConfigurationFactory, T1, T2, T3, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<InnerKnowledgeBasePineconeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBasePineconeConfigurationFactory, T2, T3, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBasePineconeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBasePineconeConfigurationFactory, T3, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBasePineconeConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBasePineconeConfigurationFactory, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBasePineconeConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBasePineconeConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBasePineconeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBasePineconeConfigurationFactory, T2, T3, T4, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBasePineconeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBasePineconeConfigurationFactory, T3, T4, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBasePineconeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBasePineconeConfigurationFactory, T4, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBasePineconeConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBasePineconeConfigurationFactory, InnerKnowledgeBasePineconeFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBasePineconeConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T5, subFactoryAction));
}
