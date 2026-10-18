// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class EventBusFactory(string resourceName = null, Action<Humidifier.EventsV2.EventBus> factoryAction = null) : ResourceFactory<Humidifier.EventsV2.EventBus>(resourceName)
{

    internal InnerEventBusEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    internal InnerEventBusStorageConfigurationFactory StorageConfigurationFactory { get; set; }

    protected override Humidifier.EventsV2.EventBus Create()
    {
        var eventBusResult = CreateEventBus();
        factoryAction?.Invoke(eventBusResult);

        return eventBusResult;
    }

    private Humidifier.EventsV2.EventBus CreateEventBus()
    {
        var eventBusResult = new Humidifier.EventsV2.EventBus
        {
            GivenName = InputResourceName,
        };

        return eventBusResult;
    }
    public override void CreateChildren(Humidifier.EventsV2.EventBus result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
        result.StorageConfiguration ??= StorageConfigurationFactory?.Build();
    }

} // End Of Class

public static class EventBusFactoryExtensions
{
    public static CombinedResult<EventBusFactory, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration(this EventBusFactory parentFactory, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerEventBusEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<EventBusFactory, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration(this EventBusFactory parentFactory, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null)
    {
        parentFactory.StorageConfigurationFactory = new InnerEventBusStorageConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageConfigurationFactory);
    }

    public static CombinedResult<EventBusFactory, T1, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<EventBusFactory, T1> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, EventBusFactory> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<EventBusFactory, T1, T2> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, EventBusFactory, T2> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, EventBusFactory> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, T3, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<EventBusFactory, T1, T2, T3> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, T3, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, EventBusFactory, T2, T3> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, T3, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, EventBusFactory, T3> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventBusFactory, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventBusFactory> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, T3, T4, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<EventBusFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, T3, T4, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, EventBusFactory, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, T3, T4, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventBusFactory, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventBusFactory, T4, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventBusFactory, T4> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EventBusFactory, InnerEventBusEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventBusFactory> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1>(this CombinedResult<EventBusFactory, T1> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1>(this CombinedResult<T1, EventBusFactory> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2>(this CombinedResult<EventBusFactory, T1, T2> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2>(this CombinedResult<T1, EventBusFactory, T2> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2>(this CombinedResult<T1, T2, EventBusFactory> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, T3, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3>(this CombinedResult<EventBusFactory, T1, T2, T3> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, T3, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, EventBusFactory, T2, T3> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, T3, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, EventBusFactory, T3> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventBusFactory, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventBusFactory> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, T3, T4, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<EventBusFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, T3, T4, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, EventBusFactory, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, T3, T4, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventBusFactory, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventBusFactory, T4, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventBusFactory, T4> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EventBusFactory, InnerEventBusStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventBusFactory> combinedResult, Action<Humidifier.EventsV2.EventBusTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T5, subFactoryAction).T2);
}
