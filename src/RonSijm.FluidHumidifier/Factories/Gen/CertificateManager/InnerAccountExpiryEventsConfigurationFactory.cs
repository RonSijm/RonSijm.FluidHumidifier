// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerAccountExpiryEventsConfigurationFactory(Action<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration>
{

    protected override Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration Create()
    {
        var expiryEventsConfigurationResult = CreateExpiryEventsConfiguration();
        factoryAction?.Invoke(expiryEventsConfigurationResult);

        return expiryEventsConfigurationResult;
    }

    private Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration CreateExpiryEventsConfiguration()
    {
        var expiryEventsConfigurationResult = new Humidifier.CertificateManager.AccountTypes.ExpiryEventsConfiguration();

        return expiryEventsConfigurationResult;
    }

} // End Of Class

public static class InnerAccountExpiryEventsConfigurationFactoryExtensions
{
}
