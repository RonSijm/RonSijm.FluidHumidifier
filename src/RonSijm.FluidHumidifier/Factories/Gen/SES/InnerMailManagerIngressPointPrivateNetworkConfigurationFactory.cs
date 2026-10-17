// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMailManagerIngressPointPrivateNetworkConfigurationFactory(Action<Humidifier.SES.MailManagerIngressPointTypes.PrivateNetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SES.MailManagerIngressPointTypes.PrivateNetworkConfiguration>
{

    protected override Humidifier.SES.MailManagerIngressPointTypes.PrivateNetworkConfiguration Create()
    {
        var privateNetworkConfigurationResult = CreatePrivateNetworkConfiguration();
        factoryAction?.Invoke(privateNetworkConfigurationResult);

        return privateNetworkConfigurationResult;
    }

    private Humidifier.SES.MailManagerIngressPointTypes.PrivateNetworkConfiguration CreatePrivateNetworkConfiguration()
    {
        var privateNetworkConfigurationResult = new Humidifier.SES.MailManagerIngressPointTypes.PrivateNetworkConfiguration();

        return privateNetworkConfigurationResult;
    }

} // End Of Class

public static class InnerMailManagerIngressPointPrivateNetworkConfigurationFactoryExtensions
{
}
