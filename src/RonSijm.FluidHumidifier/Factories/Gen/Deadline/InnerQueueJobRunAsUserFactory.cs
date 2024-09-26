// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerQueueJobRunAsUserFactory(Action<Humidifier.Deadline.QueueTypes.JobRunAsUser> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.QueueTypes.JobRunAsUser>
{

    internal InnerQueuePosixUserFactory PosixFactory { get; set; }

    internal InnerQueueWindowsUserFactory WindowsFactory { get; set; }

    protected override Humidifier.Deadline.QueueTypes.JobRunAsUser Create()
    {
        var jobRunAsUserResult = CreateJobRunAsUser();
        factoryAction?.Invoke(jobRunAsUserResult);

        return jobRunAsUserResult;
    }

    private Humidifier.Deadline.QueueTypes.JobRunAsUser CreateJobRunAsUser()
    {
        var jobRunAsUserResult = new Humidifier.Deadline.QueueTypes.JobRunAsUser();

        return jobRunAsUserResult;
    }
    public override void CreateChildren(Humidifier.Deadline.QueueTypes.JobRunAsUser result)
    {
        base.CreateChildren(result);

        result.Posix ??= PosixFactory?.Build();
        result.Windows ??= WindowsFactory?.Build();
    }

} // End Of Class

public static class InnerQueueJobRunAsUserFactoryExtensions
{
    public static CombinedResult<InnerQueueJobRunAsUserFactory, InnerQueuePosixUserFactory> WithPosix(this InnerQueueJobRunAsUserFactory parentFactory, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null)
    {
        parentFactory.PosixFactory = new InnerQueuePosixUserFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PosixFactory);
    }

    public static CombinedResult<InnerQueueJobRunAsUserFactory, InnerQueueWindowsUserFactory> WithWindows(this InnerQueueJobRunAsUserFactory parentFactory, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null)
    {
        parentFactory.WindowsFactory = new InnerQueueWindowsUserFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WindowsFactory);
    }

    public static CombinedResult<InnerQueueJobRunAsUserFactory, T1, InnerQueuePosixUserFactory> WithPosix<T1>(this CombinedResult<InnerQueueJobRunAsUserFactory, T1> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithPosix(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerQueueJobRunAsUserFactory, InnerQueuePosixUserFactory> WithPosix<T1>(this CombinedResult<T1, InnerQueueJobRunAsUserFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithPosix(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2, InnerQueuePosixUserFactory> WithPosix<T1, T2>(this CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2, InnerQueuePosixUserFactory> WithPosix<T1, T2>(this CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory, InnerQueuePosixUserFactory> WithPosix<T1, T2>(this CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2, T3, InnerQueuePosixUserFactory> WithPosix<T1, T2, T3>(this CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2, T3, InnerQueuePosixUserFactory> WithPosix<T1, T2, T3>(this CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory, T3, InnerQueuePosixUserFactory> WithPosix<T1, T2, T3>(this CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerQueueJobRunAsUserFactory, InnerQueuePosixUserFactory> WithPosix<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerQueueJobRunAsUserFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2, T3, T4, InnerQueuePosixUserFactory> WithPosix<T1, T2, T3, T4>(this CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2, T3, T4, InnerQueuePosixUserFactory> WithPosix<T1, T2, T3, T4>(this CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory, T3, T4, InnerQueuePosixUserFactory> WithPosix<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerQueueJobRunAsUserFactory, T4, InnerQueuePosixUserFactory> WithPosix<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerQueueJobRunAsUserFactory, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerQueueJobRunAsUserFactory, InnerQueuePosixUserFactory> WithPosix<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerQueueJobRunAsUserFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.PosixUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosix(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerQueueJobRunAsUserFactory, T1, InnerQueueWindowsUserFactory> WithWindows<T1>(this CombinedResult<InnerQueueJobRunAsUserFactory, T1> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithWindows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerQueueJobRunAsUserFactory, InnerQueueWindowsUserFactory> WithWindows<T1>(this CombinedResult<T1, InnerQueueJobRunAsUserFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, WithWindows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2, InnerQueueWindowsUserFactory> WithWindows<T1, T2>(this CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2, InnerQueueWindowsUserFactory> WithWindows<T1, T2>(this CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory, InnerQueueWindowsUserFactory> WithWindows<T1, T2>(this CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2, T3, InnerQueueWindowsUserFactory> WithWindows<T1, T2, T3>(this CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2, T3, InnerQueueWindowsUserFactory> WithWindows<T1, T2, T3>(this CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory, T3, InnerQueueWindowsUserFactory> WithWindows<T1, T2, T3>(this CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory, T3> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerQueueJobRunAsUserFactory, InnerQueueWindowsUserFactory> WithWindows<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerQueueJobRunAsUserFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2, T3, T4, InnerQueueWindowsUserFactory> WithWindows<T1, T2, T3, T4>(this CombinedResult<InnerQueueJobRunAsUserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2, T3, T4, InnerQueueWindowsUserFactory> WithWindows<T1, T2, T3, T4>(this CombinedResult<T1, InnerQueueJobRunAsUserFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory, T3, T4, InnerQueueWindowsUserFactory> WithWindows<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerQueueJobRunAsUserFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerQueueJobRunAsUserFactory, T4, InnerQueueWindowsUserFactory> WithWindows<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerQueueJobRunAsUserFactory, T4> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerQueueJobRunAsUserFactory, InnerQueueWindowsUserFactory> WithWindows<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerQueueJobRunAsUserFactory> combinedResult, Action<Humidifier.Deadline.QueueTypes.WindowsUser> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindows(combinedResult.T5, subFactoryAction));
}
