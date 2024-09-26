// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class QueueFactory(string resourceName = null, Action<Humidifier.Deadline.Queue> factoryAction = null) : ResourceFactory<Humidifier.Deadline.Queue>(resourceName)
{

    internal InnerQueueJobRunAsUserFactory JobRunAsUserFactory { get; set; }

    internal InnerQueueJobAttachmentSettingsFactory JobAttachmentSettingsFactory { get; set; }

    protected override Humidifier.Deadline.Queue Create()
    {
        var queueResult = CreateQueue();
        factoryAction?.Invoke(queueResult);

        return queueResult;
    }

    private Humidifier.Deadline.Queue CreateQueue()
    {
        var queueResult = new Humidifier.Deadline.Queue
        {
            GivenName = InputResourceName,
        };

        return queueResult;
    }
    public override void CreateChildren(Humidifier.Deadline.Queue result)
    {
        base.CreateChildren(result);

        result.JobRunAsUser ??= JobRunAsUserFactory?.Build();
        result.JobAttachmentSettings ??= JobAttachmentSettingsFactory?.Build();
    }

} // End Of Class

public static class QueueFactoryExtensions
{
    public static CombinedResult<QueueFactory, InnerQueueJobRunAsUserFactory> WithJobRunAsUser(this QueueFactory parentFactory, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null)
    {
        parentFactory.JobRunAsUserFactory = new InnerQueueJobRunAsUserFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobRunAsUserFactory);
    }

    public static CombinedResult<QueueFactory, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings(this QueueFactory parentFactory, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null)
    {
        parentFactory.JobAttachmentSettingsFactory = new InnerQueueJobAttachmentSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobAttachmentSettingsFactory);
    }

    public static CombinedResult<QueueFactory, T1, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1>(this CombinedResult<QueueFactory, T1> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1>(this CombinedResult<T1, QueueFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2>(this CombinedResult<QueueFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2>(this CombinedResult<T1, QueueFactory, T2> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2>(this CombinedResult<T1, T2, QueueFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T3, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, T3, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2, T3>(this CombinedResult<QueueFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, T3, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2, T3>(this CombinedResult<T1, QueueFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, T3, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2, T3>(this CombinedResult<T1, T2, QueueFactory, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, QueueFactory, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2, T3>(this CombinedResult<T1, T2, T3, QueueFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T4, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, T3, T4, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2, T3, T4>(this CombinedResult<QueueFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, T3, T4, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2, T3, T4>(this CombinedResult<T1, QueueFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, T3, T4, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, QueueFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, QueueFactory, T4, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QueueFactory, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, QueueFactory, InnerQueueJobRunAsUserFactory> WithJobRunAsUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QueueFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobRunAsUser(combinedResult.T5, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1>(this CombinedResult<QueueFactory, T1> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1>(this CombinedResult<T1, QueueFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2>(this CombinedResult<QueueFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2>(this CombinedResult<T1, QueueFactory, T2> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2>(this CombinedResult<T1, T2, QueueFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, T3, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2, T3>(this CombinedResult<QueueFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, T3, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2, T3>(this CombinedResult<T1, QueueFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, T3, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2, T3>(this CombinedResult<T1, T2, QueueFactory, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, QueueFactory, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, QueueFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, T3, T4, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2, T3, T4>(this CombinedResult<QueueFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, T3, T4, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2, T3, T4>(this CombinedResult<T1, QueueFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, T3, T4, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, QueueFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, QueueFactory, T4, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QueueFactory, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, QueueFactory, InnerQueueJobAttachmentSettingsFactory> WithJobAttachmentSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QueueFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.JobAttachmentSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobAttachmentSettings(combinedResult.T5, subFactoryAction));
}
