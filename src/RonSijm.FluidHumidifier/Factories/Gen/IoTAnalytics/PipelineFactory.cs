// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class PipelineFactory(string resourceName = null, Action<Humidifier.IoTAnalytics.Pipeline> factoryAction = null) : ResourceFactory<Humidifier.IoTAnalytics.Pipeline>(resourceName)
{

    internal List<InnerPipelineActivityFactory> PipelineActivitiesFactories { get; set; } = [];

    protected override Humidifier.IoTAnalytics.Pipeline Create()
    {
        var pipelineResult = CreatePipeline();
        factoryAction?.Invoke(pipelineResult);

        return pipelineResult;
    }

    private Humidifier.IoTAnalytics.Pipeline CreatePipeline()
    {
        var pipelineResult = new Humidifier.IoTAnalytics.Pipeline
        {
            GivenName = InputResourceName,
        };

        return pipelineResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.Pipeline result)
    {
        base.CreateChildren(result);

        result.PipelineActivities = PipelineActivitiesFactories.Any() ? PipelineActivitiesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class PipelineFactoryExtensions
{
    public static CombinedResult<PipelineFactory, InnerPipelineActivityFactory> WithPipelineActivities(this PipelineFactory parentFactory, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null)
    {
        var factory = new InnerPipelineActivityFactory(subFactoryAction);
        parentFactory.PipelineActivitiesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PipelineFactory, T1, InnerPipelineActivityFactory> WithPipelineActivities<T1>(this CombinedResult<PipelineFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, WithPipelineActivities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, InnerPipelineActivityFactory> WithPipelineActivities<T1>(this CombinedResult<T1, PipelineFactory> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, WithPipelineActivities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PipelineFactory, T1, T2, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2>(this CombinedResult<PipelineFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, T2, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2>(this CombinedResult<T1, PipelineFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PipelineFactory, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2>(this CombinedResult<T1, T2, PipelineFactory> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PipelineFactory, T1, T2, T3, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2, T3>(this CombinedResult<PipelineFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, T2, T3, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2, T3>(this CombinedResult<T1, PipelineFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PipelineFactory, T3, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2, T3>(this CombinedResult<T1, T2, PipelineFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PipelineFactory, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2, T3>(this CombinedResult<T1, T2, T3, PipelineFactory> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PipelineFactory, T1, T2, T3, T4, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2, T3, T4>(this CombinedResult<PipelineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, T2, T3, T4, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2, T3, T4>(this CombinedResult<T1, PipelineFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PipelineFactory, T3, T4, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2, T3, T4>(this CombinedResult<T1, T2, PipelineFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PipelineFactory, T4, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PipelineFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PipelineFactory, InnerPipelineActivityFactory> WithPipelineActivities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PipelineFactory> combinedResult, Action<Humidifier.IoTAnalytics.PipelineTypes.Activity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineActivities(combinedResult.T5, subFactoryAction));
}
