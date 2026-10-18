// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration Create()
    {
        var bedrockEmbeddingModelConfigurationResult = CreateBedrockEmbeddingModelConfiguration();
        factoryAction?.Invoke(bedrockEmbeddingModelConfigurationResult);

        return bedrockEmbeddingModelConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration CreateBedrockEmbeddingModelConfiguration()
    {
        var bedrockEmbeddingModelConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration();

        return bedrockEmbeddingModelConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseBedrockEmbeddingModelConfigurationFactoryExtensions
{
}
