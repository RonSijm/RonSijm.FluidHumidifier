// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Vectors;

public class IndexFactory(string resourceName = null, Action<Humidifier.S3Vectors.Index> factoryAction = null) : ResourceFactory<Humidifier.S3Vectors.Index>(resourceName)
{

    internal InnerIndexEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    internal InnerIndexMetadataConfigurationFactory MetadataConfigurationFactory { get; set; }

    protected override Humidifier.S3Vectors.Index Create()
    {
        var indexResult = CreateIndex();
        factoryAction?.Invoke(indexResult);

        return indexResult;
    }

    private Humidifier.S3Vectors.Index CreateIndex()
    {
        var indexResult = new Humidifier.S3Vectors.Index
        {
            GivenName = InputResourceName,
        };

        return indexResult;
    }
    public override void CreateChildren(Humidifier.S3Vectors.Index result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
        result.MetadataConfiguration ??= MetadataConfigurationFactory?.Build();
    }

} // End Of Class

public static class IndexFactoryExtensions
{
    public static CombinedResult<IndexFactory, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration(this IndexFactory parentFactory, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerIndexEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<IndexFactory, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration(this IndexFactory parentFactory, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null)
    {
        parentFactory.MetadataConfigurationFactory = new InnerIndexMetadataConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetadataConfigurationFactory);
    }

    public static CombinedResult<IndexFactory, T1, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<IndexFactory, T1> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, IndexFactory> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<IndexFactory, T1, T2> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, IndexFactory, T2> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, IndexFactory> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, T3, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<IndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, T3, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, IndexFactory, T2, T3> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, T3, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, IndexFactory, T3> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IndexFactory, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, IndexFactory> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, T3, T4, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<IndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, T3, T4, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, IndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, T3, T4, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, IndexFactory, T3, T4> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IndexFactory, T4, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IndexFactory, T4> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IndexFactory, InnerIndexEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IndexFactory> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1>(this CombinedResult<IndexFactory, T1> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1>(this CombinedResult<T1, IndexFactory> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2>(this CombinedResult<IndexFactory, T1, T2> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2>(this CombinedResult<T1, IndexFactory, T2> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2>(this CombinedResult<T1, T2, IndexFactory> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, T3, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<IndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, T3, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<T1, IndexFactory, T2, T3> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, T3, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, IndexFactory, T3> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IndexFactory, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, IndexFactory> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IndexFactory, T1, T2, T3, T4, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<IndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IndexFactory, T2, T3, T4, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, IndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IndexFactory, T3, T4, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, IndexFactory, T3, T4> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IndexFactory, T4, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IndexFactory, T4> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IndexFactory, InnerIndexMetadataConfigurationFactory> WithMetadataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IndexFactory> combinedResult, Action<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataConfiguration(combinedResult.T5, subFactoryAction).T2);
}
