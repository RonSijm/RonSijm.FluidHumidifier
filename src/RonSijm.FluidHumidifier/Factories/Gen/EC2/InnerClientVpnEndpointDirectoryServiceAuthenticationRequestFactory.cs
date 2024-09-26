// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointDirectoryServiceAuthenticationRequestFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.DirectoryServiceAuthenticationRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.DirectoryServiceAuthenticationRequest>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.DirectoryServiceAuthenticationRequest Create()
    {
        var directoryServiceAuthenticationRequestResult = CreateDirectoryServiceAuthenticationRequest();
        factoryAction?.Invoke(directoryServiceAuthenticationRequestResult);

        return directoryServiceAuthenticationRequestResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.DirectoryServiceAuthenticationRequest CreateDirectoryServiceAuthenticationRequest()
    {
        var directoryServiceAuthenticationRequestResult = new Humidifier.EC2.ClientVpnEndpointTypes.DirectoryServiceAuthenticationRequest();

        return directoryServiceAuthenticationRequestResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointDirectoryServiceAuthenticationRequestFactoryExtensions
{
}
