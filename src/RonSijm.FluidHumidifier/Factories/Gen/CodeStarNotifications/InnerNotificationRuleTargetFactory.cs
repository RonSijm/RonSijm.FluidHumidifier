// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeStarNotifications;

public class InnerNotificationRuleTargetFactory(Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> factoryAction = null) : SubResourceFactory<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target>
{

    protected override Humidifier.CodeStarNotifications.NotificationRuleTypes.Target Create()
    {
        var targetResult = CreateTarget();
        factoryAction?.Invoke(targetResult);

        return targetResult;
    }

    private Humidifier.CodeStarNotifications.NotificationRuleTypes.Target CreateTarget()
    {
        var targetResult = new Humidifier.CodeStarNotifications.NotificationRuleTypes.Target();

        return targetResult;
    }

} // End Of Class

public static class InnerNotificationRuleTargetFactoryExtensions
{
}
