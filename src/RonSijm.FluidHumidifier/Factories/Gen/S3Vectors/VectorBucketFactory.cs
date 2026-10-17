// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Vectors;

public class VectorBucketFactory(string resourceName = null, Action<Humidifier.S3Vectors.VectorBucket> factoryAction = null) : ResourceFactory<Humidifier.S3Vectors.VectorBucket>(resourceName)
{

    internal InnerVectorBucketEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.S3Vectors.VectorBucket Create()
    {
        var vectorBucketResult = CreateVectorBucket();
        factoryAction?.Invoke(vectorBucketResult);

        return vectorBucketResult;
    }

    private Humidifier.S3Vectors.VectorBucket CreateVectorBucket()
    {
        var vectorBucketResult = new Humidifier.S3Vectors.VectorBucket
        {
            GivenName = InputResourceName,
        };

        return vectorBucketResult;
    }
    public override void CreateChildren(Humidifier.S3Vectors.VectorBucket result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class VectorBucketFactoryExtensions
{
    public static CombinedResult<VectorBucketFactory, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration(this VectorBucketFactory parentFactory, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerVectorBucketEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<VectorBucketFactory, T1, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<VectorBucketFactory, T1> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VectorBucketFactory, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, VectorBucketFactory> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<VectorBucketFactory, T1, T2, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<VectorBucketFactory, T1, T2> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VectorBucketFactory, T2, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, VectorBucketFactory, T2> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VectorBucketFactory, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, VectorBucketFactory> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<VectorBucketFactory, T1, T2, T3, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<VectorBucketFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VectorBucketFactory, T2, T3, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, VectorBucketFactory, T2, T3> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VectorBucketFactory, T3, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, VectorBucketFactory, T3> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VectorBucketFactory, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, VectorBucketFactory> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<VectorBucketFactory, T1, T2, T3, T4, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<VectorBucketFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VectorBucketFactory, T2, T3, T4, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, VectorBucketFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VectorBucketFactory, T3, T4, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, VectorBucketFactory, T3, T4> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VectorBucketFactory, T4, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VectorBucketFactory, T4> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, VectorBucketFactory, InnerVectorBucketEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VectorBucketFactory> combinedResult, Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
