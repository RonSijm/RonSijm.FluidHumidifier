// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerMethodMethodResponseFactory(Action<Humidifier.ApiGateway.MethodTypes.MethodResponse> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.MethodTypes.MethodResponse>
{

    protected override Humidifier.ApiGateway.MethodTypes.MethodResponse Create()
    {
        var methodResponseResult = CreateMethodResponse();
        factoryAction?.Invoke(methodResponseResult);

        return methodResponseResult;
    }

    private Humidifier.ApiGateway.MethodTypes.MethodResponse CreateMethodResponse()
    {
        var methodResponseResult = new Humidifier.ApiGateway.MethodTypes.MethodResponse();

        return methodResponseResult;
    }

} // End Of Class

public static class InnerMethodMethodResponseFactoryExtensions
{
}
