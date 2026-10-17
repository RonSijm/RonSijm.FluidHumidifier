// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectDocumentExtractionGranularityFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentExtractionGranularity> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentExtractionGranularity>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.DocumentExtractionGranularity Create()
    {
        var documentExtractionGranularityResult = CreateDocumentExtractionGranularity();
        factoryAction?.Invoke(documentExtractionGranularityResult);

        return documentExtractionGranularityResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.DocumentExtractionGranularity CreateDocumentExtractionGranularity()
    {
        var documentExtractionGranularityResult = new Humidifier.Bedrock.DataAutomationProjectTypes.DocumentExtractionGranularity();

        return documentExtractionGranularityResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectDocumentExtractionGranularityFactoryExtensions
{
}
