// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectDocumentStandardGenerativeFieldFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardGenerativeField> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardGenerativeField>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardGenerativeField Create()
    {
        var documentStandardGenerativeFieldResult = CreateDocumentStandardGenerativeField();
        factoryAction?.Invoke(documentStandardGenerativeFieldResult);

        return documentStandardGenerativeFieldResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardGenerativeField CreateDocumentStandardGenerativeField()
    {
        var documentStandardGenerativeFieldResult = new Humidifier.Bedrock.DataAutomationProjectTypes.DocumentStandardGenerativeField();

        return documentStandardGenerativeFieldResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectDocumentStandardGenerativeFieldFactoryExtensions
{
}
