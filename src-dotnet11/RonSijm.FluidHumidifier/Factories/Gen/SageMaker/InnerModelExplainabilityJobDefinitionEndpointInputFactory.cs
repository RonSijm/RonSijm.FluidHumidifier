// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionEndpointInputFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.EndpointInput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.EndpointInput>
{

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.EndpointInput Create()
    {
        var endpointInputResult = CreateEndpointInput();
        factoryAction?.Invoke(endpointInputResult);

        return endpointInputResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.EndpointInput CreateEndpointInput()
    {
        var endpointInputResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.EndpointInput();

        return endpointInputResult;
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionEndpointInputFactoryExtensions
{
}
