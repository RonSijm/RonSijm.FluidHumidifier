// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketAnnotationTableConfigurationFactory(Action<Humidifier.S3.BucketTypes.AnnotationTableConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.AnnotationTableConfiguration>
{

    internal InnerBucketMetadataTableEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.AnnotationTableConfiguration Create()
    {
        var annotationTableConfigurationResult = CreateAnnotationTableConfiguration();
        factoryAction?.Invoke(annotationTableConfigurationResult);

        return annotationTableConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.AnnotationTableConfiguration CreateAnnotationTableConfiguration()
    {
        var annotationTableConfigurationResult = new Humidifier.S3.BucketTypes.AnnotationTableConfiguration();

        return annotationTableConfigurationResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.AnnotationTableConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerBucketAnnotationTableConfigurationFactoryExtensions
{
    public static CombinedResult<InnerBucketAnnotationTableConfigurationFactory, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration(this InnerBucketAnnotationTableConfigurationFactory parentFactory, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerBucketMetadataTableEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<InnerBucketAnnotationTableConfigurationFactory, T1, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<InnerBucketAnnotationTableConfigurationFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketAnnotationTableConfigurationFactory, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, InnerBucketAnnotationTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBucketAnnotationTableConfigurationFactory, T1, T2, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<InnerBucketAnnotationTableConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketAnnotationTableConfigurationFactory, T2, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, InnerBucketAnnotationTableConfigurationFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketAnnotationTableConfigurationFactory, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerBucketAnnotationTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBucketAnnotationTableConfigurationFactory, T1, T2, T3, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<InnerBucketAnnotationTableConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketAnnotationTableConfigurationFactory, T2, T3, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerBucketAnnotationTableConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketAnnotationTableConfigurationFactory, T3, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketAnnotationTableConfigurationFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBucketAnnotationTableConfigurationFactory, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketAnnotationTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBucketAnnotationTableConfigurationFactory, T1, T2, T3, T4, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerBucketAnnotationTableConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketAnnotationTableConfigurationFactory, T2, T3, T4, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketAnnotationTableConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketAnnotationTableConfigurationFactory, T3, T4, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketAnnotationTableConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBucketAnnotationTableConfigurationFactory, T4, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketAnnotationTableConfigurationFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBucketAnnotationTableConfigurationFactory, InnerBucketMetadataTableEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketAnnotationTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
