// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerIngestionDestinationDestinationFactory(Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.IngestionDestinationTypes.Destination>
{

    internal InnerIngestionDestinationS3BucketFactory S3BucketFactory { get; set; }

    internal InnerIngestionDestinationFirehoseStreamFactory FirehoseStreamFactory { get; set; }

    protected override Humidifier.AppFabric.IngestionDestinationTypes.Destination Create()
    {
        var destinationResult = CreateDestination();
        factoryAction?.Invoke(destinationResult);

        return destinationResult;
    }

    private Humidifier.AppFabric.IngestionDestinationTypes.Destination CreateDestination()
    {
        var destinationResult = new Humidifier.AppFabric.IngestionDestinationTypes.Destination();

        return destinationResult;
    }
    public override void CreateChildren(Humidifier.AppFabric.IngestionDestinationTypes.Destination result)
    {
        base.CreateChildren(result);

        result.S3Bucket ??= S3BucketFactory?.Build();
        result.FirehoseStream ??= FirehoseStreamFactory?.Build();
    }

} // End Of Class

public static class InnerIngestionDestinationDestinationFactoryExtensions
{
    public static CombinedResult<InnerIngestionDestinationDestinationFactory, InnerIngestionDestinationS3BucketFactory> WithS3Bucket(this InnerIngestionDestinationDestinationFactory parentFactory, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null)
    {
        parentFactory.S3BucketFactory = new InnerIngestionDestinationS3BucketFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3BucketFactory);
    }

    public static CombinedResult<InnerIngestionDestinationDestinationFactory, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream(this InnerIngestionDestinationDestinationFactory parentFactory, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null)
    {
        parentFactory.FirehoseStreamFactory = new InnerIngestionDestinationFirehoseStreamFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FirehoseStreamFactory);
    }

    public static CombinedResult<InnerIngestionDestinationDestinationFactory, T1, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1>(this CombinedResult<InnerIngestionDestinationDestinationFactory, T1> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Bucket(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationFactory, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1>(this CombinedResult<T1, InnerIngestionDestinationDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Bucket(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2>(this CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2>(this CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2>(this CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2, T3, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2, T3>(this CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2, T3, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2, T3>(this CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory, T3, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2, T3>(this CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationFactory, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2, T3, T4, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2, T3, T4>(this CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2, T3, T4, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2, T3, T4>(this CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory, T3, T4, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationFactory, T4, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationFactory, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIngestionDestinationDestinationFactory, InnerIngestionDestinationS3BucketFactory> WithS3Bucket<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIngestionDestinationDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.S3Bucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Bucket(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationDestinationFactory, T1, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1>(this CombinedResult<InnerIngestionDestinationDestinationFactory, T1> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirehoseStream(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationFactory, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1>(this CombinedResult<T1, InnerIngestionDestinationDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirehoseStream(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2>(this CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2>(this CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2>(this CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2, T3, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2, T3>(this CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2, T3, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2, T3>(this CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory, T3, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2, T3>(this CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationFactory, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2, T3, T4, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2, T3, T4>(this CombinedResult<InnerIngestionDestinationDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2, T3, T4, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2, T3, T4>(this CombinedResult<T1, InnerIngestionDestinationDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory, T3, T4, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIngestionDestinationDestinationFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationFactory, T4, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationFactory, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIngestionDestinationDestinationFactory, InnerIngestionDestinationFirehoseStreamFactory> WithFirehoseStream<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIngestionDestinationDestinationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.FirehoseStream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehoseStream(combinedResult.T5, subFactoryAction).T2);
}
