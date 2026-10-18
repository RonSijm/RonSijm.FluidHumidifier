// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmMuteRuleRuleFactory(Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule>
{

    internal InnerAlarmMuteRuleScheduleFactory ScheduleFactory { get; set; }

    protected override Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule CreateRule()
    {
        var ruleResult = new Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule();

        return ruleResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule result)
    {
        base.CreateChildren(result);

        result.Schedule ??= ScheduleFactory?.Build();
    }

} // End Of Class

public static class InnerAlarmMuteRuleRuleFactoryExtensions
{
    public static CombinedResult<InnerAlarmMuteRuleRuleFactory, InnerAlarmMuteRuleScheduleFactory> WithSchedule(this InnerAlarmMuteRuleRuleFactory parentFactory, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null)
    {
        parentFactory.ScheduleFactory = new InnerAlarmMuteRuleScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleFactory);
    }

    public static CombinedResult<InnerAlarmMuteRuleRuleFactory, T1, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1>(this CombinedResult<InnerAlarmMuteRuleRuleFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmMuteRuleRuleFactory, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1>(this CombinedResult<T1, InnerAlarmMuteRuleRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmMuteRuleRuleFactory, T1, T2, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<InnerAlarmMuteRuleRuleFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmMuteRuleRuleFactory, T2, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, InnerAlarmMuteRuleRuleFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmMuteRuleRuleFactory, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, T2, InnerAlarmMuteRuleRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmMuteRuleRuleFactory, T1, T2, T3, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<InnerAlarmMuteRuleRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmMuteRuleRuleFactory, T2, T3, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, InnerAlarmMuteRuleRuleFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmMuteRuleRuleFactory, T3, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, InnerAlarmMuteRuleRuleFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAlarmMuteRuleRuleFactory, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAlarmMuteRuleRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAlarmMuteRuleRuleFactory, T1, T2, T3, T4, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<InnerAlarmMuteRuleRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAlarmMuteRuleRuleFactory, T2, T3, T4, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, InnerAlarmMuteRuleRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAlarmMuteRuleRuleFactory, T3, T4, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAlarmMuteRuleRuleFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAlarmMuteRuleRuleFactory, T4, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAlarmMuteRuleRuleFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAlarmMuteRuleRuleFactory, InnerAlarmMuteRuleScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAlarmMuteRuleRuleFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T5, subFactoryAction).T2);
}
