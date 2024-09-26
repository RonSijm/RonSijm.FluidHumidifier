// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RefactorSpaces;

public class InnerServiceLambdaEndpointInputFactory(Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> factoryAction = null) : SubResourceFactory<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput>
{

    protected override Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput Create()
    {
        var lambdaEndpointInputResult = CreateLambdaEndpointInput();
        factoryAction?.Invoke(lambdaEndpointInputResult);

        return lambdaEndpointInputResult;
    }

    private Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput CreateLambdaEndpointInput()
    {
        var lambdaEndpointInputResult = new Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput();

        return lambdaEndpointInputResult;
    }

} // End Of Class

public static class InnerServiceLambdaEndpointInputFactoryExtensions
{
}
