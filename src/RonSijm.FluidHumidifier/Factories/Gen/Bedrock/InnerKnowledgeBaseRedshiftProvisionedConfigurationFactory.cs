// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedConfiguration>
{

    internal InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory AuthConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedConfiguration Create()
    {
        var redshiftProvisionedConfigurationResult = CreateRedshiftProvisionedConfiguration();
        factoryAction?.Invoke(redshiftProvisionedConfigurationResult);

        return redshiftProvisionedConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedConfiguration CreateRedshiftProvisionedConfiguration()
    {
        var redshiftProvisionedConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedConfiguration();

        return redshiftProvisionedConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedConfiguration result)
    {
        base.CreateChildren(result);

        result.AuthConfiguration ??= AuthConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseRedshiftProvisionedConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration(this InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null)
    {
        parentFactory.AuthConfigurationFactory = new InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthConfigurationFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T1, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1>(this CombinedResult<InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1>(this CombinedResult<T1, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T1, T2, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2>(this CombinedResult<InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T2, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T2, T3, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T3, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T3, T4, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T4, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory, InnerKnowledgeBaseRedshiftProvisionedAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseRedshiftProvisionedConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T5, subFactoryAction).T2);
}
