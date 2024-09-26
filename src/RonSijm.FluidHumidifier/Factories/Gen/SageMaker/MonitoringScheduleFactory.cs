// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class MonitoringScheduleFactory(string resourceName = null, Action<Humidifier.SageMaker.MonitoringSchedule> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.MonitoringSchedule>(resourceName)
{

    internal InnerMonitoringScheduleMonitoringScheduleConfigFactory MonitoringScheduleConfigFactory { get; set; }

    internal InnerMonitoringScheduleMonitoringExecutionSummaryFactory LastMonitoringExecutionSummaryFactory { get; set; }

    protected override Humidifier.SageMaker.MonitoringSchedule Create()
    {
        var monitoringScheduleResult = CreateMonitoringSchedule();
        factoryAction?.Invoke(monitoringScheduleResult);

        return monitoringScheduleResult;
    }

    private Humidifier.SageMaker.MonitoringSchedule CreateMonitoringSchedule()
    {
        var monitoringScheduleResult = new Humidifier.SageMaker.MonitoringSchedule
        {
            GivenName = InputResourceName,
        };

        return monitoringScheduleResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.MonitoringSchedule result)
    {
        base.CreateChildren(result);

        result.MonitoringScheduleConfig ??= MonitoringScheduleConfigFactory?.Build();
        result.LastMonitoringExecutionSummary ??= LastMonitoringExecutionSummaryFactory?.Build();
    }

} // End Of Class

public static class MonitoringScheduleFactoryExtensions
{
    public static CombinedResult<MonitoringScheduleFactory, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig(this MonitoringScheduleFactory parentFactory, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null)
    {
        parentFactory.MonitoringScheduleConfigFactory = new InnerMonitoringScheduleMonitoringScheduleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MonitoringScheduleConfigFactory);
    }

    public static CombinedResult<MonitoringScheduleFactory, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary(this MonitoringScheduleFactory parentFactory, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null)
    {
        parentFactory.LastMonitoringExecutionSummaryFactory = new InnerMonitoringScheduleMonitoringExecutionSummaryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LastMonitoringExecutionSummaryFactory);
    }

    public static CombinedResult<MonitoringScheduleFactory, T1, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1>(this CombinedResult<MonitoringScheduleFactory, T1> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringScheduleFactory, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1>(this CombinedResult<T1, MonitoringScheduleFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MonitoringScheduleFactory, T1, T2, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2>(this CombinedResult<MonitoringScheduleFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringScheduleFactory, T2, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2>(this CombinedResult<T1, MonitoringScheduleFactory, T2> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitoringScheduleFactory, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2>(this CombinedResult<T1, T2, MonitoringScheduleFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MonitoringScheduleFactory, T1, T2, T3, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2, T3>(this CombinedResult<MonitoringScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringScheduleFactory, T2, T3, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2, T3>(this CombinedResult<T1, MonitoringScheduleFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitoringScheduleFactory, T3, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2, T3>(this CombinedResult<T1, T2, MonitoringScheduleFactory, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MonitoringScheduleFactory, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, MonitoringScheduleFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MonitoringScheduleFactory, T1, T2, T3, T4, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2, T3, T4>(this CombinedResult<MonitoringScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringScheduleFactory, T2, T3, T4, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, MonitoringScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitoringScheduleFactory, T3, T4, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, MonitoringScheduleFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MonitoringScheduleFactory, T4, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MonitoringScheduleFactory, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MonitoringScheduleFactory, InnerMonitoringScheduleMonitoringScheduleConfigFactory> WithMonitoringScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MonitoringScheduleFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringScheduleConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MonitoringScheduleFactory, T1, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1>(this CombinedResult<MonitoringScheduleFactory, T1> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringScheduleFactory, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1>(this CombinedResult<T1, MonitoringScheduleFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MonitoringScheduleFactory, T1, T2, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2>(this CombinedResult<MonitoringScheduleFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringScheduleFactory, T2, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2>(this CombinedResult<T1, MonitoringScheduleFactory, T2> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitoringScheduleFactory, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2>(this CombinedResult<T1, T2, MonitoringScheduleFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MonitoringScheduleFactory, T1, T2, T3, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2, T3>(this CombinedResult<MonitoringScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringScheduleFactory, T2, T3, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2, T3>(this CombinedResult<T1, MonitoringScheduleFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitoringScheduleFactory, T3, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2, T3>(this CombinedResult<T1, T2, MonitoringScheduleFactory, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MonitoringScheduleFactory, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2, T3>(this CombinedResult<T1, T2, T3, MonitoringScheduleFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MonitoringScheduleFactory, T1, T2, T3, T4, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2, T3, T4>(this CombinedResult<MonitoringScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MonitoringScheduleFactory, T2, T3, T4, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2, T3, T4>(this CombinedResult<T1, MonitoringScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MonitoringScheduleFactory, T3, T4, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2, T3, T4>(this CombinedResult<T1, T2, MonitoringScheduleFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MonitoringScheduleFactory, T4, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MonitoringScheduleFactory, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MonitoringScheduleFactory, InnerMonitoringScheduleMonitoringExecutionSummaryFactory> WithLastMonitoringExecutionSummary<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MonitoringScheduleFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLastMonitoringExecutionSummary(combinedResult.T5, subFactoryAction));
}
