// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseMongoDbAtlasFieldMappingFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping Create()
    {
        var mongoDbAtlasFieldMappingResult = CreateMongoDbAtlasFieldMapping();
        factoryAction?.Invoke(mongoDbAtlasFieldMappingResult);

        return mongoDbAtlasFieldMappingResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping CreateMongoDbAtlasFieldMapping()
    {
        var mongoDbAtlasFieldMappingResult = new Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping();

        return mongoDbAtlasFieldMappingResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseMongoDbAtlasFieldMappingFactoryExtensions
{
}
