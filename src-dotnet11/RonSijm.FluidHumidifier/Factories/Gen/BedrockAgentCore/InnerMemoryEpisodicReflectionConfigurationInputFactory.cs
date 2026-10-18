// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryEpisodicReflectionConfigurationInputFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicReflectionConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicReflectionConfigurationInput>
{

    internal InnerMemoryMemoryRecordSchemaFactory MemoryRecordSchemaFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.MemoryTypes.EpisodicReflectionConfigurationInput Create()
    {
        var episodicReflectionConfigurationInputResult = CreateEpisodicReflectionConfigurationInput();
        factoryAction?.Invoke(episodicReflectionConfigurationInputResult);

        return episodicReflectionConfigurationInputResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.EpisodicReflectionConfigurationInput CreateEpisodicReflectionConfigurationInput()
    {
        var episodicReflectionConfigurationInputResult = new Humidifier.BedrockAgentCore.MemoryTypes.EpisodicReflectionConfigurationInput();

        return episodicReflectionConfigurationInputResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.MemoryTypes.EpisodicReflectionConfigurationInput result)
    {
        base.CreateChildren(result);

        result.MemoryRecordSchema ??= MemoryRecordSchemaFactory?.Build();
    }

} // End Of Class

public static class InnerMemoryEpisodicReflectionConfigurationInputFactoryExtensions
{
    public static CombinedResult<InnerMemoryEpisodicReflectionConfigurationInputFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema(this InnerMemoryEpisodicReflectionConfigurationInputFactory parentFactory, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null)
    {
        parentFactory.MemoryRecordSchemaFactory = new InnerMemoryMemoryRecordSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemoryRecordSchemaFactory);
    }

    public static CombinedResult<InnerMemoryEpisodicReflectionConfigurationInputFactory, T1, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1>(this CombinedResult<InnerMemoryEpisodicReflectionConfigurationInputFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryEpisodicReflectionConfigurationInputFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1>(this CombinedResult<T1, InnerMemoryEpisodicReflectionConfigurationInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryEpisodicReflectionConfigurationInputFactory, T1, T2, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<InnerMemoryEpisodicReflectionConfigurationInputFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryEpisodicReflectionConfigurationInputFactory, T2, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<T1, InnerMemoryEpisodicReflectionConfigurationInputFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryEpisodicReflectionConfigurationInputFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2>(this CombinedResult<T1, T2, InnerMemoryEpisodicReflectionConfigurationInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryEpisodicReflectionConfigurationInputFactory, T1, T2, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<InnerMemoryEpisodicReflectionConfigurationInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryEpisodicReflectionConfigurationInputFactory, T2, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, InnerMemoryEpisodicReflectionConfigurationInputFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryEpisodicReflectionConfigurationInputFactory, T3, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemoryEpisodicReflectionConfigurationInputFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemoryEpisodicReflectionConfigurationInputFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemoryEpisodicReflectionConfigurationInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryEpisodicReflectionConfigurationInputFactory, T1, T2, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<InnerMemoryEpisodicReflectionConfigurationInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryEpisodicReflectionConfigurationInputFactory, T2, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemoryEpisodicReflectionConfigurationInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryEpisodicReflectionConfigurationInputFactory, T3, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemoryEpisodicReflectionConfigurationInputFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemoryEpisodicReflectionConfigurationInputFactory, T4, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemoryEpisodicReflectionConfigurationInputFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMemoryEpisodicReflectionConfigurationInputFactory, InnerMemoryMemoryRecordSchemaFactory> WithMemoryRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemoryEpisodicReflectionConfigurationInputFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemoryRecordSchema(combinedResult.T5, subFactoryAction).T2);
}
