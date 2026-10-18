// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMailManagerIngressPointPublicNetworkConfigurationFactory(Action<Humidifier.SES.MailManagerIngressPointTypes.PublicNetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SES.MailManagerIngressPointTypes.PublicNetworkConfiguration>
{

    protected override Humidifier.SES.MailManagerIngressPointTypes.PublicNetworkConfiguration Create()
    {
        var publicNetworkConfigurationResult = CreatePublicNetworkConfiguration();
        factoryAction?.Invoke(publicNetworkConfigurationResult);

        return publicNetworkConfigurationResult;
    }

    private Humidifier.SES.MailManagerIngressPointTypes.PublicNetworkConfiguration CreatePublicNetworkConfiguration()
    {
        var publicNetworkConfigurationResult = new Humidifier.SES.MailManagerIngressPointTypes.PublicNetworkConfiguration();

        return publicNetworkConfigurationResult;
    }

} // End Of Class

public static class InnerMailManagerIngressPointPublicNetworkConfigurationFactoryExtensions
{
}
