// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class RealtimeLogConfigFactory(string resourceName = null, Action<Humidifier.CloudFront.RealtimeLogConfig> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.RealtimeLogConfig>(resourceName)
{

    internal List<InnerRealtimeLogConfigEndPointFactory> EndPointsFactories { get; set; } = [];

    protected override Humidifier.CloudFront.RealtimeLogConfig Create()
    {
        var realtimeLogConfigResult = CreateRealtimeLogConfig();
        factoryAction?.Invoke(realtimeLogConfigResult);

        return realtimeLogConfigResult;
    }

    private Humidifier.CloudFront.RealtimeLogConfig CreateRealtimeLogConfig()
    {
        var realtimeLogConfigResult = new Humidifier.CloudFront.RealtimeLogConfig
        {
            GivenName = InputResourceName,
        };

        return realtimeLogConfigResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.RealtimeLogConfig result)
    {
        base.CreateChildren(result);

        result.EndPoints = EndPointsFactories.Any() ? EndPointsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RealtimeLogConfigFactoryExtensions
{
    public static CombinedResult<RealtimeLogConfigFactory, InnerRealtimeLogConfigEndPointFactory> WithEndPoints(this RealtimeLogConfigFactory parentFactory, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null)
    {
        var factory = new InnerRealtimeLogConfigEndPointFactory(subFactoryAction);
        parentFactory.EndPointsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RealtimeLogConfigFactory, T1, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1>(this CombinedResult<RealtimeLogConfigFactory, T1> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndPoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RealtimeLogConfigFactory, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1>(this CombinedResult<T1, RealtimeLogConfigFactory> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndPoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RealtimeLogConfigFactory, T1, T2, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2>(this CombinedResult<RealtimeLogConfigFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RealtimeLogConfigFactory, T2, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2>(this CombinedResult<T1, RealtimeLogConfigFactory, T2> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RealtimeLogConfigFactory, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2>(this CombinedResult<T1, T2, RealtimeLogConfigFactory> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RealtimeLogConfigFactory, T1, T2, T3, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2, T3>(this CombinedResult<RealtimeLogConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RealtimeLogConfigFactory, T2, T3, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2, T3>(this CombinedResult<T1, RealtimeLogConfigFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RealtimeLogConfigFactory, T3, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2, T3>(this CombinedResult<T1, T2, RealtimeLogConfigFactory, T3> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RealtimeLogConfigFactory, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2, T3>(this CombinedResult<T1, T2, T3, RealtimeLogConfigFactory> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RealtimeLogConfigFactory, T1, T2, T3, T4, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2, T3, T4>(this CombinedResult<RealtimeLogConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RealtimeLogConfigFactory, T2, T3, T4, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2, T3, T4>(this CombinedResult<T1, RealtimeLogConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RealtimeLogConfigFactory, T3, T4, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, RealtimeLogConfigFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RealtimeLogConfigFactory, T4, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RealtimeLogConfigFactory, T4> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RealtimeLogConfigFactory, InnerRealtimeLogConfigEndPointFactory> WithEndPoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RealtimeLogConfigFactory> combinedResult, Action<Humidifier.CloudFront.RealtimeLogConfigTypes.EndPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndPoints(combinedResult.T5, subFactoryAction));
}
