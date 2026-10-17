// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemorySummaryOverrideFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverride> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverride>
{

    internal InnerMemorySummaryOverrideConsolidationConfigurationInputFactory ConsolidationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverride Create()
    {
        var summaryOverrideResult = CreateSummaryOverride();
        factoryAction?.Invoke(summaryOverrideResult);

        return summaryOverrideResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverride CreateSummaryOverride()
    {
        var summaryOverrideResult = new Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverride();

        return summaryOverrideResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverride result)
    {
        base.CreateChildren(result);

        result.Consolidation ??= ConsolidationFactory?.Build();
    }

} // End Of Class

public static class InnerMemorySummaryOverrideFactoryExtensions
{
    public static CombinedResult<InnerMemorySummaryOverrideFactory, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation(this InnerMemorySummaryOverrideFactory parentFactory, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null)
    {
        parentFactory.ConsolidationFactory = new InnerMemorySummaryOverrideConsolidationConfigurationInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConsolidationFactory);
    }

    public static CombinedResult<InnerMemorySummaryOverrideFactory, T1, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1>(this CombinedResult<InnerMemorySummaryOverrideFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithConsolidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySummaryOverrideFactory, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1>(this CombinedResult<T1, InnerMemorySummaryOverrideFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithConsolidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMemorySummaryOverrideFactory, T1, T2, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2>(this CombinedResult<InnerMemorySummaryOverrideFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySummaryOverrideFactory, T2, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2>(this CombinedResult<T1, InnerMemorySummaryOverrideFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemorySummaryOverrideFactory, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2>(this CombinedResult<T1, T2, InnerMemorySummaryOverrideFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMemorySummaryOverrideFactory, T1, T2, T3, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2, T3>(this CombinedResult<InnerMemorySummaryOverrideFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySummaryOverrideFactory, T2, T3, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2, T3>(this CombinedResult<T1, InnerMemorySummaryOverrideFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemorySummaryOverrideFactory, T3, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemorySummaryOverrideFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemorySummaryOverrideFactory, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemorySummaryOverrideFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMemorySummaryOverrideFactory, T1, T2, T3, T4, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2, T3, T4>(this CombinedResult<InnerMemorySummaryOverrideFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySummaryOverrideFactory, T2, T3, T4, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemorySummaryOverrideFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemorySummaryOverrideFactory, T3, T4, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemorySummaryOverrideFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemorySummaryOverrideFactory, T4, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemorySummaryOverrideFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMemorySummaryOverrideFactory, InnerMemorySummaryOverrideConsolidationConfigurationInputFactory> WithConsolidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemorySummaryOverrideFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConsolidation(combinedResult.T5, subFactoryAction).T2);
}
