// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerChannelChannelStorageFactory(Action<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage>
{

    internal InnerChannelCustomerManagedS3Factory CustomerManagedS3Factory { get; set; }

    protected override Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage Create()
    {
        var channelStorageResult = CreateChannelStorage();
        factoryAction?.Invoke(channelStorageResult);

        return channelStorageResult;
    }

    private Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage CreateChannelStorage()
    {
        var channelStorageResult = new Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage();

        return channelStorageResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.ChannelTypes.ChannelStorage result)
    {
        base.CreateChildren(result);

        result.CustomerManagedS3 ??= CustomerManagedS3Factory?.Build();
    }

} // End Of Class

public static class InnerChannelChannelStorageFactoryExtensions
{
    public static CombinedResult<InnerChannelChannelStorageFactory, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3(this InnerChannelChannelStorageFactory parentFactory, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null)
    {
        parentFactory.CustomerManagedS3Factory = new InnerChannelCustomerManagedS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomerManagedS3Factory);
    }

    public static CombinedResult<InnerChannelChannelStorageFactory, T1, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1>(this CombinedResult<InnerChannelChannelStorageFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelChannelStorageFactory, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1>(this CombinedResult<T1, InnerChannelChannelStorageFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelChannelStorageFactory, T1, T2, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2>(this CombinedResult<InnerChannelChannelStorageFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelChannelStorageFactory, T2, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2>(this CombinedResult<T1, InnerChannelChannelStorageFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelChannelStorageFactory, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2>(this CombinedResult<T1, T2, InnerChannelChannelStorageFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelChannelStorageFactory, T1, T2, T3, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2, T3>(this CombinedResult<InnerChannelChannelStorageFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelChannelStorageFactory, T2, T3, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2, T3>(this CombinedResult<T1, InnerChannelChannelStorageFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelChannelStorageFactory, T3, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelChannelStorageFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelChannelStorageFactory, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelChannelStorageFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelChannelStorageFactory, T1, T2, T3, T4, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2, T3, T4>(this CombinedResult<InnerChannelChannelStorageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelChannelStorageFactory, T2, T3, T4, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelChannelStorageFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelChannelStorageFactory, T3, T4, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelChannelStorageFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelChannelStorageFactory, T4, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelChannelStorageFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelChannelStorageFactory, InnerChannelCustomerManagedS3Factory> WithCustomerManagedS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelChannelStorageFactory> combinedResult, Action<Humidifier.IoTAnalytics.ChannelTypes.CustomerManagedS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomerManagedS3(combinedResult.T5, subFactoryAction));
}
