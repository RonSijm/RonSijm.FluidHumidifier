// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceParsingConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.ParsingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.ParsingConfiguration>
{

    internal InnerDataSourceBedrockFoundationModelConfigurationFactory BedrockFoundationModelConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.ParsingConfiguration Create()
    {
        var parsingConfigurationResult = CreateParsingConfiguration();
        factoryAction?.Invoke(parsingConfigurationResult);

        return parsingConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.ParsingConfiguration CreateParsingConfiguration()
    {
        var parsingConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.ParsingConfiguration();

        return parsingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.ParsingConfiguration result)
    {
        base.CreateChildren(result);

        result.BedrockFoundationModelConfiguration ??= BedrockFoundationModelConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceParsingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceParsingConfigurationFactory, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration(this InnerDataSourceParsingConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null)
    {
        parentFactory.BedrockFoundationModelConfigurationFactory = new InnerDataSourceBedrockFoundationModelConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BedrockFoundationModelConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceParsingConfigurationFactory, T1, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1>(this CombinedResult<InnerDataSourceParsingConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceParsingConfigurationFactory, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1>(this CombinedResult<T1, InnerDataSourceParsingConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceParsingConfigurationFactory, T1, T2, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2>(this CombinedResult<InnerDataSourceParsingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceParsingConfigurationFactory, T2, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceParsingConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceParsingConfigurationFactory, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceParsingConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceParsingConfigurationFactory, T1, T2, T3, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceParsingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceParsingConfigurationFactory, T2, T3, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceParsingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceParsingConfigurationFactory, T3, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceParsingConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceParsingConfigurationFactory, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceParsingConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceParsingConfigurationFactory, T1, T2, T3, T4, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceParsingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceParsingConfigurationFactory, T2, T3, T4, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceParsingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceParsingConfigurationFactory, T3, T4, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceParsingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceParsingConfigurationFactory, T4, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceParsingConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceParsingConfigurationFactory, InnerDataSourceBedrockFoundationModelConfigurationFactory> WithBedrockFoundationModelConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceParsingConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBedrockFoundationModelConfiguration(combinedResult.T5, subFactoryAction));
}
