// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupNotificationConfigurationFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.NotificationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.NotificationConfiguration>
{

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.NotificationConfiguration Create()
    {
        var notificationConfigurationResult = CreateNotificationConfiguration();
        factoryAction?.Invoke(notificationConfigurationResult);

        return notificationConfigurationResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.NotificationConfiguration CreateNotificationConfiguration()
    {
        var notificationConfigurationResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.NotificationConfiguration();

        return notificationConfigurationResult;
    }

} // End Of Class

public static class InnerAutoScalingGroupNotificationConfigurationFactoryExtensions
{
}
