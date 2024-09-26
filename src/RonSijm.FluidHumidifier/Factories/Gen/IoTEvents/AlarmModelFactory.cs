// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTEvents;

public class AlarmModelFactory(string resourceName = null, Action<Humidifier.IoTEvents.AlarmModel> factoryAction = null) : ResourceFactory<Humidifier.IoTEvents.AlarmModel>(resourceName)
{

    internal InnerAlarmModelAlarmRuleFactory AlarmRuleFactory { get; set; }

    internal InnerAlarmModelAlarmCapabilitiesFactory AlarmCapabilitiesFactory { get; set; }

    internal InnerAlarmModelAlarmEventActionsFactory AlarmEventActionsFactory { get; set; }

    protected override Humidifier.IoTEvents.AlarmModel Create()
    {
        var alarmModelResult = CreateAlarmModel();
        factoryAction?.Invoke(alarmModelResult);

        return alarmModelResult;
    }

    private Humidifier.IoTEvents.AlarmModel CreateAlarmModel()
    {
        var alarmModelResult = new Humidifier.IoTEvents.AlarmModel
        {
            GivenName = InputResourceName,
        };

        return alarmModelResult;
    }
    public override void CreateChildren(Humidifier.IoTEvents.AlarmModel result)
    {
        base.CreateChildren(result);

        result.AlarmRule ??= AlarmRuleFactory?.Build();
        result.AlarmCapabilities ??= AlarmCapabilitiesFactory?.Build();
        result.AlarmEventActions ??= AlarmEventActionsFactory?.Build();
    }

} // End Of Class

public static class AlarmModelFactoryExtensions
{
    public static CombinedResult<AlarmModelFactory, InnerAlarmModelAlarmRuleFactory> WithAlarmRule(this AlarmModelFactory parentFactory, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null)
    {
        parentFactory.AlarmRuleFactory = new InnerAlarmModelAlarmRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AlarmRuleFactory);
    }

    public static CombinedResult<AlarmModelFactory, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities(this AlarmModelFactory parentFactory, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null)
    {
        parentFactory.AlarmCapabilitiesFactory = new InnerAlarmModelAlarmCapabilitiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AlarmCapabilitiesFactory);
    }

    public static CombinedResult<AlarmModelFactory, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions(this AlarmModelFactory parentFactory, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null)
    {
        parentFactory.AlarmEventActionsFactory = new InnerAlarmModelAlarmEventActionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AlarmEventActionsFactory);
    }

    public static CombinedResult<AlarmModelFactory, T1, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1>(this CombinedResult<AlarmModelFactory, T1> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1>(this CombinedResult<T1, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, T2, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2>(this CombinedResult<AlarmModelFactory, T1, T2> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, T2, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2>(this CombinedResult<T1, AlarmModelFactory, T2> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmModelFactory, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2>(this CombinedResult<T1, T2, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, T2, T3, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2, T3>(this CombinedResult<AlarmModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, T2, T3, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2, T3>(this CombinedResult<T1, AlarmModelFactory, T2, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmModelFactory, T3, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2, T3>(this CombinedResult<T1, T2, AlarmModelFactory, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlarmModelFactory, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, T2, T3, T4, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2, T3, T4>(this CombinedResult<AlarmModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, T2, T3, T4, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2, T3, T4>(this CombinedResult<T1, AlarmModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmModelFactory, T3, T4, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, AlarmModelFactory, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlarmModelFactory, T4, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AlarmModelFactory, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AlarmModelFactory, InnerAlarmModelAlarmRuleFactory> WithAlarmRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmRule(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1>(this CombinedResult<AlarmModelFactory, T1> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1>(this CombinedResult<T1, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, T2, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2>(this CombinedResult<AlarmModelFactory, T1, T2> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, T2, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2>(this CombinedResult<T1, AlarmModelFactory, T2> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmModelFactory, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2>(this CombinedResult<T1, T2, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, T2, T3, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2, T3>(this CombinedResult<AlarmModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, T2, T3, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2, T3>(this CombinedResult<T1, AlarmModelFactory, T2, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmModelFactory, T3, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, AlarmModelFactory, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlarmModelFactory, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, T3, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, T2, T3, T4, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2, T3, T4>(this CombinedResult<AlarmModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, T2, T3, T4, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, AlarmModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmModelFactory, T3, T4, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, AlarmModelFactory, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlarmModelFactory, T4, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AlarmModelFactory, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AlarmModelFactory, InnerAlarmModelAlarmCapabilitiesFactory> WithAlarmCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmCapabilities(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1>(this CombinedResult<AlarmModelFactory, T1> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1>(this CombinedResult<T1, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, T2, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2>(this CombinedResult<AlarmModelFactory, T1, T2> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, T2, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2>(this CombinedResult<T1, AlarmModelFactory, T2> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmModelFactory, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2>(this CombinedResult<T1, T2, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, T2, T3, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2, T3>(this CombinedResult<AlarmModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, T2, T3, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2, T3>(this CombinedResult<T1, AlarmModelFactory, T2, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmModelFactory, T3, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2, T3>(this CombinedResult<T1, T2, AlarmModelFactory, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlarmModelFactory, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AlarmModelFactory, T1, T2, T3, T4, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2, T3, T4>(this CombinedResult<AlarmModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmModelFactory, T2, T3, T4, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2, T3, T4>(this CombinedResult<T1, AlarmModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmModelFactory, T3, T4, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, AlarmModelFactory, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlarmModelFactory, T4, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AlarmModelFactory, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AlarmModelFactory, InnerAlarmModelAlarmEventActionsFactory> WithAlarmEventActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AlarmModelFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmEventActions(combinedResult.T5, subFactoryAction));
}
