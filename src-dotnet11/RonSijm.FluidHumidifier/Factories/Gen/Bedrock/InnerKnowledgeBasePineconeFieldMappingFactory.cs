// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBasePineconeFieldMappingFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping Create()
    {
        var pineconeFieldMappingResult = CreatePineconeFieldMapping();
        factoryAction?.Invoke(pineconeFieldMappingResult);

        return pineconeFieldMappingResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping CreatePineconeFieldMapping()
    {
        var pineconeFieldMappingResult = new Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping();

        return pineconeFieldMappingResult;
    }

} // End Of Class

public static class InnerKnowledgeBasePineconeFieldMappingFactoryExtensions
{
}
