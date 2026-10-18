// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class EndpointAuthorizationFactory(string resourceName = null, Action<Humidifier.Redshift.EndpointAuthorization> factoryAction = null) : ResourceFactory<Humidifier.Redshift.EndpointAuthorization>(resourceName)
{

    protected override Humidifier.Redshift.EndpointAuthorization Create()
    {
        var endpointAuthorizationResult = CreateEndpointAuthorization();
        factoryAction?.Invoke(endpointAuthorizationResult);

        return endpointAuthorizationResult;
    }

    private Humidifier.Redshift.EndpointAuthorization CreateEndpointAuthorization()
    {
        var endpointAuthorizationResult = new Humidifier.Redshift.EndpointAuthorization
        {
            GivenName = InputResourceName,
        };

        return endpointAuthorizationResult;
    }

} // End Of Class

public static class EndpointAuthorizationFactoryExtensions
{
}
