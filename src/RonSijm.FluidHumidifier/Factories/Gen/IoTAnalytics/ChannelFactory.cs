// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class ChannelFactory(string resourceName = null, Action<Humidifier.IoTAnalytics.Channel> factoryAction = null) : ResourceFactory<Humidifier.IoTAnalytics.Channel>(resourceName)
{

    internal InnerChannelChannelStorageFactory ChannelStorageFactory { get; set; }

    internal InnerChannelRetentionPeriodFactory RetentionPeriodFactory { get; set; }

    protected override Humidifier.IoTAnalytics.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.IoTAnalytics.Channel CreateChannel()
    {
        var channelResult = new Humidifier.IoTAnalytics.Channel
        {
            GivenName = InputResourceName,
        };

        return channelResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.Channel result)
    {
        base.CreateChildren(result);

        result.ChannelStorage ??= ChannelStorageFactory?.Build();
        result.RetentionPeriod ??= RetentionPeriodFactory?.Build();
    }

} // End Of Class

public static class ChannelFactoryExtensions
{
    public static CombinedResult<ChannelFactory, InnerChannelChannelStorageFactory> WithChannelStorage(this ChannelFactory parentFactory, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null)
    {
        parentFactory.ChannelStorageFactory = new InnerChannelChannelStorageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ChannelStorageFactory);
    }

    public static CombinedResult<ChannelFactory, InnerChannelRetentionPeriodFactory> WithRetentionPeriod(this ChannelFactory parentFactory, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null)
    {
        parentFactory.RetentionPeriodFactory = new InnerChannelRetentionPeriodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetentionPeriodFactory);
    }

    public static CombinedResult<ChannelFactory, T1, InnerChannelChannelStorageFactory> WithChannelStorage<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithChannelStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, InnerChannelChannelStorageFactory> WithChannelStorage<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, WithChannelStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelChannelStorageFactory> WithChannelStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChannelStorage(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T5, subFactoryAction));
}
