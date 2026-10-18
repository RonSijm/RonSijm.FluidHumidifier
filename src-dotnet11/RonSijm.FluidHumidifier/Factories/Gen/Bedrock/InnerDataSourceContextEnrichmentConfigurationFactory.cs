// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceContextEnrichmentConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.ContextEnrichmentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.ContextEnrichmentConfiguration>
{

    internal InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory BedrockFoundationModelConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.ContextEnrichmentConfiguration Create()
    {
        var contextEnrichmentConfigurationResult = CreateContextEnrichmentConfiguration();
        factoryAction?.Invoke(contextEnrichmentConfigurationResult);

        return contextEnrichmentConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.ContextEnrichmentConfiguration CreateContextEnrichmentConfiguration()
    {
        var contextEnrichmentConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.ContextEnrichmentConfiguration();

        return contextEnrichmentConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.ContextEnrichmentConfiguration result)
    {
        base.CreateChildren(result);

        result.BedrockFoundationModelConfiguration ??= BedrockFoundationModelConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceContextEnrichmentConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceContextEnrichmentConfigurationFactory, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration(this InnerDataSourceContextEnrichmentConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null)
    {
        parentFactory.BedrockFoundationModelConfigurationFactory = new InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BedrockFoundationModelConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceContextEnrichmentConfigurationFactory, T1, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1>(this CombinedResult<InnerDataSourceContextEnrichmentConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceContextEnrichmentConfigurationFactory, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1>(this CombinedResult<T1, InnerDataSourceContextEnrichmentConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceContextEnrichmentConfigurationFactory, T1, T2, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2>(this CombinedResult<InnerDataSourceContextEnrichmentConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceContextEnrichmentConfigurationFactory, T2, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceContextEnrichmentConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceContextEnrichmentConfigurationFactory, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceContextEnrichmentConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceContextEnrichmentConfigurationFactory, T1, T2, T3, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceContextEnrichmentConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceContextEnrichmentConfigurationFactory, T2, T3, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceContextEnrichmentConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceContextEnrichmentConfigurationFactory, T3, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceContextEnrichmentConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceContextEnrichmentConfigurationFactory, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceContextEnrichmentConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceContextEnrichmentConfigurationFactory, T1, T2, T3, T4, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceContextEnrichmentConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceContextEnrichmentConfigurationFactory, T2, T3, T4, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceContextEnrichmentConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceContextEnrichmentConfigurationFactory, T3, T4, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceContextEnrichmentConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceContextEnrichmentConfigurationFactory, T4, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceContextEnrichmentConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceContextEnrichmentConfigurationFactory, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceContextEnrichmentConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T5, subFactoryAction).T2);
}
