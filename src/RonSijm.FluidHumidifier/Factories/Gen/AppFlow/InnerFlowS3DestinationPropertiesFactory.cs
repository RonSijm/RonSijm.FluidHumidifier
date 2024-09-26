// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowS3DestinationPropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.S3DestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.S3DestinationProperties>
{

    internal InnerFlowS3OutputFormatConfigFactory S3OutputFormatConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.S3DestinationProperties Create()
    {
        var s3DestinationPropertiesResult = CreateS3DestinationProperties();
        factoryAction?.Invoke(s3DestinationPropertiesResult);

        return s3DestinationPropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.S3DestinationProperties CreateS3DestinationProperties()
    {
        var s3DestinationPropertiesResult = new Humidifier.AppFlow.FlowTypes.S3DestinationProperties();

        return s3DestinationPropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.S3DestinationProperties result)
    {
        base.CreateChildren(result);

        result.S3OutputFormatConfig ??= S3OutputFormatConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowS3DestinationPropertiesFactoryExtensions
{
    public static CombinedResult<InnerFlowS3DestinationPropertiesFactory, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig(this InnerFlowS3DestinationPropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null)
    {
        parentFactory.S3OutputFormatConfigFactory = new InnerFlowS3OutputFormatConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3OutputFormatConfigFactory);
    }

    public static CombinedResult<InnerFlowS3DestinationPropertiesFactory, T1, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1>(this CombinedResult<InnerFlowS3DestinationPropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3DestinationPropertiesFactory, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1>(this CombinedResult<T1, InnerFlowS3DestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowS3DestinationPropertiesFactory, T1, T2, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2>(this CombinedResult<InnerFlowS3DestinationPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3DestinationPropertiesFactory, T2, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2>(this CombinedResult<T1, InnerFlowS3DestinationPropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3DestinationPropertiesFactory, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowS3DestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowS3DestinationPropertiesFactory, T1, T2, T3, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3>(this CombinedResult<InnerFlowS3DestinationPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3DestinationPropertiesFactory, T2, T3, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowS3DestinationPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3DestinationPropertiesFactory, T3, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowS3DestinationPropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowS3DestinationPropertiesFactory, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowS3DestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowS3DestinationPropertiesFactory, T1, T2, T3, T4, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowS3DestinationPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3DestinationPropertiesFactory, T2, T3, T4, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowS3DestinationPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3DestinationPropertiesFactory, T3, T4, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowS3DestinationPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowS3DestinationPropertiesFactory, T4, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowS3DestinationPropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowS3DestinationPropertiesFactory, InnerFlowS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowS3DestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T5, subFactoryAction));
}
