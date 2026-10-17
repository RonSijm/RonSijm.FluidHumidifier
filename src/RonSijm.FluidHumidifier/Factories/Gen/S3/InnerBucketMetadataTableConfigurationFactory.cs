// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketMetadataTableConfigurationFactory(Action<Humidifier.S3.BucketTypes.MetadataTableConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.MetadataTableConfiguration>
{

    internal InnerBucketS3TablesDestinationFactory S3TablesDestinationFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.MetadataTableConfiguration Create()
    {
        var metadataTableConfigurationResult = CreateMetadataTableConfiguration();
        factoryAction?.Invoke(metadataTableConfigurationResult);

        return metadataTableConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.MetadataTableConfiguration CreateMetadataTableConfiguration()
    {
        var metadataTableConfigurationResult = new Humidifier.S3.BucketTypes.MetadataTableConfiguration();

        return metadataTableConfigurationResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.MetadataTableConfiguration result)
    {
        base.CreateChildren(result);

        result.S3TablesDestination ??= S3TablesDestinationFactory?.Build();
    }

} // End Of Class

public static class InnerBucketMetadataTableConfigurationFactoryExtensions
{
    public static CombinedResult<InnerBucketMetadataTableConfigurationFactory, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination(this InnerBucketMetadataTableConfigurationFactory parentFactory, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null)
    {
        parentFactory.S3TablesDestinationFactory = new InnerBucketS3TablesDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3TablesDestinationFactory);
    }

    public static CombinedResult<InnerBucketMetadataTableConfigurationFactory, T1, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1>(this CombinedResult<InnerBucketMetadataTableConfigurationFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketMetadataTableConfigurationFactory, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1>(this CombinedResult<T1, InnerBucketMetadataTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBucketMetadataTableConfigurationFactory, T1, T2, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2>(this CombinedResult<InnerBucketMetadataTableConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketMetadataTableConfigurationFactory, T2, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2>(this CombinedResult<T1, InnerBucketMetadataTableConfigurationFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketMetadataTableConfigurationFactory, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2>(this CombinedResult<T1, T2, InnerBucketMetadataTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBucketMetadataTableConfigurationFactory, T1, T2, T3, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2, T3>(this CombinedResult<InnerBucketMetadataTableConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketMetadataTableConfigurationFactory, T2, T3, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2, T3>(this CombinedResult<T1, InnerBucketMetadataTableConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketMetadataTableConfigurationFactory, T3, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketMetadataTableConfigurationFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBucketMetadataTableConfigurationFactory, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketMetadataTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBucketMetadataTableConfigurationFactory, T1, T2, T3, T4, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2, T3, T4>(this CombinedResult<InnerBucketMetadataTableConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketMetadataTableConfigurationFactory, T2, T3, T4, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketMetadataTableConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketMetadataTableConfigurationFactory, T3, T4, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketMetadataTableConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBucketMetadataTableConfigurationFactory, T4, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketMetadataTableConfigurationFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBucketMetadataTableConfigurationFactory, InnerBucketS3TablesDestinationFactory> WithS3TablesDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketMetadataTableConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.S3TablesDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3TablesDestination(combinedResult.T5, subFactoryAction).T2);
}
