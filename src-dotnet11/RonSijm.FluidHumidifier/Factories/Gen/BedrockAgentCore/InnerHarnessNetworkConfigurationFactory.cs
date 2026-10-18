// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessNetworkConfigurationFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.NetworkConfiguration>
{

    internal InnerHarnessVpcConfigFactory NetworkModeConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.BedrockAgentCore.HarnessTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.NetworkConfiguration result)
    {
        base.CreateChildren(result);

        result.NetworkModeConfig ??= NetworkModeConfigFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessNetworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerHarnessNetworkConfigurationFactory, InnerHarnessVpcConfigFactory> WithNetworkModeConfig(this InnerHarnessNetworkConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.NetworkModeConfigFactory = new InnerHarnessVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkModeConfigFactory);
    }

    public static CombinedResult<InnerHarnessNetworkConfigurationFactory, T1, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1>(this CombinedResult<InnerHarnessNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessNetworkConfigurationFactory, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1>(this CombinedResult<T1, InnerHarnessNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessNetworkConfigurationFactory, T1, T2, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2>(this CombinedResult<InnerHarnessNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessNetworkConfigurationFactory, T2, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2>(this CombinedResult<T1, InnerHarnessNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessNetworkConfigurationFactory, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2>(this CombinedResult<T1, T2, InnerHarnessNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessNetworkConfigurationFactory, T1, T2, T3, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3>(this CombinedResult<InnerHarnessNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessNetworkConfigurationFactory, T2, T3, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3>(this CombinedResult<T1, InnerHarnessNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessNetworkConfigurationFactory, T3, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessNetworkConfigurationFactory, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessNetworkConfigurationFactory, T1, T2, T3, T4, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3, T4>(this CombinedResult<InnerHarnessNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessNetworkConfigurationFactory, T2, T3, T4, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessNetworkConfigurationFactory, T3, T4, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessNetworkConfigurationFactory, T4, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessNetworkConfigurationFactory, InnerHarnessVpcConfigFactory> WithNetworkModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkModeConfig(combinedResult.T5, subFactoryAction).T2);
}
