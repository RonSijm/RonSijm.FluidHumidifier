// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerSipMediaApplicationSipMediaApplicationEndpointFactory(Action<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint>
{

    protected override Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint Create()
    {
        var sipMediaApplicationEndpointResult = CreateSipMediaApplicationEndpoint();
        factoryAction?.Invoke(sipMediaApplicationEndpointResult);

        return sipMediaApplicationEndpointResult;
    }

    private Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint CreateSipMediaApplicationEndpoint()
    {
        var sipMediaApplicationEndpointResult = new Humidifier.Chime.SipMediaApplicationTypes.SipMediaApplicationEndpoint();

        return sipMediaApplicationEndpointResult;
    }

} // End Of Class

public static class InnerSipMediaApplicationSipMediaApplicationEndpointFactoryExtensions
{
}
