// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class ExperimentDefinitionFactory(string resourceName = null, Action<Humidifier.AppConfig.ExperimentDefinition> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.ExperimentDefinition>(resourceName)
{

    internal List<InnerExperimentDefinitionTreatmentFactory> TreatmentsFactories { get; set; } = [];

    internal InnerExperimentDefinitionTreatmentFactory ControlFactory { get; set; }

    protected override Humidifier.AppConfig.ExperimentDefinition Create()
    {
        var experimentDefinitionResult = CreateExperimentDefinition();
        factoryAction?.Invoke(experimentDefinitionResult);

        return experimentDefinitionResult;
    }

    private Humidifier.AppConfig.ExperimentDefinition CreateExperimentDefinition()
    {
        var experimentDefinitionResult = new Humidifier.AppConfig.ExperimentDefinition
        {
            GivenName = InputResourceName,
        };

        return experimentDefinitionResult;
    }
    public override void CreateChildren(Humidifier.AppConfig.ExperimentDefinition result)
    {
        base.CreateChildren(result);

        result.Treatments = TreatmentsFactories.Any() ? TreatmentsFactories.Select(x => x.Build()).ToList() : null;
        result.Control ??= ControlFactory?.Build();
    }

} // End Of Class

public static class ExperimentDefinitionFactoryExtensions
{
    public static CombinedResult<ExperimentDefinitionFactory, InnerExperimentDefinitionTreatmentFactory> WithTreatments(this ExperimentDefinitionFactory parentFactory, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null)
    {
        var factory = new InnerExperimentDefinitionTreatmentFactory(subFactoryAction);
        parentFactory.TreatmentsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ExperimentDefinitionFactory, InnerExperimentDefinitionTreatmentFactory> WithControl(this ExperimentDefinitionFactory parentFactory, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null)
    {
        parentFactory.ControlFactory = new InnerExperimentDefinitionTreatmentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ControlFactory);
    }

    public static CombinedResult<ExperimentDefinitionFactory, T1, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1>(this CombinedResult<ExperimentDefinitionFactory, T1> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, WithTreatments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentDefinitionFactory, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1>(this CombinedResult<T1, ExperimentDefinitionFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, WithTreatments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ExperimentDefinitionFactory, T1, T2, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2>(this CombinedResult<ExperimentDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentDefinitionFactory, T2, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2>(this CombinedResult<T1, ExperimentDefinitionFactory, T2> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentDefinitionFactory, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2>(this CombinedResult<T1, T2, ExperimentDefinitionFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ExperimentDefinitionFactory, T1, T2, T3, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2, T3>(this CombinedResult<ExperimentDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentDefinitionFactory, T2, T3, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2, T3>(this CombinedResult<T1, ExperimentDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentDefinitionFactory, T3, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2, T3>(this CombinedResult<T1, T2, ExperimentDefinitionFactory, T3> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExperimentDefinitionFactory, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExperimentDefinitionFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ExperimentDefinitionFactory, T1, T2, T3, T4, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2, T3, T4>(this CombinedResult<ExperimentDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentDefinitionFactory, T2, T3, T4, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2, T3, T4>(this CombinedResult<T1, ExperimentDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentDefinitionFactory, T3, T4, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExperimentDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExperimentDefinitionFactory, T4, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExperimentDefinitionFactory, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ExperimentDefinitionFactory, InnerExperimentDefinitionTreatmentFactory> WithTreatments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExperimentDefinitionFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatments(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ExperimentDefinitionFactory, T1, InnerExperimentDefinitionTreatmentFactory> WithControl<T1>(this CombinedResult<ExperimentDefinitionFactory, T1> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, WithControl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentDefinitionFactory, InnerExperimentDefinitionTreatmentFactory> WithControl<T1>(this CombinedResult<T1, ExperimentDefinitionFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, WithControl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ExperimentDefinitionFactory, T1, T2, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2>(this CombinedResult<ExperimentDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentDefinitionFactory, T2, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2>(this CombinedResult<T1, ExperimentDefinitionFactory, T2> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentDefinitionFactory, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2>(this CombinedResult<T1, T2, ExperimentDefinitionFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ExperimentDefinitionFactory, T1, T2, T3, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2, T3>(this CombinedResult<ExperimentDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentDefinitionFactory, T2, T3, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2, T3>(this CombinedResult<T1, ExperimentDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentDefinitionFactory, T3, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2, T3>(this CombinedResult<T1, T2, ExperimentDefinitionFactory, T3> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExperimentDefinitionFactory, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExperimentDefinitionFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ExperimentDefinitionFactory, T1, T2, T3, T4, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2, T3, T4>(this CombinedResult<ExperimentDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentDefinitionFactory, T2, T3, T4, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2, T3, T4>(this CombinedResult<T1, ExperimentDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentDefinitionFactory, T3, T4, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExperimentDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExperimentDefinitionFactory, T4, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExperimentDefinitionFactory, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ExperimentDefinitionFactory, InnerExperimentDefinitionTreatmentFactory> WithControl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExperimentDefinitionFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentDefinitionTypes.Treatment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControl(combinedResult.T5, subFactoryAction).T2);
}
