// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceIngressConfigurationFactory(Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.IngressConfiguration>
{

    protected override Humidifier.AppRunner.ServiceTypes.IngressConfiguration Create()
    {
        var ingressConfigurationResult = CreateIngressConfiguration();
        factoryAction?.Invoke(ingressConfigurationResult);

        return ingressConfigurationResult;
    }

    private Humidifier.AppRunner.ServiceTypes.IngressConfiguration CreateIngressConfiguration()
    {
        var ingressConfigurationResult = new Humidifier.AppRunner.ServiceTypes.IngressConfiguration();

        return ingressConfigurationResult;
    }

} // End Of Class

public static class InnerServiceIngressConfigurationFactoryExtensions
{
}
