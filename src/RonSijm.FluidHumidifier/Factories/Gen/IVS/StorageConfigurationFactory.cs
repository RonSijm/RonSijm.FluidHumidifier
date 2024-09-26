// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class StorageConfigurationFactory(string resourceName = null, Action<Humidifier.IVS.StorageConfiguration> factoryAction = null) : ResourceFactory<Humidifier.IVS.StorageConfiguration>(resourceName)
{

    internal InnerStorageConfigurationS3StorageConfigurationFactory S3Factory { get; set; }

    protected override Humidifier.IVS.StorageConfiguration Create()
    {
        var storageConfigurationResult = CreateStorageConfiguration();
        factoryAction?.Invoke(storageConfigurationResult);

        return storageConfigurationResult;
    }

    private Humidifier.IVS.StorageConfiguration CreateStorageConfiguration()
    {
        var storageConfigurationResult = new Humidifier.IVS.StorageConfiguration
        {
            GivenName = InputResourceName,
        };

        return storageConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVS.StorageConfiguration result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class StorageConfigurationFactoryExtensions
{
    public static CombinedResult<StorageConfigurationFactory, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3(this StorageConfigurationFactory parentFactory, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerStorageConfigurationS3StorageConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<StorageConfigurationFactory, T1, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1>(this CombinedResult<StorageConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageConfigurationFactory, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1>(this CombinedResult<T1, StorageConfigurationFactory> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StorageConfigurationFactory, T1, T2, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2>(this CombinedResult<StorageConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageConfigurationFactory, T2, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, StorageConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageConfigurationFactory, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, StorageConfigurationFactory> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StorageConfigurationFactory, T1, T2, T3, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<StorageConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageConfigurationFactory, T2, T3, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, StorageConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageConfigurationFactory, T3, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, StorageConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageConfigurationFactory, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, StorageConfigurationFactory> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StorageConfigurationFactory, T1, T2, T3, T4, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<StorageConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StorageConfigurationFactory, T2, T3, T4, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, StorageConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StorageConfigurationFactory, T3, T4, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, StorageConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StorageConfigurationFactory, T4, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StorageConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StorageConfigurationFactory, InnerStorageConfigurationS3StorageConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StorageConfigurationFactory> combinedResult, Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
