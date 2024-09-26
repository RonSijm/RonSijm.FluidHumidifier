// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConvert;

public class JobTemplateFactory(string resourceName = null, Action<Humidifier.MediaConvert.JobTemplate> factoryAction = null) : ResourceFactory<Humidifier.MediaConvert.JobTemplate>(resourceName)
{

    internal List<InnerJobTemplateHopDestinationFactory> HopDestinationsFactories { get; set; } = [];

    internal InnerJobTemplateAccelerationSettingsFactory AccelerationSettingsFactory { get; set; }

    protected override Humidifier.MediaConvert.JobTemplate Create()
    {
        var jobTemplateResult = CreateJobTemplate();
        factoryAction?.Invoke(jobTemplateResult);

        return jobTemplateResult;
    }

    private Humidifier.MediaConvert.JobTemplate CreateJobTemplate()
    {
        var jobTemplateResult = new Humidifier.MediaConvert.JobTemplate
        {
            GivenName = InputResourceName,
        };

        return jobTemplateResult;
    }
    public override void CreateChildren(Humidifier.MediaConvert.JobTemplate result)
    {
        base.CreateChildren(result);

        result.HopDestinations = HopDestinationsFactories.Any() ? HopDestinationsFactories.Select(x => x.Build()).ToList() : null;
        result.AccelerationSettings ??= AccelerationSettingsFactory?.Build();
    }

} // End Of Class

public static class JobTemplateFactoryExtensions
{
    public static CombinedResult<JobTemplateFactory, InnerJobTemplateHopDestinationFactory> WithHopDestinations(this JobTemplateFactory parentFactory, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null)
    {
        var factory = new InnerJobTemplateHopDestinationFactory(subFactoryAction);
        parentFactory.HopDestinationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<JobTemplateFactory, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings(this JobTemplateFactory parentFactory, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null)
    {
        parentFactory.AccelerationSettingsFactory = new InnerJobTemplateAccelerationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccelerationSettingsFactory);
    }

    public static CombinedResult<JobTemplateFactory, T1, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1>(this CombinedResult<JobTemplateFactory, T1> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithHopDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobTemplateFactory, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1>(this CombinedResult<T1, JobTemplateFactory> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithHopDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<JobTemplateFactory, T1, T2, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2>(this CombinedResult<JobTemplateFactory, T1, T2> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobTemplateFactory, T2, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2>(this CombinedResult<T1, JobTemplateFactory, T2> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobTemplateFactory, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2>(this CombinedResult<T1, T2, JobTemplateFactory> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<JobTemplateFactory, T1, T2, T3, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2, T3>(this CombinedResult<JobTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobTemplateFactory, T2, T3, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2, T3>(this CombinedResult<T1, JobTemplateFactory, T2, T3> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobTemplateFactory, T3, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2, T3>(this CombinedResult<T1, T2, JobTemplateFactory, T3> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobTemplateFactory, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobTemplateFactory> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<JobTemplateFactory, T1, T2, T3, T4, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2, T3, T4>(this CombinedResult<JobTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobTemplateFactory, T2, T3, T4, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2, T3, T4>(this CombinedResult<T1, JobTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobTemplateFactory, T3, T4, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobTemplateFactory, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobTemplateFactory, T4, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobTemplateFactory, T4> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, JobTemplateFactory, InnerJobTemplateHopDestinationFactory> WithHopDestinations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobTemplateFactory> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHopDestinations(combinedResult.T5, subFactoryAction));
    public static CombinedResult<JobTemplateFactory, T1, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1>(this CombinedResult<JobTemplateFactory, T1> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobTemplateFactory, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1>(this CombinedResult<T1, JobTemplateFactory> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<JobTemplateFactory, T1, T2, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2>(this CombinedResult<JobTemplateFactory, T1, T2> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobTemplateFactory, T2, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2>(this CombinedResult<T1, JobTemplateFactory, T2> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobTemplateFactory, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2>(this CombinedResult<T1, T2, JobTemplateFactory> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<JobTemplateFactory, T1, T2, T3, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3>(this CombinedResult<JobTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobTemplateFactory, T2, T3, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3>(this CombinedResult<T1, JobTemplateFactory, T2, T3> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobTemplateFactory, T3, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3>(this CombinedResult<T1, T2, JobTemplateFactory, T3> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobTemplateFactory, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobTemplateFactory> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<JobTemplateFactory, T1, T2, T3, T4, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3, T4>(this CombinedResult<JobTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobTemplateFactory, T2, T3, T4, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, JobTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobTemplateFactory, T3, T4, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobTemplateFactory, T3, T4> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobTemplateFactory, T4, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobTemplateFactory, T4> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, JobTemplateFactory, InnerJobTemplateAccelerationSettingsFactory> WithAccelerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobTemplateFactory> combinedResult, Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccelerationSettings(combinedResult.T5, subFactoryAction));
}
