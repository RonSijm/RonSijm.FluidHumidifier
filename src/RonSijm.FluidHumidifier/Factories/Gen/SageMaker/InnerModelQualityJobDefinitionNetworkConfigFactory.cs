// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionNetworkConfigFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.NetworkConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.NetworkConfig>
{

    internal InnerModelQualityJobDefinitionVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.NetworkConfig Create()
    {
        var networkConfigResult = CreateNetworkConfig();
        factoryAction?.Invoke(networkConfigResult);

        return networkConfigResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.NetworkConfig CreateNetworkConfig()
    {
        var networkConfigResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.NetworkConfig();

        return networkConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelQualityJobDefinitionTypes.NetworkConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionNetworkConfigFactoryExtensions
{
    public static CombinedResult<InnerModelQualityJobDefinitionNetworkConfigFactory, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig(this InnerModelQualityJobDefinitionNetworkConfigFactory parentFactory, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerModelQualityJobDefinitionVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerModelQualityJobDefinitionNetworkConfigFactory, T1, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerModelQualityJobDefinitionNetworkConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionNetworkConfigFactory, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerModelQualityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionNetworkConfigFactory, T1, T2, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerModelQualityJobDefinitionNetworkConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionNetworkConfigFactory, T2, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerModelQualityJobDefinitionNetworkConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionNetworkConfigFactory, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionNetworkConfigFactory, T1, T2, T3, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerModelQualityJobDefinitionNetworkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionNetworkConfigFactory, T2, T3, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerModelQualityJobDefinitionNetworkConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionNetworkConfigFactory, T3, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionNetworkConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionNetworkConfigFactory, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionNetworkConfigFactory, T1, T2, T3, T4, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerModelQualityJobDefinitionNetworkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionNetworkConfigFactory, T2, T3, T4, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelQualityJobDefinitionNetworkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionNetworkConfigFactory, T3, T4, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionNetworkConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionNetworkConfigFactory, T4, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionNetworkConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionNetworkConfigFactory, InnerModelQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
}
