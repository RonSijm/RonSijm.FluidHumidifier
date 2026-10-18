// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseHierarchicalChunkingConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.HierarchicalChunkingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.HierarchicalChunkingConfiguration>
{

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.HierarchicalChunkingConfiguration Create()
    {
        var hierarchicalChunkingConfigurationResult = CreateHierarchicalChunkingConfiguration();
        factoryAction?.Invoke(hierarchicalChunkingConfigurationResult);

        return hierarchicalChunkingConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.HierarchicalChunkingConfiguration CreateHierarchicalChunkingConfiguration()
    {
        var hierarchicalChunkingConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.HierarchicalChunkingConfiguration();

        return hierarchicalChunkingConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseHierarchicalChunkingConfigurationFactoryExtensions
{
}
