// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.SqlKnowledgeBaseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.SqlKnowledgeBaseConfiguration>
{

    internal InnerKnowledgeBaseRedshiftConfigurationFactory RedshiftConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.SqlKnowledgeBaseConfiguration Create()
    {
        var sqlKnowledgeBaseConfigurationResult = CreateSqlKnowledgeBaseConfiguration();
        factoryAction?.Invoke(sqlKnowledgeBaseConfigurationResult);

        return sqlKnowledgeBaseConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.SqlKnowledgeBaseConfiguration CreateSqlKnowledgeBaseConfiguration()
    {
        var sqlKnowledgeBaseConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.SqlKnowledgeBaseConfiguration();

        return sqlKnowledgeBaseConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.SqlKnowledgeBaseConfiguration result)
    {
        base.CreateChildren(result);

        result.RedshiftConfiguration ??= RedshiftConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration(this InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null)
    {
        parentFactory.RedshiftConfigurationFactory = new InnerKnowledgeBaseRedshiftConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RedshiftConfigurationFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T1, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1>(this CombinedResult<InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1>(this CombinedResult<T1, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T1, T2, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2>(this CombinedResult<InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T2, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T2, T3, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T3, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T3, T4, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T4, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory, InnerKnowledgeBaseRedshiftConfigurationFactory> WithRedshiftConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseSqlKnowledgeBaseConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedshiftConfiguration(combinedResult.T5, subFactoryAction).T2);
}
