// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskOverridesFactory(Action<Humidifier.DataSync.TaskTypes.Overrides> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.Overrides>
{

    internal InnerTaskVerifiedFactory VerifiedFactory { get; set; }

    internal InnerTaskSkippedFactory SkippedFactory { get; set; }

    internal InnerTaskTransferredFactory TransferredFactory { get; set; }

    internal InnerTaskDeletedFactory DeletedFactory { get; set; }

    protected override Humidifier.DataSync.TaskTypes.Overrides Create()
    {
        var overridesResult = CreateOverrides();
        factoryAction?.Invoke(overridesResult);

        return overridesResult;
    }

    private Humidifier.DataSync.TaskTypes.Overrides CreateOverrides()
    {
        var overridesResult = new Humidifier.DataSync.TaskTypes.Overrides();

        return overridesResult;
    }
    public override void CreateChildren(Humidifier.DataSync.TaskTypes.Overrides result)
    {
        base.CreateChildren(result);

        result.Verified ??= VerifiedFactory?.Build();
        result.Skipped ??= SkippedFactory?.Build();
        result.Transferred ??= TransferredFactory?.Build();
        result.Deleted ??= DeletedFactory?.Build();
    }

} // End Of Class

public static class InnerTaskOverridesFactoryExtensions
{
    public static CombinedResult<InnerTaskOverridesFactory, InnerTaskVerifiedFactory> WithVerified(this InnerTaskOverridesFactory parentFactory, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null)
    {
        parentFactory.VerifiedFactory = new InnerTaskVerifiedFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VerifiedFactory);
    }

    public static CombinedResult<InnerTaskOverridesFactory, InnerTaskSkippedFactory> WithSkipped(this InnerTaskOverridesFactory parentFactory, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null)
    {
        parentFactory.SkippedFactory = new InnerTaskSkippedFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SkippedFactory);
    }

    public static CombinedResult<InnerTaskOverridesFactory, InnerTaskTransferredFactory> WithTransferred(this InnerTaskOverridesFactory parentFactory, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null)
    {
        parentFactory.TransferredFactory = new InnerTaskTransferredFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TransferredFactory);
    }

    public static CombinedResult<InnerTaskOverridesFactory, InnerTaskDeletedFactory> WithDeleted(this InnerTaskOverridesFactory parentFactory, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null)
    {
        parentFactory.DeletedFactory = new InnerTaskDeletedFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeletedFactory);
    }

    public static CombinedResult<InnerTaskOverridesFactory, T1, InnerTaskVerifiedFactory> WithVerified<T1>(this CombinedResult<InnerTaskOverridesFactory, T1> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, WithVerified(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, InnerTaskVerifiedFactory> WithVerified<T1>(this CombinedResult<T1, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, WithVerified(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, InnerTaskVerifiedFactory> WithVerified<T1, T2>(this CombinedResult<InnerTaskOverridesFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, InnerTaskVerifiedFactory> WithVerified<T1, T2>(this CombinedResult<T1, InnerTaskOverridesFactory, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, InnerTaskVerifiedFactory> WithVerified<T1, T2>(this CombinedResult<T1, T2, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, InnerTaskVerifiedFactory> WithVerified<T1, T2, T3>(this CombinedResult<InnerTaskOverridesFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, InnerTaskVerifiedFactory> WithVerified<T1, T2, T3>(this CombinedResult<T1, InnerTaskOverridesFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, InnerTaskVerifiedFactory> WithVerified<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskOverridesFactory, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, InnerTaskVerifiedFactory> WithVerified<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, T4, InnerTaskVerifiedFactory> WithVerified<T1, T2, T3, T4>(this CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, T4, InnerTaskVerifiedFactory> WithVerified<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, T4, InnerTaskVerifiedFactory> WithVerified<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, T4, InnerTaskVerifiedFactory> WithVerified<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskOverridesFactory, InnerTaskVerifiedFactory> WithVerified<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Verified> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerified(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, InnerTaskSkippedFactory> WithSkipped<T1>(this CombinedResult<InnerTaskOverridesFactory, T1> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, WithSkipped(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, InnerTaskSkippedFactory> WithSkipped<T1>(this CombinedResult<T1, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, WithSkipped(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, InnerTaskSkippedFactory> WithSkipped<T1, T2>(this CombinedResult<InnerTaskOverridesFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, InnerTaskSkippedFactory> WithSkipped<T1, T2>(this CombinedResult<T1, InnerTaskOverridesFactory, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, InnerTaskSkippedFactory> WithSkipped<T1, T2>(this CombinedResult<T1, T2, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, InnerTaskSkippedFactory> WithSkipped<T1, T2, T3>(this CombinedResult<InnerTaskOverridesFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, InnerTaskSkippedFactory> WithSkipped<T1, T2, T3>(this CombinedResult<T1, InnerTaskOverridesFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, InnerTaskSkippedFactory> WithSkipped<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskOverridesFactory, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, InnerTaskSkippedFactory> WithSkipped<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, T4, InnerTaskSkippedFactory> WithSkipped<T1, T2, T3, T4>(this CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, T4, InnerTaskSkippedFactory> WithSkipped<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, T4, InnerTaskSkippedFactory> WithSkipped<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, T4, InnerTaskSkippedFactory> WithSkipped<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskOverridesFactory, InnerTaskSkippedFactory> WithSkipped<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Skipped> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkipped(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, InnerTaskTransferredFactory> WithTransferred<T1>(this CombinedResult<InnerTaskOverridesFactory, T1> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransferred(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, InnerTaskTransferredFactory> WithTransferred<T1>(this CombinedResult<T1, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransferred(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, InnerTaskTransferredFactory> WithTransferred<T1, T2>(this CombinedResult<InnerTaskOverridesFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, InnerTaskTransferredFactory> WithTransferred<T1, T2>(this CombinedResult<T1, InnerTaskOverridesFactory, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, InnerTaskTransferredFactory> WithTransferred<T1, T2>(this CombinedResult<T1, T2, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, InnerTaskTransferredFactory> WithTransferred<T1, T2, T3>(this CombinedResult<InnerTaskOverridesFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, InnerTaskTransferredFactory> WithTransferred<T1, T2, T3>(this CombinedResult<T1, InnerTaskOverridesFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, InnerTaskTransferredFactory> WithTransferred<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskOverridesFactory, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, InnerTaskTransferredFactory> WithTransferred<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, T4, InnerTaskTransferredFactory> WithTransferred<T1, T2, T3, T4>(this CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, T4, InnerTaskTransferredFactory> WithTransferred<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, T4, InnerTaskTransferredFactory> WithTransferred<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, T4, InnerTaskTransferredFactory> WithTransferred<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskOverridesFactory, InnerTaskTransferredFactory> WithTransferred<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Transferred> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransferred(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, InnerTaskDeletedFactory> WithDeleted<T1>(this CombinedResult<InnerTaskOverridesFactory, T1> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeleted(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, InnerTaskDeletedFactory> WithDeleted<T1>(this CombinedResult<T1, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeleted(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, InnerTaskDeletedFactory> WithDeleted<T1, T2>(this CombinedResult<InnerTaskOverridesFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, InnerTaskDeletedFactory> WithDeleted<T1, T2>(this CombinedResult<T1, InnerTaskOverridesFactory, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, InnerTaskDeletedFactory> WithDeleted<T1, T2>(this CombinedResult<T1, T2, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, InnerTaskDeletedFactory> WithDeleted<T1, T2, T3>(this CombinedResult<InnerTaskOverridesFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, InnerTaskDeletedFactory> WithDeleted<T1, T2, T3>(this CombinedResult<T1, InnerTaskOverridesFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, InnerTaskDeletedFactory> WithDeleted<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskOverridesFactory, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, InnerTaskDeletedFactory> WithDeleted<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, T4, InnerTaskDeletedFactory> WithDeleted<T1, T2, T3, T4>(this CombinedResult<InnerTaskOverridesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, T4, InnerTaskDeletedFactory> WithDeleted<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskOverridesFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, T4, InnerTaskDeletedFactory> WithDeleted<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskOverridesFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, T4, InnerTaskDeletedFactory> WithDeleted<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskOverridesFactory, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskOverridesFactory, InnerTaskDeletedFactory> WithDeleted<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskOverridesFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Deleted> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeleted(combinedResult.T5, subFactoryAction));
}
