// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerDocumentClassifierDocumentReaderConfigFactory(Action<Humidifier.Comprehend.DocumentClassifierTypes.DocumentReaderConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.DocumentClassifierTypes.DocumentReaderConfig>
{

    protected override Humidifier.Comprehend.DocumentClassifierTypes.DocumentReaderConfig Create()
    {
        var documentReaderConfigResult = CreateDocumentReaderConfig();
        factoryAction?.Invoke(documentReaderConfigResult);

        return documentReaderConfigResult;
    }

    private Humidifier.Comprehend.DocumentClassifierTypes.DocumentReaderConfig CreateDocumentReaderConfig()
    {
        var documentReaderConfigResult = new Humidifier.Comprehend.DocumentClassifierTypes.DocumentReaderConfig();

        return documentReaderConfigResult;
    }

} // End Of Class

public static class InnerDocumentClassifierDocumentReaderConfigFactoryExtensions
{
}
