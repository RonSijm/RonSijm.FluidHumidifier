// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionNetworkConfigFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.NetworkConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.NetworkConfig>
{

    internal InnerDataQualityJobDefinitionVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.NetworkConfig Create()
    {
        var networkConfigResult = CreateNetworkConfig();
        factoryAction?.Invoke(networkConfigResult);

        return networkConfigResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.NetworkConfig CreateNetworkConfig()
    {
        var networkConfigResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.NetworkConfig();

        return networkConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DataQualityJobDefinitionTypes.NetworkConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionNetworkConfigFactoryExtensions
{
    public static CombinedResult<InnerDataQualityJobDefinitionNetworkConfigFactory, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig(this InnerDataQualityJobDefinitionNetworkConfigFactory parentFactory, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerDataQualityJobDefinitionVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerDataQualityJobDefinitionNetworkConfigFactory, T1, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerDataQualityJobDefinitionNetworkConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionNetworkConfigFactory, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerDataQualityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionNetworkConfigFactory, T1, T2, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerDataQualityJobDefinitionNetworkConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionNetworkConfigFactory, T2, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerDataQualityJobDefinitionNetworkConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionNetworkConfigFactory, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionNetworkConfigFactory, T1, T2, T3, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerDataQualityJobDefinitionNetworkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionNetworkConfigFactory, T2, T3, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerDataQualityJobDefinitionNetworkConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionNetworkConfigFactory, T3, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionNetworkConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionNetworkConfigFactory, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionNetworkConfigFactory, T1, T2, T3, T4, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerDataQualityJobDefinitionNetworkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionNetworkConfigFactory, T2, T3, T4, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataQualityJobDefinitionNetworkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionNetworkConfigFactory, T3, T4, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionNetworkConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionNetworkConfigFactory, T4, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionNetworkConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionNetworkConfigFactory, InnerDataQualityJobDefinitionVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
}
