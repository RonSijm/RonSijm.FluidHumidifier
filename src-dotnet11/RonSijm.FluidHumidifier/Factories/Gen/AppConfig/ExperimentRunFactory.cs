// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class ExperimentRunFactory(string resourceName = null, Action<Humidifier.AppConfig.ExperimentRun> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.ExperimentRun>(resourceName)
{

    internal InnerExperimentRunTreatmentOverridesFactory TreatmentOverridesFactory { get; set; }

    protected override Humidifier.AppConfig.ExperimentRun Create()
    {
        var experimentRunResult = CreateExperimentRun();
        factoryAction?.Invoke(experimentRunResult);

        return experimentRunResult;
    }

    private Humidifier.AppConfig.ExperimentRun CreateExperimentRun()
    {
        var experimentRunResult = new Humidifier.AppConfig.ExperimentRun
        {
            GivenName = InputResourceName,
        };

        return experimentRunResult;
    }
    public override void CreateChildren(Humidifier.AppConfig.ExperimentRun result)
    {
        base.CreateChildren(result);

        result.TreatmentOverrides ??= TreatmentOverridesFactory?.Build();
    }

} // End Of Class

public static class ExperimentRunFactoryExtensions
{
    public static CombinedResult<ExperimentRunFactory, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides(this ExperimentRunFactory parentFactory, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null)
    {
        parentFactory.TreatmentOverridesFactory = new InnerExperimentRunTreatmentOverridesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TreatmentOverridesFactory);
    }

    public static CombinedResult<ExperimentRunFactory, T1, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1>(this CombinedResult<ExperimentRunFactory, T1> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentRunFactory, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1>(this CombinedResult<T1, ExperimentRunFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ExperimentRunFactory, T1, T2, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2>(this CombinedResult<ExperimentRunFactory, T1, T2> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentRunFactory, T2, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2>(this CombinedResult<T1, ExperimentRunFactory, T2> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentRunFactory, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2>(this CombinedResult<T1, T2, ExperimentRunFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ExperimentRunFactory, T1, T2, T3, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2, T3>(this CombinedResult<ExperimentRunFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentRunFactory, T2, T3, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2, T3>(this CombinedResult<T1, ExperimentRunFactory, T2, T3> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentRunFactory, T3, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2, T3>(this CombinedResult<T1, T2, ExperimentRunFactory, T3> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExperimentRunFactory, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExperimentRunFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ExperimentRunFactory, T1, T2, T3, T4, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2, T3, T4>(this CombinedResult<ExperimentRunFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExperimentRunFactory, T2, T3, T4, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2, T3, T4>(this CombinedResult<T1, ExperimentRunFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExperimentRunFactory, T3, T4, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExperimentRunFactory, T3, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExperimentRunFactory, T4, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExperimentRunFactory, T4> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ExperimentRunFactory, InnerExperimentRunTreatmentOverridesFactory> WithTreatmentOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExperimentRunFactory> combinedResult, Action<Humidifier.AppConfig.ExperimentRunTypes.TreatmentOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTreatmentOverrides(combinedResult.T5, subFactoryAction).T2);
}
