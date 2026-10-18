// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketInventoryTableConfigurationFactory(Action<Humidifier.S3.BucketTypes.InventoryTableConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.InventoryTableConfiguration>
{

    internal InnerBucketMetadataTableEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.InventoryTableConfiguration Create()
    {
        var inventoryTableConfigurationResult = CreateInventoryTableConfiguration();
        factoryAction?.Invoke(inventoryTableConfigurationResult);

        return inventoryTableConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.InventoryTableConfiguration CreateInventoryTableConfiguration()
    {
        var inventoryTableConfigurationResult = new Humidifier.S3.BucketTypes.InventoryTableConfiguration();

        return inventoryTableConfigurationResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.InventoryTableConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerBucketInventoryTableConfigurationFactoryExtensions
{
    public static CombinedResult<InnerBucketInventoryTableConfigurationFactory, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration(this InnerBucketInventoryTableConfigurationFactory parentFactory, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerBucketMetadataTableEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<InnerBucketInventoryTableConfigurationFactory, T1, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<InnerBucketInventoryTableConfigurationFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketInventoryTableConfigurationFactory, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, InnerBucketInventoryTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBucketInventoryTableConfigurationFactory, T1, T2, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<InnerBucketInventoryTableConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketInventoryTableConfigurationFactory, T2, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, InnerBucketInventoryTableConfigurationFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketInventoryTableConfigurationFactory, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerBucketInventoryTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBucketInventoryTableConfigurationFactory, T1, T2, T3, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<InnerBucketInventoryTableConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketInventoryTableConfigurationFactory, T2, T3, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerBucketInventoryTableConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketInventoryTableConfigurationFactory, T3, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketInventoryTableConfigurationFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBucketInventoryTableConfigurationFactory, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketInventoryTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBucketInventoryTableConfigurationFactory, T1, T2, T3, T4, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerBucketInventoryTableConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketInventoryTableConfigurationFactory, T2, T3, T4, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketInventoryTableConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketInventoryTableConfigurationFactory, T3, T4, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketInventoryTableConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBucketInventoryTableConfigurationFactory, T4, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketInventoryTableConfigurationFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBucketInventoryTableConfigurationFactory, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketInventoryTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
