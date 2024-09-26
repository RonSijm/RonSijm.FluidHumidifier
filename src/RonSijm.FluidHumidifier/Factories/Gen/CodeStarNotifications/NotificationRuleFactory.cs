// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeStarNotifications;

public class NotificationRuleFactory(string resourceName = null, Action<Humidifier.CodeStarNotifications.NotificationRule> factoryAction = null) : ResourceFactory<Humidifier.CodeStarNotifications.NotificationRule>(resourceName)
{

    internal List<InnerNotificationRuleTargetFactory> TargetsFactories { get; set; } = [];

    protected override Humidifier.CodeStarNotifications.NotificationRule Create()
    {
        var notificationRuleResult = CreateNotificationRule();
        factoryAction?.Invoke(notificationRuleResult);

        return notificationRuleResult;
    }

    private Humidifier.CodeStarNotifications.NotificationRule CreateNotificationRule()
    {
        var notificationRuleResult = new Humidifier.CodeStarNotifications.NotificationRule
        {
            GivenName = InputResourceName,
        };

        return notificationRuleResult;
    }
    public override void CreateChildren(Humidifier.CodeStarNotifications.NotificationRule result)
    {
        base.CreateChildren(result);

        result.Targets = TargetsFactories.Any() ? TargetsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class NotificationRuleFactoryExtensions
{
    public static CombinedResult<NotificationRuleFactory, InnerNotificationRuleTargetFactory> WithTargets(this NotificationRuleFactory parentFactory, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null)
    {
        var factory = new InnerNotificationRuleTargetFactory(subFactoryAction);
        parentFactory.TargetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<NotificationRuleFactory, T1, InnerNotificationRuleTargetFactory> WithTargets<T1>(this CombinedResult<NotificationRuleFactory, T1> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotificationRuleFactory, InnerNotificationRuleTargetFactory> WithTargets<T1>(this CombinedResult<T1, NotificationRuleFactory> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NotificationRuleFactory, T1, T2, InnerNotificationRuleTargetFactory> WithTargets<T1, T2>(this CombinedResult<NotificationRuleFactory, T1, T2> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotificationRuleFactory, T2, InnerNotificationRuleTargetFactory> WithTargets<T1, T2>(this CombinedResult<T1, NotificationRuleFactory, T2> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NotificationRuleFactory, InnerNotificationRuleTargetFactory> WithTargets<T1, T2>(this CombinedResult<T1, T2, NotificationRuleFactory> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NotificationRuleFactory, T1, T2, T3, InnerNotificationRuleTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<NotificationRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotificationRuleFactory, T2, T3, InnerNotificationRuleTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, NotificationRuleFactory, T2, T3> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NotificationRuleFactory, T3, InnerNotificationRuleTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, NotificationRuleFactory, T3> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NotificationRuleFactory, InnerNotificationRuleTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, NotificationRuleFactory> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NotificationRuleFactory, T1, T2, T3, T4, InnerNotificationRuleTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<NotificationRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotificationRuleFactory, T2, T3, T4, InnerNotificationRuleTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, NotificationRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NotificationRuleFactory, T3, T4, InnerNotificationRuleTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, NotificationRuleFactory, T3, T4> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NotificationRuleFactory, T4, InnerNotificationRuleTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NotificationRuleFactory, T4> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NotificationRuleFactory, InnerNotificationRuleTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NotificationRuleFactory> combinedResult, Action<Humidifier.CodeStarNotifications.NotificationRuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T5, subFactoryAction));
}
