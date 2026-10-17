// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIWorkloadConfigAIWorkloadConfigsFactory(Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs>
{

    internal InnerAIWorkloadConfigWorkloadSpecFactory WorkloadSpecFactory { get; set; }

    protected override Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs Create()
    {
        var aIWorkloadConfigsResult = CreateAIWorkloadConfigs();
        factoryAction?.Invoke(aIWorkloadConfigsResult);

        return aIWorkloadConfigsResult;
    }

    private Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs CreateAIWorkloadConfigs()
    {
        var aIWorkloadConfigsResult = new Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs();

        return aIWorkloadConfigsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs result)
    {
        base.CreateChildren(result);

        result.WorkloadSpec ??= WorkloadSpecFactory?.Build();
    }

} // End Of Class

public static class InnerAIWorkloadConfigAIWorkloadConfigsFactoryExtensions
{
    public static CombinedResult<InnerAIWorkloadConfigAIWorkloadConfigsFactory, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec(this InnerAIWorkloadConfigAIWorkloadConfigsFactory parentFactory, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null)
    {
        parentFactory.WorkloadSpecFactory = new InnerAIWorkloadConfigWorkloadSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WorkloadSpecFactory);
    }

    public static CombinedResult<InnerAIWorkloadConfigAIWorkloadConfigsFactory, T1, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1>(this CombinedResult<InnerAIWorkloadConfigAIWorkloadConfigsFactory, T1> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIWorkloadConfigAIWorkloadConfigsFactory, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1>(this CombinedResult<T1, InnerAIWorkloadConfigAIWorkloadConfigsFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAIWorkloadConfigAIWorkloadConfigsFactory, T1, T2, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2>(this CombinedResult<InnerAIWorkloadConfigAIWorkloadConfigsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T2, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2>(this CombinedResult<T1, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T2> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIWorkloadConfigAIWorkloadConfigsFactory, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2>(this CombinedResult<T1, T2, InnerAIWorkloadConfigAIWorkloadConfigsFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAIWorkloadConfigAIWorkloadConfigsFactory, T1, T2, T3, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2, T3>(this CombinedResult<InnerAIWorkloadConfigAIWorkloadConfigsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T2, T3, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2, T3>(this CombinedResult<T1, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T3, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T3> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAIWorkloadConfigAIWorkloadConfigsFactory, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAIWorkloadConfigAIWorkloadConfigsFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAIWorkloadConfigAIWorkloadConfigsFactory, T1, T2, T3, T4, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2, T3, T4>(this CombinedResult<InnerAIWorkloadConfigAIWorkloadConfigsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T2, T3, T4, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T3, T4, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T4, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAIWorkloadConfigAIWorkloadConfigsFactory, T4> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAIWorkloadConfigAIWorkloadConfigsFactory, InnerAIWorkloadConfigWorkloadSpecFactory> WithWorkloadSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAIWorkloadConfigAIWorkloadConfigsFactory> combinedResult, Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkloadSpec(combinedResult.T5, subFactoryAction).T2);
}
