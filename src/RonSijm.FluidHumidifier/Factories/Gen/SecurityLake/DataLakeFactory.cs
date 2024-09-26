// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class DataLakeFactory(string resourceName = null, Action<Humidifier.SecurityLake.DataLake> factoryAction = null) : ResourceFactory<Humidifier.SecurityLake.DataLake>(resourceName)
{

    internal InnerDataLakeEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    internal InnerDataLakeLifecycleConfigurationFactory LifecycleConfigurationFactory { get; set; }

    internal InnerDataLakeReplicationConfigurationFactory ReplicationConfigurationFactory { get; set; }

    protected override Humidifier.SecurityLake.DataLake Create()
    {
        var dataLakeResult = CreateDataLake();
        factoryAction?.Invoke(dataLakeResult);

        return dataLakeResult;
    }

    private Humidifier.SecurityLake.DataLake CreateDataLake()
    {
        var dataLakeResult = new Humidifier.SecurityLake.DataLake
        {
            GivenName = InputResourceName,
        };

        return dataLakeResult;
    }
    public override void CreateChildren(Humidifier.SecurityLake.DataLake result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
        result.LifecycleConfiguration ??= LifecycleConfigurationFactory?.Build();
        result.ReplicationConfiguration ??= ReplicationConfigurationFactory?.Build();
    }

} // End Of Class

public static class DataLakeFactoryExtensions
{
    public static CombinedResult<DataLakeFactory, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration(this DataLakeFactory parentFactory, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerDataLakeEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<DataLakeFactory, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration(this DataLakeFactory parentFactory, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null)
    {
        parentFactory.LifecycleConfigurationFactory = new InnerDataLakeLifecycleConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LifecycleConfigurationFactory);
    }

    public static CombinedResult<DataLakeFactory, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration(this DataLakeFactory parentFactory, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null)
    {
        parentFactory.ReplicationConfigurationFactory = new InnerDataLakeReplicationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReplicationConfigurationFactory);
    }

    public static CombinedResult<DataLakeFactory, T1, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<DataLakeFactory, T1> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, T2, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<DataLakeFactory, T1, T2> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, T2, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, DataLakeFactory, T2> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataLakeFactory, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, T2, T3, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<DataLakeFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, T2, T3, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, DataLakeFactory, T2, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataLakeFactory, T3, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DataLakeFactory, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataLakeFactory, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, T2, T3, T4, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<DataLakeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, T2, T3, T4, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DataLakeFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataLakeFactory, T3, T4, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataLakeFactory, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataLakeFactory, T4, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataLakeFactory, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataLakeFactory, InnerDataLakeEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1>(this CombinedResult<DataLakeFactory, T1> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1>(this CombinedResult<T1, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, T2, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2>(this CombinedResult<DataLakeFactory, T1, T2> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, T2, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2>(this CombinedResult<T1, DataLakeFactory, T2> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataLakeFactory, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2>(this CombinedResult<T1, T2, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, T2, T3, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<DataLakeFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, T2, T3, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<T1, DataLakeFactory, T2, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataLakeFactory, T3, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DataLakeFactory, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataLakeFactory, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, T2, T3, T4, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<DataLakeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, T2, T3, T4, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DataLakeFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataLakeFactory, T3, T4, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataLakeFactory, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataLakeFactory, T4, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataLakeFactory, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataLakeFactory, InnerDataLakeLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1>(this CombinedResult<DataLakeFactory, T1> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1>(this CombinedResult<T1, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, T2, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2>(this CombinedResult<DataLakeFactory, T1, T2> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, T2, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2>(this CombinedResult<T1, DataLakeFactory, T2> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataLakeFactory, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2>(this CombinedResult<T1, T2, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, T2, T3, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2, T3>(this CombinedResult<DataLakeFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, T2, T3, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2, T3>(this CombinedResult<T1, DataLakeFactory, T2, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataLakeFactory, T3, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DataLakeFactory, T3> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataLakeFactory, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataLakeFactory, T1, T2, T3, T4, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2, T3, T4>(this CombinedResult<DataLakeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataLakeFactory, T2, T3, T4, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DataLakeFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataLakeFactory, T3, T4, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataLakeFactory, T3, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataLakeFactory, T4, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataLakeFactory, T4> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataLakeFactory, InnerDataLakeReplicationConfigurationFactory> WithReplicationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataLakeFactory> combinedResult, Action<Humidifier.SecurityLake.DataLakeTypes.ReplicationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfiguration(combinedResult.T5, subFactoryAction));
}
