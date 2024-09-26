// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTEvents;

public class InnerAlarmModelAlarmRuleFactory(Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule> factoryAction = null) : SubResourceFactory<Humidifier.IoTEvents.AlarmModelTypes.AlarmRule>
{

    internal InnerAlarmModelSimpleRuleFactory SimpleRuleFactory { get; set; }

    protected override Humidifier.IoTEvents.AlarmModelTypes.AlarmRule Create()
    {
        var alarmRuleResult = CreateAlarmRule();
        factoryAction?.Invoke(alarmRuleResult);

        return alarmRuleResult;
    }

    private Humidifier.IoTEvents.AlarmModelTypes.AlarmRule CreateAlarmRule()
    {
        var alarmRuleResult = new Humidifier.IoTEvents.AlarmModelTypes.AlarmRule();

        return alarmRuleResult;
    }
    public override void CreateChildren(Humidifier.IoTEvents.AlarmModelTypes.AlarmRule result)
    {
        base.CreateChildren(result);

        result.SimpleRule ??= SimpleRuleFactory?.Build();
    }

} // End Of Class

public static class InnerAlarmModelAlarmRuleFactoryExtensions
{
    public static CombinedResult<InnerAlarmModelAlarmRuleFactory, InnerAlarmModelSimpleRuleFactory> WithSimpleRule(this InnerAlarmModelAlarmRuleFactory parentFactory, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null)
    {
        parentFactory.SimpleRuleFactory = new InnerAlarmModelSimpleRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SimpleRuleFactory);
    }

    public static CombinedResult<InnerAlarmModelAlarmRuleFactory, T1, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1>(this CombinedResult<InnerAlarmModelAlarmRuleFactory, T1> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSimpleRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmModelAlarmRuleFactory, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1>(this CombinedResult<T1, InnerAlarmModelAlarmRuleFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSimpleRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAlarmModelAlarmRuleFactory, T1, T2, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2>(this CombinedResult<InnerAlarmModelAlarmRuleFactory, T1, T2> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmModelAlarmRuleFactory, T2, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2>(this CombinedResult<T1, InnerAlarmModelAlarmRuleFactory, T2> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlarmModelAlarmRuleFactory, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2>(this CombinedResult<T1, T2, InnerAlarmModelAlarmRuleFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAlarmModelAlarmRuleFactory, T1, T2, T3, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2, T3>(this CombinedResult<InnerAlarmModelAlarmRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmModelAlarmRuleFactory, T2, T3, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2, T3>(this CombinedResult<T1, InnerAlarmModelAlarmRuleFactory, T2, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlarmModelAlarmRuleFactory, T3, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2, T3>(this CombinedResult<T1, T2, InnerAlarmModelAlarmRuleFactory, T3> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAlarmModelAlarmRuleFactory, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAlarmModelAlarmRuleFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAlarmModelAlarmRuleFactory, T1, T2, T3, T4, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2, T3, T4>(this CombinedResult<InnerAlarmModelAlarmRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmModelAlarmRuleFactory, T2, T3, T4, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2, T3, T4>(this CombinedResult<T1, InnerAlarmModelAlarmRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlarmModelAlarmRuleFactory, T3, T4, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAlarmModelAlarmRuleFactory, T3, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAlarmModelAlarmRuleFactory, T4, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAlarmModelAlarmRuleFactory, T4> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAlarmModelAlarmRuleFactory, InnerAlarmModelSimpleRuleFactory> WithSimpleRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAlarmModelAlarmRuleFactory> combinedResult, Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSimpleRule(combinedResult.T5, subFactoryAction));
}
