// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseRedshiftServerlessConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessConfiguration>
{

    internal InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory AuthConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessConfiguration Create()
    {
        var redshiftServerlessConfigurationResult = CreateRedshiftServerlessConfiguration();
        factoryAction?.Invoke(redshiftServerlessConfigurationResult);

        return redshiftServerlessConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessConfiguration CreateRedshiftServerlessConfiguration()
    {
        var redshiftServerlessConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessConfiguration();

        return redshiftServerlessConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessConfiguration result)
    {
        base.CreateChildren(result);

        result.AuthConfiguration ??= AuthConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseRedshiftServerlessConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration(this InnerKnowledgeBaseRedshiftServerlessConfigurationFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null)
    {
        parentFactory.AuthConfigurationFactory = new InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthConfigurationFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T1, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1>(this CombinedResult<InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1>(this CombinedResult<T1, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T1, T2, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2>(this CombinedResult<InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T2, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T2, T3, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T3, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T3, T4, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T4, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory, InnerKnowledgeBaseRedshiftServerlessAuthConfigurationFactory> WithAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseRedshiftServerlessConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthConfiguration(combinedResult.T5, subFactoryAction).T2);
}
