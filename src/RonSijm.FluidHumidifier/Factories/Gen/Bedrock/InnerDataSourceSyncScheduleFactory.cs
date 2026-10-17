// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceSyncScheduleFactory(Action<Humidifier.Bedrock.DataSourceTypes.SyncSchedule> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.SyncSchedule>
{

    internal InnerDataSourceMonthlyScheduleFactory MonthlyFactory { get; set; }

    internal InnerDataSourceWeeklyScheduleFactory WeeklyFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.SyncSchedule Create()
    {
        var syncScheduleResult = CreateSyncSchedule();
        factoryAction?.Invoke(syncScheduleResult);

        return syncScheduleResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.SyncSchedule CreateSyncSchedule()
    {
        var syncScheduleResult = new Humidifier.Bedrock.DataSourceTypes.SyncSchedule();

        return syncScheduleResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.SyncSchedule result)
    {
        base.CreateChildren(result);

        result.Monthly ??= MonthlyFactory?.Build();
        result.Weekly ??= WeeklyFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceSyncScheduleFactoryExtensions
{
    public static CombinedResult<InnerDataSourceSyncScheduleFactory, InnerDataSourceMonthlyScheduleFactory> WithMonthly(this InnerDataSourceSyncScheduleFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null)
    {
        parentFactory.MonthlyFactory = new InnerDataSourceMonthlyScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MonthlyFactory);
    }

    public static CombinedResult<InnerDataSourceSyncScheduleFactory, InnerDataSourceWeeklyScheduleFactory> WithWeekly(this InnerDataSourceSyncScheduleFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null)
    {
        parentFactory.WeeklyFactory = new InnerDataSourceWeeklyScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WeeklyFactory);
    }

    public static CombinedResult<InnerDataSourceSyncScheduleFactory, T1, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1>(this CombinedResult<InnerDataSourceSyncScheduleFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonthly(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceSyncScheduleFactory, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1>(this CombinedResult<T1, InnerDataSourceSyncScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonthly(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2>(this CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2>(this CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2, T3, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2, T3>(this CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2, T3, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory, T3, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceSyncScheduleFactory, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceSyncScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2, T3, T4, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2, T3, T4, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory, T3, T4, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceSyncScheduleFactory, T4, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceSyncScheduleFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceSyncScheduleFactory, InnerDataSourceMonthlyScheduleFactory> WithMonthly<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceSyncScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonthly(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceSyncScheduleFactory, T1, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1>(this CombinedResult<InnerDataSourceSyncScheduleFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithWeekly(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceSyncScheduleFactory, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1>(this CombinedResult<T1, InnerDataSourceSyncScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithWeekly(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2>(this CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2>(this CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2, T3, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2, T3>(this CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2, T3, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory, T3, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceSyncScheduleFactory, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceSyncScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2, T3, T4, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceSyncScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2, T3, T4, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceSyncScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory, T3, T4, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceSyncScheduleFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceSyncScheduleFactory, T4, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceSyncScheduleFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceSyncScheduleFactory, InnerDataSourceWeeklyScheduleFactory> WithWeekly<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceSyncScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeekly(combinedResult.T5, subFactoryAction).T2);
}
