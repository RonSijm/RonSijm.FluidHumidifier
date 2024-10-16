// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTThingsGraph;

public class FlowTemplateFactory(string resourceName = null, Action<Humidifier.IoTThingsGraph.FlowTemplate> factoryAction = null) : ResourceFactory<Humidifier.IoTThingsGraph.FlowTemplate>(resourceName)
{

    internal InnerFlowTemplateDefinitionDocumentFactory DefinitionFactory { get; set; }

    protected override Humidifier.IoTThingsGraph.FlowTemplate Create()
    {
        var flowTemplateResult = CreateFlowTemplate();
        factoryAction?.Invoke(flowTemplateResult);

        return flowTemplateResult;
    }

    private Humidifier.IoTThingsGraph.FlowTemplate CreateFlowTemplate()
    {
        var flowTemplateResult = new Humidifier.IoTThingsGraph.FlowTemplate
        {
            GivenName = InputResourceName,
        };

        return flowTemplateResult;
    }
    public override void CreateChildren(Humidifier.IoTThingsGraph.FlowTemplate result)
    {
        base.CreateChildren(result);

        result.Definition ??= DefinitionFactory?.Build();
    }

} // End Of Class

public static class FlowTemplateFactoryExtensions
{
    public static CombinedResult<FlowTemplateFactory, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition(this FlowTemplateFactory parentFactory, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null)
    {
        parentFactory.DefinitionFactory = new InnerFlowTemplateDefinitionDocumentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefinitionFactory);
    }

    public static CombinedResult<FlowTemplateFactory, T1, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1>(this CombinedResult<FlowTemplateFactory, T1> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowTemplateFactory, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1>(this CombinedResult<T1, FlowTemplateFactory> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FlowTemplateFactory, T1, T2, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2>(this CombinedResult<FlowTemplateFactory, T1, T2> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowTemplateFactory, T2, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2>(this CombinedResult<T1, FlowTemplateFactory, T2> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowTemplateFactory, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2>(this CombinedResult<T1, T2, FlowTemplateFactory> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FlowTemplateFactory, T1, T2, T3, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2, T3>(this CombinedResult<FlowTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowTemplateFactory, T2, T3, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, FlowTemplateFactory, T2, T3> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowTemplateFactory, T3, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, FlowTemplateFactory, T3> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowTemplateFactory, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlowTemplateFactory> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FlowTemplateFactory, T1, T2, T3, T4, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<FlowTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowTemplateFactory, T2, T3, T4, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, FlowTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowTemplateFactory, T3, T4, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlowTemplateFactory, T3, T4> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowTemplateFactory, T4, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlowTemplateFactory, T4> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FlowTemplateFactory, InnerFlowTemplateDefinitionDocumentFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlowTemplateFactory> combinedResult, Action<Humidifier.IoTThingsGraph.FlowTemplateTypes.DefinitionDocument> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T5, subFactoryAction));
}
