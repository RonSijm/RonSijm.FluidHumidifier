// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory(Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig>
{

    protected override Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig Create()
    {
        var externalBedrockKnowledgeBaseConfigResult = CreateExternalBedrockKnowledgeBaseConfig();
        factoryAction?.Invoke(externalBedrockKnowledgeBaseConfigResult);

        return externalBedrockKnowledgeBaseConfigResult;
    }

    private Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig CreateExternalBedrockKnowledgeBaseConfig()
    {
        var externalBedrockKnowledgeBaseConfigResult = new Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig();

        return externalBedrockKnowledgeBaseConfigResult;
    }

} // End Of Class

public static class InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactoryExtensions
{
}
