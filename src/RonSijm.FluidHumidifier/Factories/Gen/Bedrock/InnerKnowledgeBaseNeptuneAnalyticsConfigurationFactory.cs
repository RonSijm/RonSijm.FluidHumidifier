// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsConfiguration>
{

    internal InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory FieldMappingFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsConfiguration Create()
    {
        var neptuneAnalyticsConfigurationResult = CreateNeptuneAnalyticsConfiguration();
        factoryAction?.Invoke(neptuneAnalyticsConfigurationResult);

        return neptuneAnalyticsConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsConfiguration CreateNeptuneAnalyticsConfiguration()
    {
        var neptuneAnalyticsConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsConfiguration();

        return neptuneAnalyticsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsConfiguration result)
    {
        base.CreateChildren(result);

        result.FieldMapping ??= FieldMappingFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping(this InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null)
    {
        parentFactory.FieldMappingFactory = new InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldMappingFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T1, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<T1, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T1, T2, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T2, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T2, T3, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T3, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T3, T4, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T4, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory, InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseNeptuneAnalyticsConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T5, subFactoryAction).T2);
}
