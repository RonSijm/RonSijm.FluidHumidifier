// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobNetworkConfigFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.NetworkConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.NetworkConfig>
{

    internal InnerProcessingJobVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ProcessingJobTypes.NetworkConfig Create()
    {
        var networkConfigResult = CreateNetworkConfig();
        factoryAction?.Invoke(networkConfigResult);

        return networkConfigResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.NetworkConfig CreateNetworkConfig()
    {
        var networkConfigResult = new Humidifier.SageMaker.ProcessingJobTypes.NetworkConfig();

        return networkConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ProcessingJobTypes.NetworkConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerProcessingJobNetworkConfigFactoryExtensions
{
    public static CombinedResult<InnerProcessingJobNetworkConfigFactory, InnerProcessingJobVpcConfigFactory> WithVpcConfig(this InnerProcessingJobNetworkConfigFactory parentFactory, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerProcessingJobVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerProcessingJobNetworkConfigFactory, T1, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerProcessingJobNetworkConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobNetworkConfigFactory, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerProcessingJobNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobNetworkConfigFactory, T1, T2, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerProcessingJobNetworkConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobNetworkConfigFactory, T2, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerProcessingJobNetworkConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobNetworkConfigFactory, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerProcessingJobNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobNetworkConfigFactory, T1, T2, T3, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerProcessingJobNetworkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobNetworkConfigFactory, T2, T3, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerProcessingJobNetworkConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobNetworkConfigFactory, T3, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerProcessingJobNetworkConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProcessingJobNetworkConfigFactory, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProcessingJobNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobNetworkConfigFactory, T1, T2, T3, T4, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerProcessingJobNetworkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobNetworkConfigFactory, T2, T3, T4, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerProcessingJobNetworkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobNetworkConfigFactory, T3, T4, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProcessingJobNetworkConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProcessingJobNetworkConfigFactory, T4, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProcessingJobNetworkConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerProcessingJobNetworkConfigFactory, InnerProcessingJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProcessingJobNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction).T2);
}
