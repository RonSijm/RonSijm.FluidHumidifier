// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTThingsGraph;

public class InnerFlowTemplateDefinitionDocumentFactory(Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> factoryAction = null) : SubResourceFactory<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument>
{

    protected override Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument Create()
    {
        var definitionDocumentResult = CreateDefinitionDocument();
        factoryAction?.Invoke(definitionDocumentResult);

        return definitionDocumentResult;
    }

    private Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument CreateDefinitionDocument()
    {
        var definitionDocumentResult = new Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument();

        return definitionDocumentResult;
    }

} // End Of Class

public static class InnerFlowTemplateDefinitionDocumentFactoryExtensions
{
}
