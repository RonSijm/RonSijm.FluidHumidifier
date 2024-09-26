// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class EndpointAccessFactory(string resourceName = null, Action<Humidifier.Redshift.EndpointAccess> factoryAction = null) : ResourceFactory<Humidifier.Redshift.EndpointAccess>(resourceName)
{

    protected override Humidifier.Redshift.EndpointAccess Create()
    {
        var endpointAccessResult = CreateEndpointAccess();
        factoryAction?.Invoke(endpointAccessResult);

        return endpointAccessResult;
    }

    private Humidifier.Redshift.EndpointAccess CreateEndpointAccess()
    {
        var endpointAccessResult = new Humidifier.Redshift.EndpointAccess
        {
            GivenName = InputResourceName,
        };

        return endpointAccessResult;
    }

} // End Of Class

public static class EndpointAccessFactoryExtensions
{
}
