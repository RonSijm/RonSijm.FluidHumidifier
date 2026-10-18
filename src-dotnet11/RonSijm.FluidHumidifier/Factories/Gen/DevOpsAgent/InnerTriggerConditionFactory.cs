// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerTriggerConditionFactory(Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.TriggerTypes.Condition>
{

    internal InnerTriggerScheduleFactory ScheduleFactory { get; set; }

    protected override Humidifier.DevOpsAgent.TriggerTypes.Condition Create()
    {
        var conditionResult = CreateCondition();
        factoryAction?.Invoke(conditionResult);

        return conditionResult;
    }

    private Humidifier.DevOpsAgent.TriggerTypes.Condition CreateCondition()
    {
        var conditionResult = new Humidifier.DevOpsAgent.TriggerTypes.Condition();

        return conditionResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.TriggerTypes.Condition result)
    {
        base.CreateChildren(result);

        result.Schedule ??= ScheduleFactory?.Build();
    }

} // End Of Class

public static class InnerTriggerConditionFactoryExtensions
{
    public static CombinedResult<InnerTriggerConditionFactory, InnerTriggerScheduleFactory> WithSchedule(this InnerTriggerConditionFactory parentFactory, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null)
    {
        parentFactory.ScheduleFactory = new InnerTriggerScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleFactory);
    }

    public static CombinedResult<InnerTriggerConditionFactory, T1, InnerTriggerScheduleFactory> WithSchedule<T1>(this CombinedResult<InnerTriggerConditionFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTriggerConditionFactory, InnerTriggerScheduleFactory> WithSchedule<T1>(this CombinedResult<T1, InnerTriggerConditionFactory> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTriggerConditionFactory, T1, T2, InnerTriggerScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<InnerTriggerConditionFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTriggerConditionFactory, T2, InnerTriggerScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, InnerTriggerConditionFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTriggerConditionFactory, InnerTriggerScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, T2, InnerTriggerConditionFactory> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTriggerConditionFactory, T1, T2, T3, InnerTriggerScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<InnerTriggerConditionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTriggerConditionFactory, T2, T3, InnerTriggerScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, InnerTriggerConditionFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTriggerConditionFactory, T3, InnerTriggerScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, InnerTriggerConditionFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTriggerConditionFactory, InnerTriggerScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTriggerConditionFactory> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTriggerConditionFactory, T1, T2, T3, T4, InnerTriggerScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<InnerTriggerConditionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTriggerConditionFactory, T2, T3, T4, InnerTriggerScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, InnerTriggerConditionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTriggerConditionFactory, T3, T4, InnerTriggerScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTriggerConditionFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTriggerConditionFactory, T4, InnerTriggerScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTriggerConditionFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTriggerConditionFactory, InnerTriggerScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTriggerConditionFactory> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T5, subFactoryAction).T2);
}
