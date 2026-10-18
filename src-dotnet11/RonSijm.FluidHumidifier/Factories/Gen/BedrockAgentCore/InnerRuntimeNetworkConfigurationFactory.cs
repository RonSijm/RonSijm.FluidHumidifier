// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeNetworkConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.NetworkConfiguration>
{

    internal InnerRuntimeVpcConfigFactory NetworkModeConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.RuntimeTypes.NetworkConfiguration result)
    {
        base.CreateChildren(result);

        result.NetworkModeConfig ??= NetworkModeConfigFactory?.Build();
    }

} // End Of Class

public static class InnerRuntimeNetworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRuntimeNetworkConfigurationFactory, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig(this InnerRuntimeNetworkConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.NetworkModeConfigFactory = new InnerRuntimeVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkModeConfigFactory);
    }

    public static CombinedResult<InnerRuntimeNetworkConfigurationFactory, T1, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1>(this CombinedResult<InnerRuntimeNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeNetworkConfigurationFactory, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1>(this CombinedResult<T1, InnerRuntimeNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeNetworkConfigurationFactory, T1, T2, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2>(this CombinedResult<InnerRuntimeNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeNetworkConfigurationFactory, T2, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2>(this CombinedResult<T1, InnerRuntimeNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeNetworkConfigurationFactory, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2>(this CombinedResult<T1, T2, InnerRuntimeNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeNetworkConfigurationFactory, T1, T2, T3, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3>(this CombinedResult<InnerRuntimeNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeNetworkConfigurationFactory, T2, T3, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3>(this CombinedResult<T1, InnerRuntimeNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeNetworkConfigurationFactory, T3, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuntimeNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuntimeNetworkConfigurationFactory, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuntimeNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRuntimeNetworkConfigurationFactory, T1, T2, T3, T4, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3, T4>(this CombinedResult<InnerRuntimeNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuntimeNetworkConfigurationFactory, T2, T3, T4, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuntimeNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuntimeNetworkConfigurationFactory, T3, T4, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuntimeNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuntimeNetworkConfigurationFactory, T4, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuntimeNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRuntimeNetworkConfigurationFactory, InnerRuntimeVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuntimeNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.RuntimeTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T5, subFactoryAction).T2);
}
