// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerBrowserCustomBrowserNetworkConfigurationFactory(Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserNetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserNetworkConfiguration>
{

    internal InnerBrowserCustomVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserNetworkConfiguration Create()
    {
        var browserNetworkConfigurationResult = CreateBrowserNetworkConfiguration();
        factoryAction?.Invoke(browserNetworkConfigurationResult);

        return browserNetworkConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserNetworkConfiguration CreateBrowserNetworkConfiguration()
    {
        var browserNetworkConfigurationResult = new Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserNetworkConfiguration();

        return browserNetworkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserNetworkConfiguration result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerBrowserCustomBrowserNetworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerBrowserCustomBrowserNetworkConfigurationFactory, InnerBrowserCustomVpcConfigFactory> WithVpcConfig(this InnerBrowserCustomBrowserNetworkConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerBrowserCustomVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerBrowserCustomBrowserNetworkConfigurationFactory, T1, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerBrowserCustomBrowserNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomBrowserNetworkConfigurationFactory, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerBrowserCustomBrowserNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomBrowserNetworkConfigurationFactory, T1, T2, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerBrowserCustomBrowserNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomBrowserNetworkConfigurationFactory, T2, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerBrowserCustomBrowserNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomBrowserNetworkConfigurationFactory, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerBrowserCustomBrowserNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomBrowserNetworkConfigurationFactory, T1, T2, T3, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerBrowserCustomBrowserNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomBrowserNetworkConfigurationFactory, T2, T3, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerBrowserCustomBrowserNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomBrowserNetworkConfigurationFactory, T3, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerBrowserCustomBrowserNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrowserCustomBrowserNetworkConfigurationFactory, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBrowserCustomBrowserNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomBrowserNetworkConfigurationFactory, T1, T2, T3, T4, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerBrowserCustomBrowserNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomBrowserNetworkConfigurationFactory, T2, T3, T4, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerBrowserCustomBrowserNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomBrowserNetworkConfigurationFactory, T3, T4, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBrowserCustomBrowserNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrowserCustomBrowserNetworkConfigurationFactory, T4, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBrowserCustomBrowserNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBrowserCustomBrowserNetworkConfigurationFactory, InnerBrowserCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBrowserCustomBrowserNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction).T2);
}
