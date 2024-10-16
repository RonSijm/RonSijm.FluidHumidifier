// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterOrchestratorFactory(Action<Humidifier.SageMaker.ClusterTypes.Orchestrator> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.Orchestrator>
{

    internal InnerClusterClusterOrchestratorEksConfigFactory EksFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.Orchestrator Create()
    {
        var orchestratorResult = CreateOrchestrator();
        factoryAction?.Invoke(orchestratorResult);

        return orchestratorResult;
    }

    private Humidifier.SageMaker.ClusterTypes.Orchestrator CreateOrchestrator()
    {
        var orchestratorResult = new Humidifier.SageMaker.ClusterTypes.Orchestrator();

        return orchestratorResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.Orchestrator result)
    {
        base.CreateChildren(result);

        result.Eks ??= EksFactory?.Build();
    }

} // End Of Class

public static class InnerClusterOrchestratorFactoryExtensions
{
    public static CombinedResult<InnerClusterOrchestratorFactory, InnerClusterClusterOrchestratorEksConfigFactory> WithEks(this InnerClusterOrchestratorFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null)
    {
        parentFactory.EksFactory = new InnerClusterClusterOrchestratorEksConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EksFactory);
    }

    public static CombinedResult<InnerClusterOrchestratorFactory, T1, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1>(this CombinedResult<InnerClusterOrchestratorFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEks(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOrchestratorFactory, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1>(this CombinedResult<T1, InnerClusterOrchestratorFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEks(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterOrchestratorFactory, T1, T2, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2>(this CombinedResult<InnerClusterOrchestratorFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOrchestratorFactory, T2, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2>(this CombinedResult<T1, InnerClusterOrchestratorFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOrchestratorFactory, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2>(this CombinedResult<T1, T2, InnerClusterOrchestratorFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterOrchestratorFactory, T1, T2, T3, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2, T3>(this CombinedResult<InnerClusterOrchestratorFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOrchestratorFactory, T2, T3, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2, T3>(this CombinedResult<T1, InnerClusterOrchestratorFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOrchestratorFactory, T3, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterOrchestratorFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterOrchestratorFactory, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterOrchestratorFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterOrchestratorFactory, T1, T2, T3, T4, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2, T3, T4>(this CombinedResult<InnerClusterOrchestratorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOrchestratorFactory, T2, T3, T4, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterOrchestratorFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOrchestratorFactory, T3, T4, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterOrchestratorFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterOrchestratorFactory, T4, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterOrchestratorFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterOrchestratorFactory, InnerClusterClusterOrchestratorEksConfigFactory> WithEks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterOrchestratorFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T5, subFactoryAction));
}
