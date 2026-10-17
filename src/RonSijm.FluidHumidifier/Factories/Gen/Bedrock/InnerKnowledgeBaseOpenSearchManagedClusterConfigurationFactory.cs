// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterConfiguration>
{

    internal InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory FieldMappingFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterConfiguration Create()
    {
        var openSearchManagedClusterConfigurationResult = CreateOpenSearchManagedClusterConfiguration();
        factoryAction?.Invoke(openSearchManagedClusterConfigurationResult);

        return openSearchManagedClusterConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterConfiguration CreateOpenSearchManagedClusterConfiguration()
    {
        var openSearchManagedClusterConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterConfiguration();

        return openSearchManagedClusterConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterConfiguration result)
    {
        base.CreateChildren(result);

        result.FieldMapping ??= FieldMappingFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping(this InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null)
    {
        parentFactory.FieldMappingFactory = new InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldMappingFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T1, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<T1, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T1, T2, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T2, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T2, T3, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T3, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T3, T4, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T4, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory, InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseOpenSearchManagedClusterConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T5, subFactoryAction).T2);
}
