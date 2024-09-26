// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionNetworkConfigFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.NetworkConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.NetworkConfig>
{

    internal InnerModelExplainabilityJobDefinitionVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.NetworkConfig Create()
    {
        var networkConfigResult = CreateNetworkConfig();
        factoryAction?.Invoke(networkConfigResult);

        return networkConfigResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.NetworkConfig CreateNetworkConfig()
    {
        var networkConfigResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.NetworkConfig();

        return networkConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.NetworkConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionNetworkConfigFactoryExtensions
{
    public static CombinedResult<InnerModelExplainabilityJobDefinitionNetworkConfigFactory, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig(this InnerModelExplainabilityJobDefinitionNetworkConfigFactory parentFactory, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerModelExplainabilityJobDefinitionVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T1, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T1, T2, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T2, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T1, T2, T3, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T2, T3, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T3, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T2, T3, T4, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T3, T4, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T4, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionNetworkConfigFactory, InnerModelExplainabilityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
}
