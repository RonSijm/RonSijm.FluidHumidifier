// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectDocumentBoundingBoxFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentBoundingBox> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentBoundingBox>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.DocumentBoundingBox Create()
    {
        var documentBoundingBoxResult = CreateDocumentBoundingBox();
        factoryAction?.Invoke(documentBoundingBoxResult);

        return documentBoundingBoxResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.DocumentBoundingBox CreateDocumentBoundingBox()
    {
        var documentBoundingBoxResult = new Humidifier.Bedrock.DataAutomationProjectTypes.DocumentBoundingBox();

        return documentBoundingBoxResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectDocumentBoundingBoxFactoryExtensions
{
}
