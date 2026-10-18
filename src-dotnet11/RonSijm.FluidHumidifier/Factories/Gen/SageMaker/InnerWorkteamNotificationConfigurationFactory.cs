// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerWorkteamNotificationConfigurationFactory(Action<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration>
{

    protected override Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration Create()
    {
        var notificationConfigurationResult = CreateNotificationConfiguration();
        factoryAction?.Invoke(notificationConfigurationResult);

        return notificationConfigurationResult;
    }

    private Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration CreateNotificationConfiguration()
    {
        var notificationConfigurationResult = new Humidifier.SageMaker.WorkteamTypes.NotificationConfiguration();

        return notificationConfigurationResult;
    }

} // End Of Class

public static class InnerWorkteamNotificationConfigurationFactoryExtensions
{
}
