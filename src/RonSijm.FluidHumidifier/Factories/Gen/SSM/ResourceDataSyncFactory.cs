// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class ResourceDataSyncFactory(string resourceName = null, Action<Humidifier.SSM.ResourceDataSync> factoryAction = null) : ResourceFactory<Humidifier.SSM.ResourceDataSync>(resourceName)
{

    internal InnerResourceDataSyncS3DestinationFactory S3DestinationFactory { get; set; }

    internal InnerResourceDataSyncSyncSourceFactory SyncSourceFactory { get; set; }

    protected override Humidifier.SSM.ResourceDataSync Create()
    {
        var resourceDataSyncResult = CreateResourceDataSync();
        factoryAction?.Invoke(resourceDataSyncResult);

        return resourceDataSyncResult;
    }

    private Humidifier.SSM.ResourceDataSync CreateResourceDataSync()
    {
        var resourceDataSyncResult = new Humidifier.SSM.ResourceDataSync
        {
            GivenName = InputResourceName,
        };

        return resourceDataSyncResult;
    }
    public override void CreateChildren(Humidifier.SSM.ResourceDataSync result)
    {
        base.CreateChildren(result);

        result.S3Destination ??= S3DestinationFactory?.Build();
        result.SyncSource ??= SyncSourceFactory?.Build();
    }

} // End Of Class

public static class ResourceDataSyncFactoryExtensions
{
    public static CombinedResult<ResourceDataSyncFactory, InnerResourceDataSyncS3DestinationFactory> WithS3Destination(this ResourceDataSyncFactory parentFactory, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null)
    {
        parentFactory.S3DestinationFactory = new InnerResourceDataSyncS3DestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DestinationFactory);
    }

    public static CombinedResult<ResourceDataSyncFactory, InnerResourceDataSyncSyncSourceFactory> WithSyncSource(this ResourceDataSyncFactory parentFactory, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null)
    {
        parentFactory.SyncSourceFactory = new InnerResourceDataSyncSyncSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SyncSourceFactory);
    }

    public static CombinedResult<ResourceDataSyncFactory, T1, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1>(this CombinedResult<ResourceDataSyncFactory, T1> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDataSyncFactory, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1>(this CombinedResult<T1, ResourceDataSyncFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResourceDataSyncFactory, T1, T2, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<ResourceDataSyncFactory, T1, T2> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDataSyncFactory, T2, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, ResourceDataSyncFactory, T2> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDataSyncFactory, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2>(this CombinedResult<T1, T2, ResourceDataSyncFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResourceDataSyncFactory, T1, T2, T3, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<ResourceDataSyncFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDataSyncFactory, T2, T3, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, ResourceDataSyncFactory, T2, T3> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDataSyncFactory, T3, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, ResourceDataSyncFactory, T3> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceDataSyncFactory, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceDataSyncFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResourceDataSyncFactory, T1, T2, T3, T4, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<ResourceDataSyncFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDataSyncFactory, T2, T3, T4, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, ResourceDataSyncFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDataSyncFactory, T3, T4, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceDataSyncFactory, T3, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceDataSyncFactory, T4, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceDataSyncFactory, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResourceDataSyncFactory, InnerResourceDataSyncS3DestinationFactory> WithS3Destination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceDataSyncFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.S3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Destination(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ResourceDataSyncFactory, T1, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1>(this CombinedResult<ResourceDataSyncFactory, T1> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSyncSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDataSyncFactory, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1>(this CombinedResult<T1, ResourceDataSyncFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSyncSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResourceDataSyncFactory, T1, T2, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2>(this CombinedResult<ResourceDataSyncFactory, T1, T2> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDataSyncFactory, T2, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2>(this CombinedResult<T1, ResourceDataSyncFactory, T2> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDataSyncFactory, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2>(this CombinedResult<T1, T2, ResourceDataSyncFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResourceDataSyncFactory, T1, T2, T3, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2, T3>(this CombinedResult<ResourceDataSyncFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDataSyncFactory, T2, T3, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2, T3>(this CombinedResult<T1, ResourceDataSyncFactory, T2, T3> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDataSyncFactory, T3, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2, T3>(this CombinedResult<T1, T2, ResourceDataSyncFactory, T3> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceDataSyncFactory, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceDataSyncFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResourceDataSyncFactory, T1, T2, T3, T4, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2, T3, T4>(this CombinedResult<ResourceDataSyncFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDataSyncFactory, T2, T3, T4, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2, T3, T4>(this CombinedResult<T1, ResourceDataSyncFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDataSyncFactory, T3, T4, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceDataSyncFactory, T3, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceDataSyncFactory, T4, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceDataSyncFactory, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResourceDataSyncFactory, InnerResourceDataSyncSyncSourceFactory> WithSyncSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceDataSyncFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSyncSource(combinedResult.T5, subFactoryAction));
}
