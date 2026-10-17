// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory(Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration>
{

    internal InnerCodeInterpreterCustomVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration Create()
    {
        var codeInterpreterNetworkConfigurationResult = CreateCodeInterpreterNetworkConfiguration();
        factoryAction?.Invoke(codeInterpreterNetworkConfigurationResult);

        return codeInterpreterNetworkConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration CreateCodeInterpreterNetworkConfiguration()
    {
        var codeInterpreterNetworkConfigurationResult = new Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration();

        return codeInterpreterNetworkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig(this InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerCodeInterpreterCustomVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T1, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T1, T2, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T2, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T1, T2, T3, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T2, T3, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T3, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T1, T2, T3, T4, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T2, T3, T4, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T3, T4, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T4, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory, InnerCodeInterpreterCustomVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCodeInterpreterCustomCodeInterpreterNetworkConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction).T2);
}
