// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIBenchmarkJobAIBenchmarkTargetFactory(Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkTarget> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkTarget>
{

    internal InnerAIBenchmarkJobAIBenchmarkEndpointFactory EndpointFactory { get; set; }

    protected override Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkTarget Create()
    {
        var aIBenchmarkTargetResult = CreateAIBenchmarkTarget();
        factoryAction?.Invoke(aIBenchmarkTargetResult);

        return aIBenchmarkTargetResult;
    }

    private Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkTarget CreateAIBenchmarkTarget()
    {
        var aIBenchmarkTargetResult = new Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkTarget();

        return aIBenchmarkTargetResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkTarget result)
    {
        base.CreateChildren(result);

        result.Endpoint ??= EndpointFactory?.Build();
    }

} // End Of Class

public static class InnerAIBenchmarkJobAIBenchmarkTargetFactoryExtensions
{
    public static CombinedResult<InnerAIBenchmarkJobAIBenchmarkTargetFactory, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint(this InnerAIBenchmarkJobAIBenchmarkTargetFactory parentFactory, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null)
    {
        parentFactory.EndpointFactory = new InnerAIBenchmarkJobAIBenchmarkEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EndpointFactory);
    }

    public static CombinedResult<InnerAIBenchmarkJobAIBenchmarkTargetFactory, T1, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1>(this CombinedResult<InnerAIBenchmarkJobAIBenchmarkTargetFactory, T1> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkTargetFactory, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1>(this CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkTargetFactory> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAIBenchmarkJobAIBenchmarkTargetFactory, T1, T2, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2>(this CombinedResult<InnerAIBenchmarkJobAIBenchmarkTargetFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T2, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2>(this CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T2> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkTargetFactory, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2>(this CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkTargetFactory> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAIBenchmarkJobAIBenchmarkTargetFactory, T1, T2, T3, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<InnerAIBenchmarkJobAIBenchmarkTargetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T2, T3, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T3, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T3> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAIBenchmarkJobAIBenchmarkTargetFactory, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAIBenchmarkJobAIBenchmarkTargetFactory> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAIBenchmarkJobAIBenchmarkTargetFactory, T1, T2, T3, T4, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<InnerAIBenchmarkJobAIBenchmarkTargetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T2, T3, T4, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T3, T4, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T4, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAIBenchmarkJobAIBenchmarkTargetFactory, T4> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAIBenchmarkJobAIBenchmarkTargetFactory, InnerAIBenchmarkJobAIBenchmarkEndpointFactory> WithEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAIBenchmarkJobAIBenchmarkTargetFactory> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoint(combinedResult.T5, subFactoryAction).T2);
}
