// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerClientVpnEndpointClientLoginBannerOptionsFactory(Action<Humidifier.EC2.ClientVpnEndpointTypes.ClientLoginBannerOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ClientVpnEndpointTypes.ClientLoginBannerOptions>
{

    protected override Humidifier.EC2.ClientVpnEndpointTypes.ClientLoginBannerOptions Create()
    {
        var clientLoginBannerOptionsResult = CreateClientLoginBannerOptions();
        factoryAction?.Invoke(clientLoginBannerOptionsResult);

        return clientLoginBannerOptionsResult;
    }

    private Humidifier.EC2.ClientVpnEndpointTypes.ClientLoginBannerOptions CreateClientLoginBannerOptions()
    {
        var clientLoginBannerOptionsResult = new Humidifier.EC2.ClientVpnEndpointTypes.ClientLoginBannerOptions();

        return clientLoginBannerOptionsResult;
    }

} // End Of Class

public static class InnerClientVpnEndpointClientLoginBannerOptionsFactoryExtensions
{
}
