// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionNetworkConfigFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.NetworkConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.NetworkConfig>
{

    internal InnerModelBiasJobDefinitionVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.NetworkConfig Create()
    {
        var networkConfigResult = CreateNetworkConfig();
        factoryAction?.Invoke(networkConfigResult);

        return networkConfigResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.NetworkConfig CreateNetworkConfig()
    {
        var networkConfigResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.NetworkConfig();

        return networkConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelBiasJobDefinitionTypes.NetworkConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionNetworkConfigFactoryExtensions
{
    public static CombinedResult<InnerModelBiasJobDefinitionNetworkConfigFactory, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig(this InnerModelBiasJobDefinitionNetworkConfigFactory parentFactory, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerModelBiasJobDefinitionVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerModelBiasJobDefinitionNetworkConfigFactory, T1, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerModelBiasJobDefinitionNetworkConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionNetworkConfigFactory, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerModelBiasJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionNetworkConfigFactory, T1, T2, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerModelBiasJobDefinitionNetworkConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionNetworkConfigFactory, T2, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerModelBiasJobDefinitionNetworkConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionNetworkConfigFactory, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionNetworkConfigFactory, T1, T2, T3, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerModelBiasJobDefinitionNetworkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionNetworkConfigFactory, T2, T3, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerModelBiasJobDefinitionNetworkConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionNetworkConfigFactory, T3, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionNetworkConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionNetworkConfigFactory, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionNetworkConfigFactory, T1, T2, T3, T4, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerModelBiasJobDefinitionNetworkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionNetworkConfigFactory, T2, T3, T4, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelBiasJobDefinitionNetworkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionNetworkConfigFactory, T3, T4, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionNetworkConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionNetworkConfigFactory, T4, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionNetworkConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionNetworkConfigFactory, InnerModelBiasJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
}
