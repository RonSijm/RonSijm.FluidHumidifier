// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class StepFactory(string resourceName = null, Action<Humidifier.EMR.Step> factoryAction = null) : ResourceFactory<Humidifier.EMR.Step>(resourceName)
{

    internal InnerStepHadoopJarStepConfigFactory HadoopJarStepFactory { get; set; }

    protected override Humidifier.EMR.Step Create()
    {
        var stepResult = CreateStep();
        factoryAction?.Invoke(stepResult);

        return stepResult;
    }

    private Humidifier.EMR.Step CreateStep()
    {
        var stepResult = new Humidifier.EMR.Step
        {
            GivenName = InputResourceName,
        };

        return stepResult;
    }
    public override void CreateChildren(Humidifier.EMR.Step result)
    {
        base.CreateChildren(result);

        result.HadoopJarStep ??= HadoopJarStepFactory?.Build();
    }

} // End Of Class

public static class StepFactoryExtensions
{
    public static CombinedResult<StepFactory, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep(this StepFactory parentFactory, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null)
    {
        parentFactory.HadoopJarStepFactory = new InnerStepHadoopJarStepConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HadoopJarStepFactory);
    }

    public static CombinedResult<StepFactory, T1, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1>(this CombinedResult<StepFactory, T1> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StepFactory, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1>(this CombinedResult<T1, StepFactory> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StepFactory, T1, T2, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2>(this CombinedResult<StepFactory, T1, T2> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StepFactory, T2, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2>(this CombinedResult<T1, StepFactory, T2> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StepFactory, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2>(this CombinedResult<T1, T2, StepFactory> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StepFactory, T1, T2, T3, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3>(this CombinedResult<StepFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StepFactory, T2, T3, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3>(this CombinedResult<T1, StepFactory, T2, T3> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StepFactory, T3, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3>(this CombinedResult<T1, T2, StepFactory, T3> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StepFactory, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3>(this CombinedResult<T1, T2, T3, StepFactory> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StepFactory, T1, T2, T3, T4, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3, T4>(this CombinedResult<StepFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StepFactory, T2, T3, T4, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3, T4>(this CombinedResult<T1, StepFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StepFactory, T3, T4, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3, T4>(this CombinedResult<T1, T2, StepFactory, T3, T4> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StepFactory, T4, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StepFactory, T4> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StepFactory, InnerStepHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StepFactory> combinedResult, Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T5, subFactoryAction));
}
