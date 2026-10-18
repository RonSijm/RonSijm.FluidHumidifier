// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class NotifyConfigurationFactory(string resourceName = null, Action<Humidifier.SMSVOICE.NotifyConfiguration> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.NotifyConfiguration>(resourceName)
{

    protected override Humidifier.SMSVOICE.NotifyConfiguration Create()
    {
        var notifyConfigurationResult = CreateNotifyConfiguration();
        factoryAction?.Invoke(notifyConfigurationResult);

        return notifyConfigurationResult;
    }

    private Humidifier.SMSVOICE.NotifyConfiguration CreateNotifyConfiguration()
    {
        var notifyConfigurationResult = new Humidifier.SMSVOICE.NotifyConfiguration
        {
            GivenName = InputResourceName,
        };

        return notifyConfigurationResult;
    }

} // End Of Class

public static class NotifyConfigurationFactoryExtensions
{
}
