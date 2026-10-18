// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping Create()
    {
        var openSearchManagedClusterFieldMappingResult = CreateOpenSearchManagedClusterFieldMapping();
        factoryAction?.Invoke(openSearchManagedClusterFieldMappingResult);

        return openSearchManagedClusterFieldMappingResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping CreateOpenSearchManagedClusterFieldMapping()
    {
        var openSearchManagedClusterFieldMappingResult = new Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping();

        return openSearchManagedClusterFieldMappingResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseOpenSearchManagedClusterFieldMappingFactoryExtensions
{
}
