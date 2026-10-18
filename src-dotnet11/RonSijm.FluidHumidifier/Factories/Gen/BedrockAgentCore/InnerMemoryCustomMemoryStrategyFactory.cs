// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryCustomMemoryStrategyFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomMemoryStrategy> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.CustomMemoryStrategy>
{

    internal InnerMemoryCustomConfigurationInputFactory ConfigurationFactory { get; set; }

    internal InnerMemoryMemoryRecordSchemaFactory MemoryRecordSchemaFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.MemoryTypes.CustomMemoryStrategy Create()
    {
        var customMemoryStrategyResult = CreateCustomMemoryStrategy();
        factoryAction?.Invoke(customMemoryStrategyResult);

        return customMemoryStrategyResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.CustomMemoryStrategy CreateCustomMemoryStrategy()
    {
        var customMemoryStrategyResult = new Humidifier.BedrockAgentCore.MemoryTypes.CustomMemoryStrategy();

        return customMemoryStrategyResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.MemoryTypes.CustomMemoryStrategy result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
        result.MemoryRecordSchema ??= MemoryRecordSchemaFactory?.Build();
    }

} // End Of Class

public static class InnerMemoryCustomMemoryStrategyFactoryExtensions
{
    public static CombinedResult<InnerMemoryCustomMemoryStrategyFactory, InnerMemoryCustomConfigurationInputFactory> WithConfiguration(this InnerMemoryCustomMemoryStrategyFactory parentFactory, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerMemoryCustomConfigurationInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<InnerMemoryCustomMemoryStrategyFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema(this InnerMemoryCustomMemoryStrategyFactory parentFactory, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null)
    {
        parentFactory.MemoryRecordSchemaFactory = new InnerMemoryMemoryRecordSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemoryRecordSchemaFactory);
    }

    public static CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1>(this CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1>(this CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2>(this CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2, T3, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2, T3, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory, T3, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemoryCustomMemoryStrategyFactory, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemoryCustomMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2, T3, T4, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2, T3, T4, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory, T3, T4, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemoryCustomMemoryStrategyFactory, T4, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemoryCustomMemoryStrategyFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMemoryCustomMemoryStrategyFactory, InnerMemoryCustomConfigurationInputFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemoryCustomMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1>(this CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1>(this CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemoryCustomMemoryStrategyFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemoryCustomMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<InnerMemoryCustomMemoryStrategyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemoryCustomMemoryStrategyFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemoryCustomMemoryStrategyFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemoryCustomMemoryStrategyFactory, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemoryCustomMemoryStrategyFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMemoryCustomMemoryStrategyFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemoryCustomMemoryStrategyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T5, subFactoryAction).T2);
}
