// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class RequestValidatorFactory(string resourceName = null, Action<Humidifier.ApiGateway.RequestValidator> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.RequestValidator>(resourceName)
{

    protected override Humidifier.ApiGateway.RequestValidator Create()
    {
        var requestValidatorResult = CreateRequestValidator();
        factoryAction?.Invoke(requestValidatorResult);

        return requestValidatorResult;
    }

    private Humidifier.ApiGateway.RequestValidator CreateRequestValidator()
    {
        var requestValidatorResult = new Humidifier.ApiGateway.RequestValidator
        {
            GivenName = InputResourceName,
        };

        return requestValidatorResult;
    }

} // End Of Class

public static class RequestValidatorFactoryExtensions
{
}
