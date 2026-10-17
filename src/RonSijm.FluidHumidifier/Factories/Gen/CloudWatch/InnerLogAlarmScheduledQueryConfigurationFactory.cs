// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerLogAlarmScheduledQueryConfigurationFactory(Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduledQueryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.LogAlarmTypes.ScheduledQueryConfiguration>
{

    internal InnerLogAlarmScheduleConfigurationFactory ScheduleConfigurationFactory { get; set; }

    protected override Humidifier.CloudWatch.LogAlarmTypes.ScheduledQueryConfiguration Create()
    {
        var scheduledQueryConfigurationResult = CreateScheduledQueryConfiguration();
        factoryAction?.Invoke(scheduledQueryConfigurationResult);

        return scheduledQueryConfigurationResult;
    }

    private Humidifier.CloudWatch.LogAlarmTypes.ScheduledQueryConfiguration CreateScheduledQueryConfiguration()
    {
        var scheduledQueryConfigurationResult = new Humidifier.CloudWatch.LogAlarmTypes.ScheduledQueryConfiguration();

        return scheduledQueryConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.LogAlarmTypes.ScheduledQueryConfiguration result)
    {
        base.CreateChildren(result);

        result.ScheduleConfiguration ??= ScheduleConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerLogAlarmScheduledQueryConfigurationFactoryExtensions
{
    public static CombinedResult<InnerLogAlarmScheduledQueryConfigurationFactory, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration(this InnerLogAlarmScheduledQueryConfigurationFactory parentFactory, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null)
    {
        parentFactory.ScheduleConfigurationFactory = new InnerLogAlarmScheduleConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleConfigurationFactory);
    }

    public static CombinedResult<InnerLogAlarmScheduledQueryConfigurationFactory, T1, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1>(this CombinedResult<InnerLogAlarmScheduledQueryConfigurationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLogAlarmScheduledQueryConfigurationFactory, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1>(this CombinedResult<T1, InnerLogAlarmScheduledQueryConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLogAlarmScheduledQueryConfigurationFactory, T1, T2, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2>(this CombinedResult<InnerLogAlarmScheduledQueryConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLogAlarmScheduledQueryConfigurationFactory, T2, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2>(this CombinedResult<T1, InnerLogAlarmScheduledQueryConfigurationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLogAlarmScheduledQueryConfigurationFactory, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerLogAlarmScheduledQueryConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLogAlarmScheduledQueryConfigurationFactory, T1, T2, T3, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3>(this CombinedResult<InnerLogAlarmScheduledQueryConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLogAlarmScheduledQueryConfigurationFactory, T2, T3, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerLogAlarmScheduledQueryConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLogAlarmScheduledQueryConfigurationFactory, T3, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerLogAlarmScheduledQueryConfigurationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLogAlarmScheduledQueryConfigurationFactory, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLogAlarmScheduledQueryConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLogAlarmScheduledQueryConfigurationFactory, T1, T2, T3, T4, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerLogAlarmScheduledQueryConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLogAlarmScheduledQueryConfigurationFactory, T2, T3, T4, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerLogAlarmScheduledQueryConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLogAlarmScheduledQueryConfigurationFactory, T3, T4, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLogAlarmScheduledQueryConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLogAlarmScheduledQueryConfigurationFactory, T4, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLogAlarmScheduledQueryConfigurationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLogAlarmScheduledQueryConfigurationFactory, InnerLogAlarmScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLogAlarmScheduledQueryConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T5, subFactoryAction).T2);
}
