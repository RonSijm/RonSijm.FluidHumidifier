// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class ExperimentFactory(string resourceName = null, Action<Humidifier.Evidently.Experiment> factoryAction = null) : ResourceFactory<Humidifier.Evidently.Experiment>(resourceName)
{

    internal List<InnerExperimentMetricGoalObjectFactory> MetricGoalsFactories { get; set; } = [];

    internal List<InnerExperimentTreatmentObjectFactory> TreatmentsFactories { get; set; } = [];

    internal InnerExperimentRunningStatusObjectFactory RunningStatusFactory { get; set; }

    internal InnerExperimentOnlineAbConfigObjectFactory OnlineAbConfigFactory { get; set; }

    protected override Humidifier.Evidently.Experiment Create()
    {
        var experimentResult = CreateExperiment();
        factoryAction?.Invoke(experimentResult);

        return experimentResult;
    }

    private Humidifier.Evidently.Experiment CreateExperiment()
    {
        var experimentResult = new Humidifier.Evidently.Experiment
        {
            GivenName = InputResourceName,
        };

        return experimentResult;
    }
    public override void CreateChildren(Humidifier.Evidently.Experiment result)
    {
        base.CreateChildren(result);

        result.MetricGoals = MetricGoalsFactories.Any() ? MetricGoalsFactories.Select(x => x.Build()).ToList() : null;
        result.Treatments = TreatmentsFactories.Any() ? TreatmentsFactories.Select(x => x.Build()).ToList() : null;
        result.RunningStatus ??= RunningStatusFactory?.Build();
        result.OnlineAbConfig ??= OnlineAbConfigFactory?.Build();
    }

} // End Of Class

public static class ExperimentFactoryExtensions
{
    public static CombinedResult<ExperimentFactory, InnerExperimentMetricGoalObjectFactory> WithMetricGoals(this ExperimentFactory parentFactory, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null)
    {
        var factory = new InnerExperimentMetricGoalObjectFactory(subFactoryAction);
        parentFactory.MetricGoalsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ExperimentFactory, InnerExperimentTreatmentObjectFactory> WithTreatments(this ExperimentFactory parentFactory, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null)
    {
        var factory = new InnerExperimentTreatmentObjectFactory(subFactoryAction);
        parentFactory.TreatmentsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ExperimentFactory, InnerExperimentRunningStatusObjectFactory> WithRunningStatus(this ExperimentFactory parentFactory, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null)
    {
        parentFactory.RunningStatusFactory = new InnerExperimentRunningStatusObjectFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RunningStatusFactory);
    }

    public static CombinedResult<ExperimentFactory, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig(this ExperimentFactory parentFactory, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null)
    {
        parentFactory.OnlineAbConfigFactory = new InnerExperimentOnlineAbConfigObjectFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OnlineAbConfigFactory);
    }

    public static CombinedResult<ExperimentFactory, T1, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1>(this CombinedResult<ExperimentFactory, T1> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricGoals(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1>(this CombinedResult<T1, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricGoals(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2>(this CombinedResult<ExperimentFactory, T1, T2> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2>(this CombinedResult<T1, ExperimentFactory, T2> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2>(this CombinedResult<T1, T2, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, T3, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2, T3>(this CombinedResult<ExperimentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, T3, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2, T3>(this CombinedResult<T1, ExperimentFactory, T2, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, T3, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2, T3>(this CombinedResult<T1, T2, ExperimentFactory, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExperimentFactory, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, T3, T4, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2, T3, T4>(this CombinedResult<ExperimentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, T3, T4, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2, T3, T4>(this CombinedResult<T1, ExperimentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, T3, T4, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExperimentFactory, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExperimentFactory, T4, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExperimentFactory, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ExperimentFactory, InnerExperimentMetricGoalObjectFactory> WithMetricGoals<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.MetricGoalObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricGoals(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, InnerExperimentTreatmentObjectFactory> WithTreatments<T1>(this CombinedResult<ExperimentFactory, T1> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithTreatments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, InnerExperimentTreatmentObjectFactory> WithTreatments<T1>(this CombinedResult<T1, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithTreatments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2>(this CombinedResult<ExperimentFactory, T1, T2> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2>(this CombinedResult<T1, ExperimentFactory, T2> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2>(this CombinedResult<T1, T2, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, T3, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2, T3>(this CombinedResult<ExperimentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, T3, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2, T3>(this CombinedResult<T1, ExperimentFactory, T2, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, T3, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2, T3>(this CombinedResult<T1, T2, ExperimentFactory, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExperimentFactory, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, T3, T4, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2, T3, T4>(this CombinedResult<ExperimentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, T3, T4, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2, T3, T4>(this CombinedResult<T1, ExperimentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, T3, T4, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExperimentFactory, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExperimentFactory, T4, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExperimentFactory, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ExperimentFactory, InnerExperimentTreatmentObjectFactory> WithTreatments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.TreatmentObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1>(this CombinedResult<ExperimentFactory, T1> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithRunningStatus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1>(this CombinedResult<T1, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithRunningStatus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2>(this CombinedResult<ExperimentFactory, T1, T2> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2>(this CombinedResult<T1, ExperimentFactory, T2> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2>(this CombinedResult<T1, T2, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, T3, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2, T3>(this CombinedResult<ExperimentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, T3, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2, T3>(this CombinedResult<T1, ExperimentFactory, T2, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, T3, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2, T3>(this CombinedResult<T1, T2, ExperimentFactory, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExperimentFactory, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, T3, T4, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2, T3, T4>(this CombinedResult<ExperimentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, T3, T4, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2, T3, T4>(this CombinedResult<T1, ExperimentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, T3, T4, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExperimentFactory, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExperimentFactory, T4, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExperimentFactory, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ExperimentFactory, InnerExperimentRunningStatusObjectFactory> WithRunningStatus<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.RunningStatusObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunningStatus(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1>(this CombinedResult<ExperimentFactory, T1> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1>(this CombinedResult<T1, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2>(this CombinedResult<ExperimentFactory, T1, T2> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2>(this CombinedResult<T1, ExperimentFactory, T2> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2>(this CombinedResult<T1, T2, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, T3, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2, T3>(this CombinedResult<ExperimentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, T3, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2, T3>(this CombinedResult<T1, ExperimentFactory, T2, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, T3, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2, T3>(this CombinedResult<T1, T2, ExperimentFactory, T3> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExperimentFactory, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ExperimentFactory, T1, T2, T3, T4, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2, T3, T4>(this CombinedResult<ExperimentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ExperimentFactory, T2, T3, T4, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2, T3, T4>(this CombinedResult<T1, ExperimentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ExperimentFactory, T3, T4, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExperimentFactory, T3, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ExperimentFactory, T4, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExperimentFactory, T4> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ExperimentFactory, InnerExperimentOnlineAbConfigObjectFactory> WithOnlineAbConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExperimentFactory> combinedResult, Action<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnlineAbConfig(combinedResult.T5, subFactoryAction));
}
