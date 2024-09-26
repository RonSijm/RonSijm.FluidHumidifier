// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionEndpointInputFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.EndpointInput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.EndpointInput>
{

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.EndpointInput Create()
    {
        var endpointInputResult = CreateEndpointInput();
        factoryAction?.Invoke(endpointInputResult);

        return endpointInputResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.EndpointInput CreateEndpointInput()
    {
        var endpointInputResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.EndpointInput();

        return endpointInputResult;
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionEndpointInputFactoryExtensions
{
}
