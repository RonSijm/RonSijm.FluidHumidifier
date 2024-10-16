// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping Create()
    {
        var openSearchServerlessFieldMappingResult = CreateOpenSearchServerlessFieldMapping();
        factoryAction?.Invoke(openSearchServerlessFieldMappingResult);

        return openSearchServerlessFieldMappingResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping CreateOpenSearchServerlessFieldMapping()
    {
        var openSearchServerlessFieldMappingResult = new Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping();

        return openSearchServerlessFieldMappingResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseOpenSearchServerlessFieldMappingFactoryExtensions
{
}
