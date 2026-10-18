// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectDocumentOutputTextFormatFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputTextFormat> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputTextFormat>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputTextFormat Create()
    {
        var documentOutputTextFormatResult = CreateDocumentOutputTextFormat();
        factoryAction?.Invoke(documentOutputTextFormatResult);

        return documentOutputTextFormatResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputTextFormat CreateDocumentOutputTextFormat()
    {
        var documentOutputTextFormatResult = new Humidifier.Bedrock.DataAutomationProjectTypes.DocumentOutputTextFormat();

        return documentOutputTextFormatResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectDocumentOutputTextFormatFactoryExtensions
{
}
