// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryIndexedKeyFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.IndexedKey> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.IndexedKey>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.IndexedKey Create()
    {
        var indexedKeyResult = CreateIndexedKey();
        factoryAction?.Invoke(indexedKeyResult);

        return indexedKeyResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.IndexedKey CreateIndexedKey()
    {
        var indexedKeyResult = new Humidifier.BedrockAgentCore.MemoryTypes.IndexedKey();

        return indexedKeyResult;
    }

} // End Of Class

public static class InnerMemoryIndexedKeyFactoryExtensions
{
}
