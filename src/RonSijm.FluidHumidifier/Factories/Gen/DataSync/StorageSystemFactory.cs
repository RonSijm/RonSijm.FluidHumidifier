// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class StorageSystemFactory(string resourceName = null, Action<Humidifier.DataSync.StorageSystem> factoryAction = null) : ResourceFactory<Humidifier.DataSync.StorageSystem>(resourceName)
{

    internal InnerStorageSystemServerCredentialsFactory ServerCredentialsFactory { get; set; }

    internal InnerStorageSystemServerConfigurationFactory ServerConfigurationFactory { get; set; }

    protected override Humidifier.DataSync.StorageSystem Create()
    {
        var storageSystemResult = CreateStorageSystem();
        factoryAction?.Invoke(storageSystemResult);

        return storageSystemResult;
    }

    private Humidifier.DataSync.StorageSystem CreateStorageSystem()
    {
        var storageSystemResult = new Humidifier.DataSync.StorageSystem
        {
            GivenName = InputResourceName,
        };

        return storageSystemResult;
    }
    public override void CreateChildren(Humidifier.DataSync.StorageSystem result)
    {
        base.CreateChildren(result);

        result.ServerCredentials ??= ServerCredentialsFactory?.Build();
        result.ServerConfiguration ??= ServerConfigurationFactory?.Build();
    }

} // End Of Class

public static class StorageSystemFactoryExtensions
{
    public static CombinedResult<StorageSystemFactory, InnerStorageSystemServerCredentialsFactory> WithServerCredentials(this StorageSystemFactory parentFactory, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null)
    {
        parentFactory.ServerCredentialsFactory = new InnerStorageSystemServerCredentialsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServerCredentialsFactory);
    }

    public static CombinedResult<StorageSystemFactory, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration(this StorageSystemFactory parentFactory, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null)
    {
        parentFactory.ServerConfigurationFactory = new InnerStorageSystemServerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServerConfigurationFactory);
    }

    public static CombinedResult<StorageSystemFactory, T1, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1>(this CombinedResult<StorageSystemFactory, T1> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageSystemFactory, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1>(this CombinedResult<T1, StorageSystemFactory> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StorageSystemFactory, T1, T2, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2>(this CombinedResult<StorageSystemFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageSystemFactory, T2, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2>(this CombinedResult<T1, StorageSystemFactory, T2> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageSystemFactory, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2>(this CombinedResult<T1, T2, StorageSystemFactory> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StorageSystemFactory, T1, T2, T3, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2, T3>(this CombinedResult<StorageSystemFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageSystemFactory, T2, T3, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2, T3>(this CombinedResult<T1, StorageSystemFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageSystemFactory, T3, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2, T3>(this CombinedResult<T1, T2, StorageSystemFactory, T3> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageSystemFactory, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, StorageSystemFactory> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StorageSystemFactory, T1, T2, T3, T4, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2, T3, T4>(this CombinedResult<StorageSystemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageSystemFactory, T2, T3, T4, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2, T3, T4>(this CombinedResult<T1, StorageSystemFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageSystemFactory, T3, T4, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, StorageSystemFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageSystemFactory, T4, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StorageSystemFactory, T4> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StorageSystemFactory, InnerStorageSystemServerCredentialsFactory> WithServerCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StorageSystemFactory> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerCredentials(combinedResult.T5, subFactoryAction));
    public static CombinedResult<StorageSystemFactory, T1, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1>(this CombinedResult<StorageSystemFactory, T1> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageSystemFactory, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1>(this CombinedResult<T1, StorageSystemFactory> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StorageSystemFactory, T1, T2, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2>(this CombinedResult<StorageSystemFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageSystemFactory, T2, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2>(this CombinedResult<T1, StorageSystemFactory, T2> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageSystemFactory, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2>(this CombinedResult<T1, T2, StorageSystemFactory> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StorageSystemFactory, T1, T2, T3, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2, T3>(this CombinedResult<StorageSystemFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageSystemFactory, T2, T3, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2, T3>(this CombinedResult<T1, StorageSystemFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageSystemFactory, T3, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, StorageSystemFactory, T3> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageSystemFactory, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, StorageSystemFactory> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StorageSystemFactory, T1, T2, T3, T4, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2, T3, T4>(this CombinedResult<StorageSystemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageSystemFactory, T2, T3, T4, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, StorageSystemFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageSystemFactory, T3, T4, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, StorageSystemFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageSystemFactory, T4, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StorageSystemFactory, T4> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StorageSystemFactory, InnerStorageSystemServerConfigurationFactory> WithServerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StorageSystemFactory> combinedResult, Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerConfiguration(combinedResult.T5, subFactoryAction));
}
