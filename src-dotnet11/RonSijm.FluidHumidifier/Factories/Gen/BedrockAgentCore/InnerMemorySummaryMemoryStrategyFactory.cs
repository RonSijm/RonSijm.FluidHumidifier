// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemorySummaryMemoryStrategyFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.SummaryMemoryStrategy> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.SummaryMemoryStrategy>
{

    internal InnerMemoryMemoryRecordSchemaFactory MemoryRecordSchemaFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.MemoryTypes.SummaryMemoryStrategy Create()
    {
        var summaryMemoryStrategyResult = CreateSummaryMemoryStrategy();
        factoryAction?.Invoke(summaryMemoryStrategyResult);

        return summaryMemoryStrategyResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.SummaryMemoryStrategy CreateSummaryMemoryStrategy()
    {
        var summaryMemoryStrategyResult = new Humidifier.BedrockAgentCore.MemoryTypes.SummaryMemoryStrategy();

        return summaryMemoryStrategyResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.MemoryTypes.SummaryMemoryStrategy result)
    {
        base.CreateChildren(result);

        result.MemoryRecordSchema ??= MemoryRecordSchemaFactory?.Build();
    }

} // End Of Class

public static class InnerMemorySummaryMemoryStrategyFactoryExtensions
{
    public static CombinedResult<InnerMemorySummaryMemoryStrategyFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema(this InnerMemorySummaryMemoryStrategyFactory parentFactory, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null)
    {
        parentFactory.MemoryRecordSchemaFactory = new InnerMemoryMemoryRecordSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemoryRecordSchemaFactory);
    }

    public static CombinedResult<InnerMemorySummaryMemoryStrategyFactory, T1, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1>(this CombinedResult<InnerMemorySummaryMemoryStrategyFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySummaryMemoryStrategyFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1>(this CombinedResult<T1, InnerMemorySummaryMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMemorySummaryMemoryStrategyFactory, T1, T2, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<InnerMemorySummaryMemoryStrategyFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySummaryMemoryStrategyFactory, T2, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<T1, InnerMemorySummaryMemoryStrategyFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemorySummaryMemoryStrategyFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<T1, T2, InnerMemorySummaryMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMemorySummaryMemoryStrategyFactory, T1, T2, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<InnerMemorySummaryMemoryStrategyFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySummaryMemoryStrategyFactory, T2, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, InnerMemorySummaryMemoryStrategyFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemorySummaryMemoryStrategyFactory, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemorySummaryMemoryStrategyFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemorySummaryMemoryStrategyFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemorySummaryMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMemorySummaryMemoryStrategyFactory, T1, T2, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<InnerMemorySummaryMemoryStrategyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySummaryMemoryStrategyFactory, T2, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemorySummaryMemoryStrategyFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemorySummaryMemoryStrategyFactory, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemorySummaryMemoryStrategyFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemorySummaryMemoryStrategyFactory, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemorySummaryMemoryStrategyFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMemorySummaryMemoryStrategyFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemorySummaryMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T5, subFactoryAction).T2);
}
