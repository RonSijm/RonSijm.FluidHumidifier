// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionEndpointInputFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.EndpointInput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.EndpointInput>
{

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.EndpointInput Create()
    {
        var endpointInputResult = CreateEndpointInput();
        factoryAction?.Invoke(endpointInputResult);

        return endpointInputResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.EndpointInput CreateEndpointInput()
    {
        var endpointInputResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.EndpointInput();

        return endpointInputResult;
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionEndpointInputFactoryExtensions
{
}
