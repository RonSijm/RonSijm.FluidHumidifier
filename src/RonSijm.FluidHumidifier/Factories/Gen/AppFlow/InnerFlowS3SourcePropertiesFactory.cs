// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowS3SourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.S3SourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.S3SourceProperties>
{

    internal InnerFlowS3InputFormatConfigFactory S3InputFormatConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.S3SourceProperties Create()
    {
        var s3SourcePropertiesResult = CreateS3SourceProperties();
        factoryAction?.Invoke(s3SourcePropertiesResult);

        return s3SourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.S3SourceProperties CreateS3SourceProperties()
    {
        var s3SourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.S3SourceProperties();

        return s3SourcePropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.S3SourceProperties result)
    {
        base.CreateChildren(result);

        result.S3InputFormatConfig ??= S3InputFormatConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowS3SourcePropertiesFactoryExtensions
{
    public static CombinedResult<InnerFlowS3SourcePropertiesFactory, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig(this InnerFlowS3SourcePropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null)
    {
        parentFactory.S3InputFormatConfigFactory = new InnerFlowS3InputFormatConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3InputFormatConfigFactory);
    }

    public static CombinedResult<InnerFlowS3SourcePropertiesFactory, T1, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1>(this CombinedResult<InnerFlowS3SourcePropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3SourcePropertiesFactory, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1>(this CombinedResult<T1, InnerFlowS3SourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowS3SourcePropertiesFactory, T1, T2, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2>(this CombinedResult<InnerFlowS3SourcePropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3SourcePropertiesFactory, T2, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2>(this CombinedResult<T1, InnerFlowS3SourcePropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3SourcePropertiesFactory, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowS3SourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowS3SourcePropertiesFactory, T1, T2, T3, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2, T3>(this CombinedResult<InnerFlowS3SourcePropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3SourcePropertiesFactory, T2, T3, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowS3SourcePropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3SourcePropertiesFactory, T3, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowS3SourcePropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowS3SourcePropertiesFactory, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowS3SourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowS3SourcePropertiesFactory, T1, T2, T3, T4, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowS3SourcePropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3SourcePropertiesFactory, T2, T3, T4, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowS3SourcePropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3SourcePropertiesFactory, T3, T4, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowS3SourcePropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowS3SourcePropertiesFactory, T4, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowS3SourcePropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowS3SourcePropertiesFactory, InnerFlowS3InputFormatConfigFactory> WithS3InputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowS3SourcePropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3InputFormatConfig(combinedResult.T5, subFactoryAction));
}
