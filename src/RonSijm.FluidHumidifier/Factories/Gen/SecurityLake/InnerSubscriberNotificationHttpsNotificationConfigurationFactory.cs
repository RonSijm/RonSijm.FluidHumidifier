// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class InnerSubscriberNotificationHttpsNotificationConfigurationFactory(Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration>
{

    protected override Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration Create()
    {
        var httpsNotificationConfigurationResult = CreateHttpsNotificationConfiguration();
        factoryAction?.Invoke(httpsNotificationConfigurationResult);

        return httpsNotificationConfigurationResult;
    }

    private Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration CreateHttpsNotificationConfiguration()
    {
        var httpsNotificationConfigurationResult = new Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration();

        return httpsNotificationConfigurationResult;
    }

} // End Of Class

public static class InnerSubscriberNotificationHttpsNotificationConfigurationFactoryExtensions
{
}
