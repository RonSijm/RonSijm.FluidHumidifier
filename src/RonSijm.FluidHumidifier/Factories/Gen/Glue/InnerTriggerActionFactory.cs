// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTriggerActionFactory(Action<Humidifier.Glue.TriggerTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TriggerTypes.Action>
{

    internal InnerTriggerNotificationPropertyFactory NotificationPropertyFactory { get; set; }

    protected override Humidifier.Glue.TriggerTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.Glue.TriggerTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.Glue.TriggerTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.Glue.TriggerTypes.Action result)
    {
        base.CreateChildren(result);

        result.NotificationProperty ??= NotificationPropertyFactory?.Build();
    }

} // End Of Class

public static class InnerTriggerActionFactoryExtensions
{
    public static CombinedResult<InnerTriggerActionFactory, InnerTriggerNotificationPropertyFactory> WithNotificationProperty(this InnerTriggerActionFactory parentFactory, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null)
    {
        parentFactory.NotificationPropertyFactory = new InnerTriggerNotificationPropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NotificationPropertyFactory);
    }

    public static CombinedResult<InnerTriggerActionFactory, T1, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1>(this CombinedResult<InnerTriggerActionFactory, T1> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTriggerActionFactory, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1>(this CombinedResult<T1, InnerTriggerActionFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTriggerActionFactory, T1, T2, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2>(this CombinedResult<InnerTriggerActionFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTriggerActionFactory, T2, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2>(this CombinedResult<T1, InnerTriggerActionFactory, T2> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTriggerActionFactory, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2>(this CombinedResult<T1, T2, InnerTriggerActionFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTriggerActionFactory, T1, T2, T3, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3>(this CombinedResult<InnerTriggerActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTriggerActionFactory, T2, T3, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3>(this CombinedResult<T1, InnerTriggerActionFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTriggerActionFactory, T3, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3>(this CombinedResult<T1, T2, InnerTriggerActionFactory, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTriggerActionFactory, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTriggerActionFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTriggerActionFactory, T1, T2, T3, T4, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3, T4>(this CombinedResult<InnerTriggerActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTriggerActionFactory, T2, T3, T4, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3, T4>(this CombinedResult<T1, InnerTriggerActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTriggerActionFactory, T3, T4, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTriggerActionFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTriggerActionFactory, T4, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTriggerActionFactory, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTriggerActionFactory, InnerTriggerNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTriggerActionFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T5, subFactoryAction));
}
