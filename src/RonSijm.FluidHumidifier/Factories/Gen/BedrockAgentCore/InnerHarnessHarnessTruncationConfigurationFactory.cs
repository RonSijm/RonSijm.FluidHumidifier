// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessTruncationConfigurationFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationConfiguration>
{

    internal InnerHarnessHarnessTruncationStrategyConfigurationFactory ConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationConfiguration Create()
    {
        var harnessTruncationConfigurationResult = CreateHarnessTruncationConfiguration();
        factoryAction?.Invoke(harnessTruncationConfigurationResult);

        return harnessTruncationConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationConfiguration CreateHarnessTruncationConfiguration()
    {
        var harnessTruncationConfigurationResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationConfiguration();

        return harnessTruncationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationConfiguration result)
    {
        base.CreateChildren(result);

        result.Config ??= ConfigFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessTruncationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessTruncationConfigurationFactory, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig(this InnerHarnessHarnessTruncationConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigFactory = new InnerHarnessHarnessTruncationStrategyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigFactory);
    }

    public static CombinedResult<InnerHarnessHarnessTruncationConfigurationFactory, T1, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1>(this CombinedResult<InnerHarnessHarnessTruncationConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessTruncationConfigurationFactory, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1>(this CombinedResult<T1, InnerHarnessHarnessTruncationConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessTruncationConfigurationFactory, T1, T2, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2>(this CombinedResult<InnerHarnessHarnessTruncationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessTruncationConfigurationFactory, T2, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessTruncationConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessTruncationConfigurationFactory, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessTruncationConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessTruncationConfigurationFactory, T1, T2, T3, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessTruncationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessTruncationConfigurationFactory, T2, T3, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessTruncationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessTruncationConfigurationFactory, T3, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessTruncationConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessTruncationConfigurationFactory, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessTruncationConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessTruncationConfigurationFactory, T1, T2, T3, T4, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessTruncationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessTruncationConfigurationFactory, T2, T3, T4, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessTruncationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessTruncationConfigurationFactory, T3, T4, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessTruncationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessTruncationConfigurationFactory, T4, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessTruncationConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessTruncationConfigurationFactory, InnerHarnessHarnessTruncationStrategyConfigurationFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessTruncationConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTruncationStrategyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T5, subFactoryAction).T2);
}
