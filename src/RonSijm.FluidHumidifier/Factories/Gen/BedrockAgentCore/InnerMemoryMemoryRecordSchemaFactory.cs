// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryMemoryRecordSchemaFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema Create()
    {
        var memoryRecordSchemaResult = CreateMemoryRecordSchema();
        factoryAction?.Invoke(memoryRecordSchemaResult);

        return memoryRecordSchemaResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema CreateMemoryRecordSchema()
    {
        var memoryRecordSchemaResult = new Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema();

        return memoryRecordSchemaResult;
    }

} // End Of Class

public static class InnerMemoryMemoryRecordSchemaFactoryExtensions
{
}
