// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionEndpointInputFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput>
{

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput Create()
    {
        var endpointInputResult = CreateEndpointInput();
        factoryAction?.Invoke(endpointInputResult);

        return endpointInputResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput CreateEndpointInput()
    {
        var endpointInputResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput();

        return endpointInputResult;
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionEndpointInputFactoryExtensions
{
}
