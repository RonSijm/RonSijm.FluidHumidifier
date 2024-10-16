// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowUpsolverDestinationPropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.UpsolverDestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.UpsolverDestinationProperties>
{

    internal InnerFlowUpsolverS3OutputFormatConfigFactory S3OutputFormatConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.UpsolverDestinationProperties Create()
    {
        var upsolverDestinationPropertiesResult = CreateUpsolverDestinationProperties();
        factoryAction?.Invoke(upsolverDestinationPropertiesResult);

        return upsolverDestinationPropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.UpsolverDestinationProperties CreateUpsolverDestinationProperties()
    {
        var upsolverDestinationPropertiesResult = new Humidifier.AppFlow.FlowTypes.UpsolverDestinationProperties();

        return upsolverDestinationPropertiesResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.UpsolverDestinationProperties result)
    {
        base.CreateChildren(result);

        result.S3OutputFormatConfig ??= S3OutputFormatConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowUpsolverDestinationPropertiesFactoryExtensions
{
    public static CombinedResult<InnerFlowUpsolverDestinationPropertiesFactory, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig(this InnerFlowUpsolverDestinationPropertiesFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null)
    {
        parentFactory.S3OutputFormatConfigFactory = new InnerFlowUpsolverS3OutputFormatConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3OutputFormatConfigFactory);
    }

    public static CombinedResult<InnerFlowUpsolverDestinationPropertiesFactory, T1, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1>(this CombinedResult<InnerFlowUpsolverDestinationPropertiesFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverDestinationPropertiesFactory, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1>(this CombinedResult<T1, InnerFlowUpsolverDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowUpsolverDestinationPropertiesFactory, T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2>(this CombinedResult<InnerFlowUpsolverDestinationPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverDestinationPropertiesFactory, T2, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2>(this CombinedResult<T1, InnerFlowUpsolverDestinationPropertiesFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowUpsolverDestinationPropertiesFactory, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowUpsolverDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowUpsolverDestinationPropertiesFactory, T1, T2, T3, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3>(this CombinedResult<InnerFlowUpsolverDestinationPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverDestinationPropertiesFactory, T2, T3, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowUpsolverDestinationPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowUpsolverDestinationPropertiesFactory, T3, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowUpsolverDestinationPropertiesFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowUpsolverDestinationPropertiesFactory, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowUpsolverDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowUpsolverDestinationPropertiesFactory, T1, T2, T3, T4, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowUpsolverDestinationPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverDestinationPropertiesFactory, T2, T3, T4, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowUpsolverDestinationPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowUpsolverDestinationPropertiesFactory, T3, T4, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowUpsolverDestinationPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowUpsolverDestinationPropertiesFactory, T4, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowUpsolverDestinationPropertiesFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowUpsolverDestinationPropertiesFactory, InnerFlowUpsolverS3OutputFormatConfigFactory> WithS3OutputFormatConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowUpsolverDestinationPropertiesFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputFormatConfig(combinedResult.T5, subFactoryAction));
}
