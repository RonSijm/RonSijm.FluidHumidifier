// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMailManagerIngressPointIngressPointConfigurationFactory(Action<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration>
{

    protected override Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration Create()
    {
        var ingressPointConfigurationResult = CreateIngressPointConfiguration();
        factoryAction?.Invoke(ingressPointConfigurationResult);

        return ingressPointConfigurationResult;
    }

    private Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration CreateIngressPointConfiguration()
    {
        var ingressPointConfigurationResult = new Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration();

        return ingressPointConfigurationResult;
    }

} // End Of Class

public static class InnerMailManagerIngressPointIngressPointConfigurationFactoryExtensions
{
}
