// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping Create()
    {
        var neptuneAnalyticsFieldMappingResult = CreateNeptuneAnalyticsFieldMapping();
        factoryAction?.Invoke(neptuneAnalyticsFieldMappingResult);

        return neptuneAnalyticsFieldMappingResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping CreateNeptuneAnalyticsFieldMapping()
    {
        var neptuneAnalyticsFieldMappingResult = new Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping();

        return neptuneAnalyticsFieldMappingResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseNeptuneAnalyticsFieldMappingFactoryExtensions
{
}
