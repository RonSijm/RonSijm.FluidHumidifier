// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseRdsConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.RdsConfiguration>
{

    internal InnerKnowledgeBaseRdsFieldMappingFactory FieldMappingFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.RdsConfiguration Create()
    {
        var rdsConfigurationResult = CreateRdsConfiguration();
        factoryAction?.Invoke(rdsConfigurationResult);

        return rdsConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.RdsConfiguration CreateRdsConfiguration()
    {
        var rdsConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.RdsConfiguration();

        return rdsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.RdsConfiguration result)
    {
        base.CreateChildren(result);

        result.FieldMapping ??= FieldMappingFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseRdsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseRdsConfigurationFactory, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping(this InnerKnowledgeBaseRdsConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null)
    {
        parentFactory.FieldMappingFactory = new InnerKnowledgeBaseRdsFieldMappingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldMappingFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseRdsConfigurationFactory, T1, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<InnerKnowledgeBaseRdsConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseRdsConfigurationFactory, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1>(this CombinedResult<T1, InnerKnowledgeBaseRdsConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseRdsConfigurationFactory, T1, T2, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<InnerKnowledgeBaseRdsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseRdsConfigurationFactory, T2, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseRdsConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseRdsConfigurationFactory, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseRdsConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseRdsConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseRdsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseRdsConfigurationFactory, T2, T3, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseRdsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseRdsConfigurationFactory, T3, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseRdsConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseRdsConfigurationFactory, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseRdsConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseRdsConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseRdsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseRdsConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseRdsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseRdsConfigurationFactory, T3, T4, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseRdsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseRdsConfigurationFactory, T4, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseRdsConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseRdsConfigurationFactory, InnerKnowledgeBaseRdsFieldMappingFactory> WithFieldMapping<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseRdsConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldMapping(combinedResult.T5, subFactoryAction));
}
