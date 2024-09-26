// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterStepConfigFactory(Action<Humidifier.EMR.ClusterTypes.StepConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.StepConfig>
{

    internal InnerClusterHadoopJarStepConfigFactory HadoopJarStepFactory { get; set; }

    protected override Humidifier.EMR.ClusterTypes.StepConfig Create()
    {
        var stepConfigResult = CreateStepConfig();
        factoryAction?.Invoke(stepConfigResult);

        return stepConfigResult;
    }

    private Humidifier.EMR.ClusterTypes.StepConfig CreateStepConfig()
    {
        var stepConfigResult = new Humidifier.EMR.ClusterTypes.StepConfig();

        return stepConfigResult;
    }
    public override void CreateChildren(Humidifier.EMR.ClusterTypes.StepConfig result)
    {
        base.CreateChildren(result);

        result.HadoopJarStep ??= HadoopJarStepFactory?.Build();
    }

} // End Of Class

public static class InnerClusterStepConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterStepConfigFactory, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep(this InnerClusterStepConfigFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null)
    {
        parentFactory.HadoopJarStepFactory = new InnerClusterHadoopJarStepConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HadoopJarStepFactory);
    }

    public static CombinedResult<InnerClusterStepConfigFactory, T1, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1>(this CombinedResult<InnerClusterStepConfigFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStepConfigFactory, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1>(this CombinedResult<T1, InnerClusterStepConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterStepConfigFactory, T1, T2, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2>(this CombinedResult<InnerClusterStepConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStepConfigFactory, T2, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2>(this CombinedResult<T1, InnerClusterStepConfigFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterStepConfigFactory, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2>(this CombinedResult<T1, T2, InnerClusterStepConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterStepConfigFactory, T1, T2, T3, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3>(this CombinedResult<InnerClusterStepConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStepConfigFactory, T2, T3, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3>(this CombinedResult<T1, InnerClusterStepConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterStepConfigFactory, T3, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterStepConfigFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterStepConfigFactory, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterStepConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterStepConfigFactory, T1, T2, T3, T4, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3, T4>(this CombinedResult<InnerClusterStepConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterStepConfigFactory, T2, T3, T4, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterStepConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterStepConfigFactory, T3, T4, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterStepConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterStepConfigFactory, T4, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterStepConfigFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterStepConfigFactory, InnerClusterHadoopJarStepConfigFactory> WithHadoopJarStep<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterStepConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHadoopJarStep(combinedResult.T5, subFactoryAction));
}
