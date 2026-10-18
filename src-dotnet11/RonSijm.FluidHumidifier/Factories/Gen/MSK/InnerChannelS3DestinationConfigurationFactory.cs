// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelS3DestinationConfigurationFactory(Action<Humidifier.MSK.ChannelTypes.S3DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.S3DestinationConfiguration>
{

    internal InnerChannelS3StorageFactory StorageFactory { get; set; }

    internal InnerChannelDeadLetterQueueS3Factory DeadLetterQueueS3Factory { get; set; }

    protected override Humidifier.MSK.ChannelTypes.S3DestinationConfiguration Create()
    {
        var s3DestinationConfigurationResult = CreateS3DestinationConfiguration();
        factoryAction?.Invoke(s3DestinationConfigurationResult);

        return s3DestinationConfigurationResult;
    }

    private Humidifier.MSK.ChannelTypes.S3DestinationConfiguration CreateS3DestinationConfiguration()
    {
        var s3DestinationConfigurationResult = new Humidifier.MSK.ChannelTypes.S3DestinationConfiguration();

        return s3DestinationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MSK.ChannelTypes.S3DestinationConfiguration result)
    {
        base.CreateChildren(result);

        result.Storage ??= StorageFactory?.Build();
        result.DeadLetterQueueS3 ??= DeadLetterQueueS3Factory?.Build();
    }

} // End Of Class

public static class InnerChannelS3DestinationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerChannelS3DestinationConfigurationFactory, InnerChannelS3StorageFactory> WithStorage(this InnerChannelS3DestinationConfigurationFactory parentFactory, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null)
    {
        parentFactory.StorageFactory = new InnerChannelS3StorageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageFactory);
    }

    public static CombinedResult<InnerChannelS3DestinationConfigurationFactory, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3(this InnerChannelS3DestinationConfigurationFactory parentFactory, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null)
    {
        parentFactory.DeadLetterQueueS3Factory = new InnerChannelDeadLetterQueueS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeadLetterQueueS3Factory);
    }

    public static CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, InnerChannelS3StorageFactory> WithStorage<T1>(this CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, InnerChannelS3StorageFactory> WithStorage<T1>(this CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2, InnerChannelS3StorageFactory> WithStorage<T1, T2>(this CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2, InnerChannelS3StorageFactory> WithStorage<T1, T2>(this CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory, InnerChannelS3StorageFactory> WithStorage<T1, T2>(this CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2, T3, InnerChannelS3StorageFactory> WithStorage<T1, T2, T3>(this CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2, T3, InnerChannelS3StorageFactory> WithStorage<T1, T2, T3>(this CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory, T3, InnerChannelS3StorageFactory> WithStorage<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelS3DestinationConfigurationFactory, InnerChannelS3StorageFactory> WithStorage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2, T3, T4, InnerChannelS3StorageFactory> WithStorage<T1, T2, T3, T4>(this CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2, T3, T4, InnerChannelS3StorageFactory> WithStorage<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory, T3, T4, InnerChannelS3StorageFactory> WithStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelS3DestinationConfigurationFactory, T4, InnerChannelS3StorageFactory> WithStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelS3DestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelS3DestinationConfigurationFactory, InnerChannelS3StorageFactory> WithStorage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.S3Storage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorage(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1>(this CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1>(this CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2>(this CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2>(this CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2>(this CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2, T3, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2, T3>(this CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2, T3, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2, T3>(this CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory, T3, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelS3DestinationConfigurationFactory, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2, T3, T4, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2, T3, T4>(this CombinedResult<InnerChannelS3DestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2, T3, T4, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelS3DestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory, T3, T4, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelS3DestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelS3DestinationConfigurationFactory, T4, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelS3DestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelS3DestinationConfigurationFactory, InnerChannelDeadLetterQueueS3Factory> WithDeadLetterQueueS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelS3DestinationConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterQueueS3(combinedResult.T5, subFactoryAction).T2);
}
