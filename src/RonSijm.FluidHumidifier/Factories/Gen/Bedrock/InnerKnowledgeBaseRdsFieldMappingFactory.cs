// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseRdsFieldMappingFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping Create()
    {
        var rdsFieldMappingResult = CreateRdsFieldMapping();
        factoryAction?.Invoke(rdsFieldMappingResult);

        return rdsFieldMappingResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping CreateRdsFieldMapping()
    {
        var rdsFieldMappingResult = new Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping();

        return rdsFieldMappingResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseRdsFieldMappingFactoryExtensions
{
}
