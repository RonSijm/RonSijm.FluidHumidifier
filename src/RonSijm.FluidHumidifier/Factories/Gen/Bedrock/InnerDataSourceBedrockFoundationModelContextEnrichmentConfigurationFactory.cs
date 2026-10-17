// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration>
{

    internal InnerDataSourceEnrichmentStrategyConfigurationFactory EnrichmentStrategyConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration Create()
    {
        var bedrockFoundationModelContextEnrichmentConfigurationResult = CreateBedrockFoundationModelContextEnrichmentConfiguration();
        factoryAction?.Invoke(bedrockFoundationModelContextEnrichmentConfigurationResult);

        return bedrockFoundationModelContextEnrichmentConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration CreateBedrockFoundationModelContextEnrichmentConfiguration()
    {
        var bedrockFoundationModelContextEnrichmentConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration();

        return bedrockFoundationModelContextEnrichmentConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration result)
    {
        base.CreateChildren(result);

        result.EnrichmentStrategyConfiguration ??= EnrichmentStrategyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration(this InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null)
    {
        parentFactory.EnrichmentStrategyConfigurationFactory = new InnerDataSourceEnrichmentStrategyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EnrichmentStrategyConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T1, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1>(this CombinedResult<InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1>(this CombinedResult<T1, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T1, T2, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2>(this CombinedResult<InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T2, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T1, T2, T3, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T2, T3, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T3, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T1, T2, T3, T4, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T2, T3, T4, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T3, T4, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T4, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory, InnerDataSourceEnrichmentStrategyConfigurationFactory> WithEnrichmentStrategyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceBedrockFoundationModelContextEnrichmentConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnrichmentStrategyConfiguration(combinedResult.T5, subFactoryAction).T2);
}
