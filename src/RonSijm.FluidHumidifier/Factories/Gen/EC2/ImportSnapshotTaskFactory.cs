// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ImportSnapshotTaskFactory(string resourceName = null, Action<Humidifier.EC2.ImportSnapshotTask> factoryAction = null) : ResourceFactory<Humidifier.EC2.ImportSnapshotTask>(resourceName)
{

    internal InnerImportSnapshotTaskUserBucketFactory UserBucketFactory { get; set; }

    protected override Humidifier.EC2.ImportSnapshotTask Create()
    {
        var importSnapshotTaskResult = CreateImportSnapshotTask();
        factoryAction?.Invoke(importSnapshotTaskResult);

        return importSnapshotTaskResult;
    }

    private Humidifier.EC2.ImportSnapshotTask CreateImportSnapshotTask()
    {
        var importSnapshotTaskResult = new Humidifier.EC2.ImportSnapshotTask
        {
            GivenName = InputResourceName,
        };

        return importSnapshotTaskResult;
    }
    public override void CreateChildren(Humidifier.EC2.ImportSnapshotTask result)
    {
        base.CreateChildren(result);

        result.UserBucket ??= UserBucketFactory?.Build();
    }

} // End Of Class

public static class ImportSnapshotTaskFactoryExtensions
{
    public static CombinedResult<ImportSnapshotTaskFactory, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket(this ImportSnapshotTaskFactory parentFactory, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null)
    {
        parentFactory.UserBucketFactory = new InnerImportSnapshotTaskUserBucketFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UserBucketFactory);
    }

    public static CombinedResult<ImportSnapshotTaskFactory, T1, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1>(this CombinedResult<ImportSnapshotTaskFactory, T1> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserBucket(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportSnapshotTaskFactory, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1>(this CombinedResult<T1, ImportSnapshotTaskFactory> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserBucket(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ImportSnapshotTaskFactory, T1, T2, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2>(this CombinedResult<ImportSnapshotTaskFactory, T1, T2> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportSnapshotTaskFactory, T2, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2>(this CombinedResult<T1, ImportSnapshotTaskFactory, T2> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportSnapshotTaskFactory, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2>(this CombinedResult<T1, T2, ImportSnapshotTaskFactory> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ImportSnapshotTaskFactory, T1, T2, T3, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2, T3>(this CombinedResult<ImportSnapshotTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportSnapshotTaskFactory, T2, T3, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2, T3>(this CombinedResult<T1, ImportSnapshotTaskFactory, T2, T3> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportSnapshotTaskFactory, T3, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2, T3>(this CombinedResult<T1, T2, ImportSnapshotTaskFactory, T3> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ImportSnapshotTaskFactory, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImportSnapshotTaskFactory> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ImportSnapshotTaskFactory, T1, T2, T3, T4, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2, T3, T4>(this CombinedResult<ImportSnapshotTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportSnapshotTaskFactory, T2, T3, T4, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2, T3, T4>(this CombinedResult<T1, ImportSnapshotTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportSnapshotTaskFactory, T3, T4, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImportSnapshotTaskFactory, T3, T4> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ImportSnapshotTaskFactory, T4, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImportSnapshotTaskFactory, T4> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ImportSnapshotTaskFactory, InnerImportSnapshotTaskUserBucketFactory> WithUserBucket<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImportSnapshotTaskFactory> combinedResult, Action<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserBucket(combinedResult.T5, subFactoryAction).T2);
}
