// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseSemanticChunkingConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.SemanticChunkingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.SemanticChunkingConfiguration>
{

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.SemanticChunkingConfiguration Create()
    {
        var semanticChunkingConfigurationResult = CreateSemanticChunkingConfiguration();
        factoryAction?.Invoke(semanticChunkingConfigurationResult);

        return semanticChunkingConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.SemanticChunkingConfiguration CreateSemanticChunkingConfiguration()
    {
        var semanticChunkingConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.SemanticChunkingConfiguration();

        return semanticChunkingConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseSemanticChunkingConfigurationFactoryExtensions
{
}
