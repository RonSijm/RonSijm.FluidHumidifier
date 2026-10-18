// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectDocumentOutputAdditionalFileFormatFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputAdditionalFileFormat> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputAdditionalFileFormat>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputAdditionalFileFormat Create()
    {
        var documentOutputAdditionalFileFormatResult = CreateDocumentOutputAdditionalFileFormat();
        factoryAction?.Invoke(documentOutputAdditionalFileFormatResult);

        return documentOutputAdditionalFileFormatResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputAdditionalFileFormat CreateDocumentOutputAdditionalFileFormat()
    {
        var documentOutputAdditionalFileFormatResult = new Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputAdditionalFileFormat();

        return documentOutputAdditionalFileFormatResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectDocumentOutputAdditionalFileFormatFactoryExtensions
{
}
