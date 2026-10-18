// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideReflectionConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideReflectionConfigurationInput>
{

    internal InnerMemoryMemoryRecordSchemaFactory MemoryRecordSchemaFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideReflectionConfigurationInput Create()
    {
        var episodicOverrideReflectionConfigurationInputResult = CreateEpisodicOverrideReflectionConfigurationInput();
        factoryAction?.Invoke(episodicOverrideReflectionConfigurationInputResult);

        return episodicOverrideReflectionConfigurationInputResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideReflectionConfigurationInput CreateEpisodicOverrideReflectionConfigurationInput()
    {
        var episodicOverrideReflectionConfigurationInputResult = new Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideReflectionConfigurationInput();

        return episodicOverrideReflectionConfigurationInputResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideReflectionConfigurationInput result)
    {
        base.CreateChildren(result);

        result.MemoryRecordSchema ??= MemoryRecordSchemaFactory?.Build();
    }

} // End Of Class

public static class InnerMemoryEpisodicOverrideReflectionConfigurationInputFactoryExtensions
{
    public static CombinedResult<InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema(this InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory parentFactory, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null)
    {
        parentFactory.MemoryRecordSchemaFactory = new InnerMemoryMemoryRecordSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemoryRecordSchemaFactory);
    }

    public static CombinedResult<InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T1, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1>(this CombinedResult<InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1>(this CombinedResult<T1, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T1, T2, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T2, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<T1, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<T1, T2, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T1, T2, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T2, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T1, T2, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T2, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemoryEpisodicOverrideReflectionConfigurationInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T5, subFactoryAction).T2);
}
