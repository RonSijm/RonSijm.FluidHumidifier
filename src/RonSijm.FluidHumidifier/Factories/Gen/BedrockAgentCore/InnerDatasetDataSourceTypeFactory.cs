// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerDatasetDataSourceTypeFactory(Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType>
{

    internal InnerDatasetInlineExamplesSourceFactory InlineExamplesFactory { get; set; }

    internal InnerDatasetS3SourceFactory S3SourceFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType Create()
    {
        var dataSourceTypeResult = CreateDataSourceType();
        factoryAction?.Invoke(dataSourceTypeResult);

        return dataSourceTypeResult;
    }

    private Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType CreateDataSourceType()
    {
        var dataSourceTypeResult = new Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType();

        return dataSourceTypeResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType result)
    {
        base.CreateChildren(result);

        result.InlineExamples ??= InlineExamplesFactory?.Build();
        result.S3Source ??= S3SourceFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetDataSourceTypeFactoryExtensions
{
    public static CombinedResult<InnerDatasetDataSourceTypeFactory, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples(this InnerDatasetDataSourceTypeFactory parentFactory, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null)
    {
        parentFactory.InlineExamplesFactory = new InnerDatasetInlineExamplesSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InlineExamplesFactory);
    }

    public static CombinedResult<InnerDatasetDataSourceTypeFactory, InnerDatasetS3SourceFactory> WithS3Source(this InnerDatasetDataSourceTypeFactory parentFactory, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null)
    {
        parentFactory.S3SourceFactory = new InnerDatasetS3SourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3SourceFactory);
    }

    public static CombinedResult<InnerDatasetDataSourceTypeFactory, T1, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1>(this CombinedResult<InnerDatasetDataSourceTypeFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithInlineExamples(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDataSourceTypeFactory, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1>(this CombinedResult<T1, InnerDatasetDataSourceTypeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithInlineExamples(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2>(this CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2>(this CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2>(this CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2, T3, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2, T3>(this CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2, T3, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2, T3>(this CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory, T3, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetDataSourceTypeFactory, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetDataSourceTypeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2, T3, T4, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2, T3, T4>(this CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2, T3, T4, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory, T3, T4, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetDataSourceTypeFactory, T4, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetDataSourceTypeFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetDataSourceTypeFactory, InnerDatasetInlineExamplesSourceFactory> WithInlineExamples<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetDataSourceTypeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInlineExamples(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDataSourceTypeFactory, T1, InnerDatasetS3SourceFactory> WithS3Source<T1>(this CombinedResult<InnerDatasetDataSourceTypeFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Source(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDataSourceTypeFactory, InnerDatasetS3SourceFactory> WithS3Source<T1>(this CombinedResult<T1, InnerDatasetDataSourceTypeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Source(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2, InnerDatasetS3SourceFactory> WithS3Source<T1, T2>(this CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2, InnerDatasetS3SourceFactory> WithS3Source<T1, T2>(this CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory, InnerDatasetS3SourceFactory> WithS3Source<T1, T2>(this CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2, T3, InnerDatasetS3SourceFactory> WithS3Source<T1, T2, T3>(this CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2, T3, InnerDatasetS3SourceFactory> WithS3Source<T1, T2, T3>(this CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory, T3, InnerDatasetS3SourceFactory> WithS3Source<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetDataSourceTypeFactory, InnerDatasetS3SourceFactory> WithS3Source<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetDataSourceTypeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2, T3, T4, InnerDatasetS3SourceFactory> WithS3Source<T1, T2, T3, T4>(this CombinedResult<InnerDatasetDataSourceTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2, T3, T4, InnerDatasetS3SourceFactory> WithS3Source<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetDataSourceTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory, T3, T4, InnerDatasetS3SourceFactory> WithS3Source<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetDataSourceTypeFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDatasetDataSourceTypeFactory, T4, InnerDatasetS3SourceFactory> WithS3Source<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetDataSourceTypeFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetDataSourceTypeFactory, InnerDatasetS3SourceFactory> WithS3Source<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetDataSourceTypeFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.S3Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Source(combinedResult.T5, subFactoryAction).T2);
}
