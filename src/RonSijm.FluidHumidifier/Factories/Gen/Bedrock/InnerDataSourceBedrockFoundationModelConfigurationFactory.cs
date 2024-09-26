// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceBedrockFoundationModelConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration>
{

    internal InnerDataSourceParsingPromptFactory ParsingPromptFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration Create()
    {
        var bedrockFoundationModelConfigurationResult = CreateBedrockFoundationModelConfiguration();
        factoryAction?.Invoke(bedrockFoundationModelConfigurationResult);

        return bedrockFoundationModelConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration CreateBedrockFoundationModelConfiguration()
    {
        var bedrockFoundationModelConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration();

        return bedrockFoundationModelConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration result)
    {
        base.CreateChildren(result);

        result.ParsingPrompt ??= ParsingPromptFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceBedrockFoundationModelConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceBedrockFoundationModelConfigurationFactory, InnerDataSourceParsingPromptFactory> WithParsingPrompt(this InnerDataSourceBedrockFoundationModelConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null)
    {
        parentFactory.ParsingPromptFactory = new InnerDataSourceParsingPromptFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParsingPromptFactory);
    }

    public static CombinedResult<InnerDataSourceBedrockFoundationModelConfigurationFactory, T1, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1>(this CombinedResult<InnerDataSourceBedrockFoundationModelConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, WithParsingPrompt(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceBedrockFoundationModelConfigurationFactory, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1>(this CombinedResult<T1, InnerDataSourceBedrockFoundationModelConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, WithParsingPrompt(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceBedrockFoundationModelConfigurationFactory, T1, T2, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2>(this CombinedResult<InnerDataSourceBedrockFoundationModelConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceBedrockFoundationModelConfigurationFactory, T2, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2>(this CombinedResult<T1, InnerDataSourceBedrockFoundationModelConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelConfigurationFactory, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceBedrockFoundationModelConfigurationFactory, T1, T2, T3, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2, T3>(this CombinedResult<InnerDataSourceBedrockFoundationModelConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceBedrockFoundationModelConfigurationFactory, T2, T3, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceBedrockFoundationModelConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelConfigurationFactory, T3, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceBedrockFoundationModelConfigurationFactory, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceBedrockFoundationModelConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceBedrockFoundationModelConfigurationFactory, T1, T2, T3, T4, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceBedrockFoundationModelConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceBedrockFoundationModelConfigurationFactory, T2, T3, T4, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceBedrockFoundationModelConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelConfigurationFactory, T3, T4, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceBedrockFoundationModelConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceBedrockFoundationModelConfigurationFactory, T4, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceBedrockFoundationModelConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceBedrockFoundationModelConfigurationFactory, InnerDataSourceParsingPromptFactory> WithParsingPrompt<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceBedrockFoundationModelConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParsingPrompt(combinedResult.T5, subFactoryAction));
}
