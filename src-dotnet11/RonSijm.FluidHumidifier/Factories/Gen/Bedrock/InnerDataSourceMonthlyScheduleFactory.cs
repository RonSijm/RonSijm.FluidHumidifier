// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceMonthlyScheduleFactory(Action<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule>
{

    internal InnerDataSourceDayOfMonthFactory DayOfMonthFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.MonthlySchedule Create()
    {
        var monthlyScheduleResult = CreateMonthlySchedule();
        factoryAction?.Invoke(monthlyScheduleResult);

        return monthlyScheduleResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.MonthlySchedule CreateMonthlySchedule()
    {
        var monthlyScheduleResult = new Humidifier.Bedrock.DataSourceTypes.MonthlySchedule();

        return monthlyScheduleResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.MonthlySchedule result)
    {
        base.CreateChildren(result);

        result.DayOfMonth ??= DayOfMonthFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceMonthlyScheduleFactoryExtensions
{
    public static CombinedResult<InnerDataSourceMonthlyScheduleFactory, InnerDataSourceDayOfMonthFactory> WithDayOfMonth(this InnerDataSourceMonthlyScheduleFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null)
    {
        parentFactory.DayOfMonthFactory = new InnerDataSourceDayOfMonthFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DayOfMonthFactory);
    }

    public static CombinedResult<InnerDataSourceMonthlyScheduleFactory, T1, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1>(this CombinedResult<InnerDataSourceMonthlyScheduleFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, WithDayOfMonth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceMonthlyScheduleFactory, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1>(this CombinedResult<T1, InnerDataSourceMonthlyScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, WithDayOfMonth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceMonthlyScheduleFactory, T1, T2, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2>(this CombinedResult<InnerDataSourceMonthlyScheduleFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceMonthlyScheduleFactory, T2, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2>(this CombinedResult<T1, InnerDataSourceMonthlyScheduleFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceMonthlyScheduleFactory, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceMonthlyScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceMonthlyScheduleFactory, T1, T2, T3, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2, T3>(this CombinedResult<InnerDataSourceMonthlyScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceMonthlyScheduleFactory, T2, T3, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceMonthlyScheduleFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceMonthlyScheduleFactory, T3, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceMonthlyScheduleFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceMonthlyScheduleFactory, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceMonthlyScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceMonthlyScheduleFactory, T1, T2, T3, T4, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceMonthlyScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceMonthlyScheduleFactory, T2, T3, T4, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceMonthlyScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceMonthlyScheduleFactory, T3, T4, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceMonthlyScheduleFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceMonthlyScheduleFactory, T4, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceMonthlyScheduleFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceMonthlyScheduleFactory, InnerDataSourceDayOfMonthFactory> WithDayOfMonth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceMonthlyScheduleFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDayOfMonth(combinedResult.T5, subFactoryAction).T2);
}
