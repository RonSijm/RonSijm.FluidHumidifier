// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class MonitoringSubscriptionFactory(string resourceName = null, Action<Humidifier.CloudFront.MonitoringSubscription> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.MonitoringSubscription>(resourceName)
{

    internal InnerMonitoringSubscriptionMonitoringSubscriptionFactory MonitoringSubscription_Factory { get; set; }

    protected override Humidifier.CloudFront.MonitoringSubscription Create()
    {
        var monitoringSubscriptionResult = CreateMonitoringSubscription();
        factoryAction?.Invoke(monitoringSubscriptionResult);

        return monitoringSubscriptionResult;
    }

    private Humidifier.CloudFront.MonitoringSubscription CreateMonitoringSubscription()
    {
        var monitoringSubscriptionResult = new Humidifier.CloudFront.MonitoringSubscription
        {
            GivenName = InputResourceName,
        };

        return monitoringSubscriptionResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.MonitoringSubscription result)
    {
        base.CreateChildren(result);

        result.MonitoringSubscription_ ??= MonitoringSubscription_Factory?.Build();
    }

} // End Of Class

public static class MonitoringSubscriptionFactoryExtensions
{
    public static CombinedResult<MonitoringSubscriptionFactory, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_(this MonitoringSubscriptionFactory parentFactory, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null)
    {
        parentFactory.MonitoringSubscription_Factory = new InnerMonitoringSubscriptionMonitoringSubscriptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MonitoringSubscription_Factory);
    }

    public static CombinedResult<MonitoringSubscriptionFactory, T1, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1>(this CombinedResult<MonitoringSubscriptionFactory, T1> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringSubscriptionFactory, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1>(this CombinedResult<T1, MonitoringSubscriptionFactory> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MonitoringSubscriptionFactory, T1, T2, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2>(this CombinedResult<MonitoringSubscriptionFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringSubscriptionFactory, T2, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2>(this CombinedResult<T1, MonitoringSubscriptionFactory, T2> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitoringSubscriptionFactory, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2>(this CombinedResult<T1, T2, MonitoringSubscriptionFactory> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MonitoringSubscriptionFactory, T1, T2, T3, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2, T3>(this CombinedResult<MonitoringSubscriptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringSubscriptionFactory, T2, T3, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2, T3>(this CombinedResult<T1, MonitoringSubscriptionFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitoringSubscriptionFactory, T3, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2, T3>(this CombinedResult<T1, T2, MonitoringSubscriptionFactory, T3> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MonitoringSubscriptionFactory, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2, T3>(this CombinedResult<T1, T2, T3, MonitoringSubscriptionFactory> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MonitoringSubscriptionFactory, T1, T2, T3, T4, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2, T3, T4>(this CombinedResult<MonitoringSubscriptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringSubscriptionFactory, T2, T3, T4, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2, T3, T4>(this CombinedResult<T1, MonitoringSubscriptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitoringSubscriptionFactory, T3, T4, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2, T3, T4>(this CombinedResult<T1, T2, MonitoringSubscriptionFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MonitoringSubscriptionFactory, T4, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MonitoringSubscriptionFactory, T4> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MonitoringSubscriptionFactory, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> WithMonitoringSubscription_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MonitoringSubscriptionFactory> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringSubscription_(combinedResult.T5, subFactoryAction));
}
