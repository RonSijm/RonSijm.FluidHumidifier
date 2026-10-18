// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory(Action<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkNetworkConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkNetworkConfig>
{

    internal InnerAIBenchmarkJobVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkNetworkConfig Create()
    {
        var aIBenchmarkNetworkConfigResult = CreateAIBenchmarkNetworkConfig();
        factoryAction?.Invoke(aIBenchmarkNetworkConfigResult);

        return aIBenchmarkNetworkConfigResult;
    }

    private Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkNetworkConfig CreateAIBenchmarkNetworkConfig()
    {
        var aIBenchmarkNetworkConfigResult = new Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkNetworkConfig();

        return aIBenchmarkNetworkConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AIBenchmarkJobTypes.AIBenchmarkNetworkConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactoryExtensions
{
    public static CombinedResult<InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig(this InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory parentFactory, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerAIBenchmarkJobVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T1, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T1, T2, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T2, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T1, T2, T3, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T2, T3, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T3, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T1, T2, T3, T4, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T2, T3, T4, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T3, T4, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T4, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory, InnerAIBenchmarkJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAIBenchmarkJobAIBenchmarkNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.AIBenchmarkJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction).T2);
}
