// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessToolFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTool> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessTool>
{

    internal InnerHarnessHarnessToolConfigurationFactory ConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessTool Create()
    {
        var harnessToolResult = CreateHarnessTool();
        factoryAction?.Invoke(harnessToolResult);

        return harnessToolResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessTool CreateHarnessTool()
    {
        var harnessToolResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessTool();

        return harnessToolResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessTool result)
    {
        base.CreateChildren(result);

        result.Config ??= ConfigFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessToolFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessToolFactory, InnerHarnessHarnessToolConfigurationFactory> WithConfig(this InnerHarnessHarnessToolFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigFactory = new InnerHarnessHarnessToolConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigFactory);
    }

    public static CombinedResult<InnerHarnessHarnessToolFactory, T1, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1>(this CombinedResult<InnerHarnessHarnessToolFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessToolFactory, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1>(this CombinedResult<T1, InnerHarnessHarnessToolFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessToolFactory, T1, T2, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2>(this CombinedResult<InnerHarnessHarnessToolFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessToolFactory, T2, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessToolFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessToolFactory, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessToolFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessToolFactory, T1, T2, T3, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessToolFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessToolFactory, T2, T3, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessToolFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessToolFactory, T3, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessToolFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessToolFactory, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessToolFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessToolFactory, T1, T2, T3, T4, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessToolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessToolFactory, T2, T3, T4, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessToolFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessToolFactory, T3, T4, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessToolFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessToolFactory, T4, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessToolFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessToolFactory, InnerHarnessHarnessToolConfigurationFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessToolFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessToolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T5, subFactoryAction).T2);
}
