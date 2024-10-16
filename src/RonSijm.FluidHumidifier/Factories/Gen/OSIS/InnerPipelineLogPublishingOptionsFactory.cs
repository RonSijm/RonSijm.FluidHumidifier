// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OSIS;

public class InnerPipelineLogPublishingOptionsFactory(Action<Humidifier.OSIS.PipelineTypes.LogPublishingOptions> factoryAction = null) : SubResourceFactory<Humidifier.OSIS.PipelineTypes.LogPublishingOptions>
{

    internal InnerPipelineCloudWatchLogDestinationFactory CloudWatchLogDestinationFactory { get; set; }

    protected override Humidifier.OSIS.PipelineTypes.LogPublishingOptions Create()
    {
        var logPublishingOptionsResult = CreateLogPublishingOptions();
        factoryAction?.Invoke(logPublishingOptionsResult);

        return logPublishingOptionsResult;
    }

    private Humidifier.OSIS.PipelineTypes.LogPublishingOptions CreateLogPublishingOptions()
    {
        var logPublishingOptionsResult = new Humidifier.OSIS.PipelineTypes.LogPublishingOptions();

        return logPublishingOptionsResult;
    }
    public override void CreateChildren(Humidifier.OSIS.PipelineTypes.LogPublishingOptions result)
    {
        base.CreateChildren(result);

        result.CloudWatchLogDestination ??= CloudWatchLogDestinationFactory?.Build();
    }

} // End Of Class

public static class InnerPipelineLogPublishingOptionsFactoryExtensions
{
    public static CombinedResult<InnerPipelineLogPublishingOptionsFactory, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination(this InnerPipelineLogPublishingOptionsFactory parentFactory, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null)
    {
        parentFactory.CloudWatchLogDestinationFactory = new InnerPipelineCloudWatchLogDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchLogDestinationFactory);
    }

    public static CombinedResult<InnerPipelineLogPublishingOptionsFactory, T1, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1>(this CombinedResult<InnerPipelineLogPublishingOptionsFactory, T1> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineLogPublishingOptionsFactory, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1>(this CombinedResult<T1, InnerPipelineLogPublishingOptionsFactory> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipelineLogPublishingOptionsFactory, T1, T2, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2>(this CombinedResult<InnerPipelineLogPublishingOptionsFactory, T1, T2> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineLogPublishingOptionsFactory, T2, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2>(this CombinedResult<T1, InnerPipelineLogPublishingOptionsFactory, T2> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineLogPublishingOptionsFactory, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2>(this CombinedResult<T1, T2, InnerPipelineLogPublishingOptionsFactory> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipelineLogPublishingOptionsFactory, T1, T2, T3, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2, T3>(this CombinedResult<InnerPipelineLogPublishingOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineLogPublishingOptionsFactory, T2, T3, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2, T3>(this CombinedResult<T1, InnerPipelineLogPublishingOptionsFactory, T2, T3> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineLogPublishingOptionsFactory, T3, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipelineLogPublishingOptionsFactory, T3> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelineLogPublishingOptionsFactory, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipelineLogPublishingOptionsFactory> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipelineLogPublishingOptionsFactory, T1, T2, T3, T4, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2, T3, T4>(this CombinedResult<InnerPipelineLogPublishingOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineLogPublishingOptionsFactory, T2, T3, T4, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipelineLogPublishingOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineLogPublishingOptionsFactory, T3, T4, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipelineLogPublishingOptionsFactory, T3, T4> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelineLogPublishingOptionsFactory, T4, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipelineLogPublishingOptionsFactory, T4> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipelineLogPublishingOptionsFactory, InnerPipelineCloudWatchLogDestinationFactory> WithCloudWatchLogDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipelineLogPublishingOptionsFactory> combinedResult, Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogDestination(combinedResult.T5, subFactoryAction));
}
