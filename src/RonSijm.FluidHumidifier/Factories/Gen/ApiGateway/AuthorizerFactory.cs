// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class AuthorizerFactory(string resourceName = null, Action<Humidifier.ApiGateway.Authorizer> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.Authorizer>(resourceName)
{

    protected override Humidifier.ApiGateway.Authorizer Create()
    {
        var authorizerResult = CreateAuthorizer();
        factoryAction?.Invoke(authorizerResult);

        return authorizerResult;
    }

    private Humidifier.ApiGateway.Authorizer CreateAuthorizer()
    {
        var authorizerResult = new Humidifier.ApiGateway.Authorizer
        {
            GivenName = InputResourceName,
        };

        return authorizerResult;
    }

} // End Of Class

public static class AuthorizerFactoryExtensions
{
}
