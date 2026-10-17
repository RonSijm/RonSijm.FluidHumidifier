// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConvert;

public class JobFactory(string resourceName = null, Action<Humidifier.MediaConvert.Job> factoryAction = null) : ResourceFactory<Humidifier.MediaConvert.Job>(resourceName)
{

    internal List<InnerJobHopDestinationFactory> HopDestinationsFactories { get; set; } = [];

    internal InnerJobAccelerationSettingsFactory AccelerationSettingsFactory { get; set; }

    protected override Humidifier.MediaConvert.Job Create()
    {
        var jobResult = CreateJob();
        factoryAction?.Invoke(jobResult);

        return jobResult;
    }

    private Humidifier.MediaConvert.Job CreateJob()
    {
        var jobResult = new Humidifier.MediaConvert.Job
        {
            GivenName = InputResourceName,
        };

        return jobResult;
    }
    public override void CreateChildren(Humidifier.MediaConvert.Job result)
    {
        base.CreateChildren(result);

        result.HopDestinations = HopDestinationsFactories.Any() ? HopDestinationsFactories.Select(x => x.Build()).ToList() : null;
        result.AccelerationSettings ??= AccelerationSettingsFactory?.Build();
    }

} // End Of Class

public static class JobFactoryExtensions
{
    public static CombinedResult<JobFactory, InnerJobHopDestinationFactory> WithHopDestinations(this JobFactory parentFactory, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null)
    {
        var factory = new InnerJobHopDestinationFactory(subFactoryAction);
        parentFactory.HopDestinationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<JobFactory, InnerJobAccelerationSettingsFactory> WithAccelerationSettings(this JobFactory parentFactory, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null)
    {
        parentFactory.AccelerationSettingsFactory = new InnerJobAccelerationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccelerationSettingsFactory);
    }

    public static CombinedResult<JobFactory, T1, InnerJobHopDestinationFactory> WithHopDestinations<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithHopDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, InnerJobHopDestinationFactory> WithHopDestinations<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithHopDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobHopDestinationFactory> WithHopDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.MediaConvert.JobTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T5, subFactoryAction).T2);
}
