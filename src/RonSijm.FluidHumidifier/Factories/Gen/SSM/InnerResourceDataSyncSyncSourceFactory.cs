// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerResourceDataSyncSyncSourceFactory(Action<Humidifier.SSM.ResourceDataSyncTypes.SyncSource> factoryAction = null) : SubResourceFactory<Humidifier.SSM.ResourceDataSyncTypes.SyncSource>
{

    internal InnerResourceDataSyncAwsOrganizationsSourceFactory AwsOrganizationsSourceFactory { get; set; }

    protected override Humidifier.SSM.ResourceDataSyncTypes.SyncSource Create()
    {
        var syncSourceResult = CreateSyncSource();
        factoryAction?.Invoke(syncSourceResult);

        return syncSourceResult;
    }

    private Humidifier.SSM.ResourceDataSyncTypes.SyncSource CreateSyncSource()
    {
        var syncSourceResult = new Humidifier.SSM.ResourceDataSyncTypes.SyncSource();

        return syncSourceResult;
    }
    public override void CreateChildren(Humidifier.SSM.ResourceDataSyncTypes.SyncSource result)
    {
        base.CreateChildren(result);

        result.AwsOrganizationsSource ??= AwsOrganizationsSourceFactory?.Build();
    }

} // End Of Class

public static class InnerResourceDataSyncSyncSourceFactoryExtensions
{
    public static CombinedResult<InnerResourceDataSyncSyncSourceFactory, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource(this InnerResourceDataSyncSyncSourceFactory parentFactory, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null)
    {
        parentFactory.AwsOrganizationsSourceFactory = new InnerResourceDataSyncAwsOrganizationsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsOrganizationsSourceFactory);
    }

    public static CombinedResult<InnerResourceDataSyncSyncSourceFactory, T1, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1>(this CombinedResult<InnerResourceDataSyncSyncSourceFactory, T1> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDataSyncSyncSourceFactory, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1>(this CombinedResult<T1, InnerResourceDataSyncSyncSourceFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceDataSyncSyncSourceFactory, T1, T2, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2>(this CombinedResult<InnerResourceDataSyncSyncSourceFactory, T1, T2> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDataSyncSyncSourceFactory, T2, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2>(this CombinedResult<T1, InnerResourceDataSyncSyncSourceFactory, T2> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDataSyncSyncSourceFactory, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2>(this CombinedResult<T1, T2, InnerResourceDataSyncSyncSourceFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceDataSyncSyncSourceFactory, T1, T2, T3, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2, T3>(this CombinedResult<InnerResourceDataSyncSyncSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDataSyncSyncSourceFactory, T2, T3, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2, T3>(this CombinedResult<T1, InnerResourceDataSyncSyncSourceFactory, T2, T3> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDataSyncSyncSourceFactory, T3, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceDataSyncSyncSourceFactory, T3> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDataSyncSyncSourceFactory, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceDataSyncSyncSourceFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceDataSyncSyncSourceFactory, T1, T2, T3, T4, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2, T3, T4>(this CombinedResult<InnerResourceDataSyncSyncSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceDataSyncSyncSourceFactory, T2, T3, T4, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceDataSyncSyncSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceDataSyncSyncSourceFactory, T3, T4, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceDataSyncSyncSourceFactory, T3, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceDataSyncSyncSourceFactory, T4, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceDataSyncSyncSourceFactory, T4> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceDataSyncSyncSourceFactory, InnerResourceDataSyncAwsOrganizationsSourceFactory> WithAwsOrganizationsSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceDataSyncSyncSourceFactory> combinedResult, Action<Humidifier.SSM.ResourceDataSyncTypes.AwsOrganizationsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsOrganizationsSource(combinedResult.T5, subFactoryAction));
}
