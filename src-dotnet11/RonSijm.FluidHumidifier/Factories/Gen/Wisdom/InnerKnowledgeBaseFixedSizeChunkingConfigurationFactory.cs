// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseFixedSizeChunkingConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.FixedSizeChunkingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.FixedSizeChunkingConfiguration>
{

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.FixedSizeChunkingConfiguration Create()
    {
        var fixedSizeChunkingConfigurationResult = CreateFixedSizeChunkingConfiguration();
        factoryAction?.Invoke(fixedSizeChunkingConfigurationResult);

        return fixedSizeChunkingConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.FixedSizeChunkingConfiguration CreateFixedSizeChunkingConfiguration()
    {
        var fixedSizeChunkingConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.FixedSizeChunkingConfiguration();

        return fixedSizeChunkingConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseFixedSizeChunkingConfigurationFactoryExtensions
{
}
