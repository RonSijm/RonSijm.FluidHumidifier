// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointFederatedAuthenticationRequestFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.FederatedAuthenticationRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.FederatedAuthenticationRequest>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.FederatedAuthenticationRequest Create()
    {
        var federatedAuthenticationRequestResult = CreateFederatedAuthenticationRequest();
        factoryAction?.Invoke(federatedAuthenticationRequestResult);

        return federatedAuthenticationRequestResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.FederatedAuthenticationRequest CreateFederatedAuthenticationRequest()
    {
        var federatedAuthenticationRequestResult = new Humidifier.EC2.ClientVpnEndpointTypes.FederatedAuthenticationRequest();

        return federatedAuthenticationRequestResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointFederatedAuthenticationRequestFactoryExtensions
{
}
