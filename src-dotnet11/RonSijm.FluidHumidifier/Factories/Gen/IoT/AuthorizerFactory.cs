// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class AuthorizerFactory(string resourceName = null, Action<Humidifier.IoT.Authorizer> factoryAction = null) : ResourceFactory<Humidifier.IoT.Authorizer>(resourceName)
{

    protected override Humidifier.IoT.Authorizer Create()
    {
        var authorizerResult = CreateAuthorizer();
        factoryAction?.Invoke(authorizerResult);

        return authorizerResult;
    }

    private Humidifier.IoT.Authorizer CreateAuthorizer()
    {
        var authorizerResult = new Humidifier.IoT.Authorizer
        {
            GivenName = InputResourceName,
        };

        return authorizerResult;
    }

} // End Of Class

public static class AuthorizerFactoryExtensions
{
}
