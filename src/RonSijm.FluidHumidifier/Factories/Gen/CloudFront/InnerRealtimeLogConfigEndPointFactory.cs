// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerRealtimeLogConfigEndPointFactory(Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint>
{

    internal InnerRealtimeLogConfigKinesisStreamConfigFactory KinesisStreamConfigFactory { get; set; }

    protected override Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint Create()
    {
        var endPointResult = CreateEndPoint();
        factoryAction?.Invoke(endPointResult);

        return endPointResult;
    }

    private Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint CreateEndPoint()
    {
        var endPointResult = new Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint();

        return endPointResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint result)
    {
        base.CreateChildren(result);

        result.KinesisStreamConfig ??= KinesisStreamConfigFactory?.Build();
    }

} // End Of Class

public static class InnerRealtimeLogConfigEndPointFactoryExtensions
{
    public static CombinedResult<InnerRealtimeLogConfigEndPointFactory, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig(this InnerRealtimeLogConfigEndPointFactory parentFactory, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null)
    {
        parentFactory.KinesisStreamConfigFactory = new InnerRealtimeLogConfigKinesisStreamConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KinesisStreamConfigFactory);
    }

    public static CombinedResult<InnerRealtimeLogConfigEndPointFactory, T1, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1>(this CombinedResult<InnerRealtimeLogConfigEndPointFactory, T1> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRealtimeLogConfigEndPointFactory, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1>(this CombinedResult<T1, InnerRealtimeLogConfigEndPointFactory> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRealtimeLogConfigEndPointFactory, T1, T2, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2>(this CombinedResult<InnerRealtimeLogConfigEndPointFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRealtimeLogConfigEndPointFactory, T2, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2>(this CombinedResult<T1, InnerRealtimeLogConfigEndPointFactory, T2> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRealtimeLogConfigEndPointFactory, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2>(this CombinedResult<T1, T2, InnerRealtimeLogConfigEndPointFactory> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRealtimeLogConfigEndPointFactory, T1, T2, T3, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2, T3>(this CombinedResult<InnerRealtimeLogConfigEndPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRealtimeLogConfigEndPointFactory, T2, T3, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2, T3>(this CombinedResult<T1, InnerRealtimeLogConfigEndPointFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRealtimeLogConfigEndPointFactory, T3, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerRealtimeLogConfigEndPointFactory, T3> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRealtimeLogConfigEndPointFactory, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRealtimeLogConfigEndPointFactory> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRealtimeLogConfigEndPointFactory, T1, T2, T3, T4, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2, T3, T4>(this CombinedResult<InnerRealtimeLogConfigEndPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRealtimeLogConfigEndPointFactory, T2, T3, T4, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerRealtimeLogConfigEndPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRealtimeLogConfigEndPointFactory, T3, T4, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRealtimeLogConfigEndPointFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRealtimeLogConfigEndPointFactory, T4, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRealtimeLogConfigEndPointFactory, T4> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRealtimeLogConfigEndPointFactory, InnerRealtimeLogConfigKinesisStreamConfigFactory> WithKinesisStreamConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRealtimeLogConfigEndPointFactory> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.KinesisStreamConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisStreamConfig(combinedResult.T5, subFactoryAction));
}
