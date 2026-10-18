// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class JobRunFactory(string resourceName = null, Action<Humidifier.EMRServerless.JobRun> factoryAction = null) : ResourceFactory<Humidifier.EMRServerless.JobRun>(resourceName)
{

    internal InnerJobRunConfigurationOverridesFactory ConfigurationOverridesFactory { get; set; }

    internal InnerJobRunJobDriverFactory JobDriverFactory { get; set; }

    protected override Humidifier.EMRServerless.JobRun Create()
    {
        var jobRunResult = CreateJobRun();
        factoryAction?.Invoke(jobRunResult);

        return jobRunResult;
    }

    private Humidifier.EMRServerless.JobRun CreateJobRun()
    {
        var jobRunResult = new Humidifier.EMRServerless.JobRun
        {
            GivenName = InputResourceName,
        };

        return jobRunResult;
    }
    public override void CreateChildren(Humidifier.EMRServerless.JobRun result)
    {
        base.CreateChildren(result);

        result.ConfigurationOverrides ??= ConfigurationOverridesFactory?.Build();
        result.JobDriver ??= JobDriverFactory?.Build();
    }

} // End Of Class

public static class JobRunFactoryExtensions
{
    public static CombinedResult<JobRunFactory, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides(this JobRunFactory parentFactory, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null)
    {
        parentFactory.ConfigurationOverridesFactory = new InnerJobRunConfigurationOverridesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationOverridesFactory);
    }

    public static CombinedResult<JobRunFactory, InnerJobRunJobDriverFactory> WithJobDriver(this JobRunFactory parentFactory, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null)
    {
        parentFactory.JobDriverFactory = new InnerJobRunJobDriverFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobDriverFactory);
    }

    public static CombinedResult<JobRunFactory, T1, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1>(this CombinedResult<JobRunFactory, T1> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobRunFactory, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1>(this CombinedResult<T1, JobRunFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobRunFactory, T1, T2, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<JobRunFactory, T1, T2> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobRunFactory, T2, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<T1, JobRunFactory, T2> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobRunFactory, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<T1, T2, JobRunFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobRunFactory, T1, T2, T3, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<JobRunFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobRunFactory, T2, T3, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, JobRunFactory, T2, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobRunFactory, T3, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, T2, JobRunFactory, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobRunFactory, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobRunFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobRunFactory, T1, T2, T3, T4, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<JobRunFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobRunFactory, T2, T3, T4, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, JobRunFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobRunFactory, T3, T4, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobRunFactory, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobRunFactory, T4, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobRunFactory, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobRunFactory, InnerJobRunConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobRunFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<JobRunFactory, T1, InnerJobRunJobDriverFactory> WithJobDriver<T1>(this CombinedResult<JobRunFactory, T1> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobRunFactory, InnerJobRunJobDriverFactory> WithJobDriver<T1>(this CombinedResult<T1, JobRunFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobRunFactory, T1, T2, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2>(this CombinedResult<JobRunFactory, T1, T2> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobRunFactory, T2, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2>(this CombinedResult<T1, JobRunFactory, T2> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobRunFactory, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2>(this CombinedResult<T1, T2, JobRunFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobRunFactory, T1, T2, T3, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2, T3>(this CombinedResult<JobRunFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobRunFactory, T2, T3, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2, T3>(this CombinedResult<T1, JobRunFactory, T2, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobRunFactory, T3, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, JobRunFactory, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobRunFactory, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobRunFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobRunFactory, T1, T2, T3, T4, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2, T3, T4>(this CombinedResult<JobRunFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobRunFactory, T2, T3, T4, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, JobRunFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobRunFactory, T3, T4, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobRunFactory, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobRunFactory, T4, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobRunFactory, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobRunFactory, InnerJobRunJobDriverFactory> WithJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobRunFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T5, subFactoryAction).T2);
}
