// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskTaskReportConfigFactory(Action<Humidifier.DataSync.TaskTypes.TaskReportConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.TaskReportConfig>
{

    internal InnerTaskDestinationFactory DestinationFactory { get; set; }

    internal InnerTaskOverridesFactory OverridesFactory { get; set; }

    protected override Humidifier.DataSync.TaskTypes.TaskReportConfig Create()
    {
        var taskReportConfigResult = CreateTaskReportConfig();
        factoryAction?.Invoke(taskReportConfigResult);

        return taskReportConfigResult;
    }

    private Humidifier.DataSync.TaskTypes.TaskReportConfig CreateTaskReportConfig()
    {
        var taskReportConfigResult = new Humidifier.DataSync.TaskTypes.TaskReportConfig();

        return taskReportConfigResult;
    }
    public override void CreateChildren(Humidifier.DataSync.TaskTypes.TaskReportConfig result)
    {
        base.CreateChildren(result);

        result.Destination ??= DestinationFactory?.Build();
        result.Overrides ??= OverridesFactory?.Build();
    }

} // End Of Class

public static class InnerTaskTaskReportConfigFactoryExtensions
{
    public static CombinedResult<InnerTaskTaskReportConfigFactory, InnerTaskDestinationFactory> WithDestination(this InnerTaskTaskReportConfigFactory parentFactory, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerTaskDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<InnerTaskTaskReportConfigFactory, InnerTaskOverridesFactory> WithOverrides(this InnerTaskTaskReportConfigFactory parentFactory, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null)
    {
        parentFactory.OverridesFactory = new InnerTaskOverridesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OverridesFactory);
    }

    public static CombinedResult<InnerTaskTaskReportConfigFactory, T1, InnerTaskDestinationFactory> WithDestination<T1>(this CombinedResult<InnerTaskTaskReportConfigFactory, T1> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTaskReportConfigFactory, InnerTaskDestinationFactory> WithDestination<T1>(this CombinedResult<T1, InnerTaskTaskReportConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2, InnerTaskDestinationFactory> WithDestination<T1, T2>(this CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2, InnerTaskDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory, InnerTaskDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2, T3, InnerTaskDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2, T3, InnerTaskDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory, T3, InnerTaskDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskTaskReportConfigFactory, InnerTaskDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskTaskReportConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2, T3, T4, InnerTaskDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2, T3, T4, InnerTaskDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory, T3, T4, InnerTaskDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskTaskReportConfigFactory, T4, InnerTaskDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskTaskReportConfigFactory, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskTaskReportConfigFactory, InnerTaskDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskTaskReportConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTaskTaskReportConfigFactory, T1, InnerTaskOverridesFactory> WithOverrides<T1>(this CombinedResult<InnerTaskTaskReportConfigFactory, T1> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTaskReportConfigFactory, InnerTaskOverridesFactory> WithOverrides<T1>(this CombinedResult<T1, InnerTaskTaskReportConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2, InnerTaskOverridesFactory> WithOverrides<T1, T2>(this CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2, InnerTaskOverridesFactory> WithOverrides<T1, T2>(this CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory, InnerTaskOverridesFactory> WithOverrides<T1, T2>(this CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2, T3, InnerTaskOverridesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2, T3, InnerTaskOverridesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory, T3, InnerTaskOverridesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory, T3> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskTaskReportConfigFactory, InnerTaskOverridesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskTaskReportConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2, T3, T4, InnerTaskOverridesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<InnerTaskTaskReportConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2, T3, T4, InnerTaskOverridesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskTaskReportConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory, T3, T4, InnerTaskOverridesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskTaskReportConfigFactory, T3, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskTaskReportConfigFactory, T4, InnerTaskOverridesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskTaskReportConfigFactory, T4> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskTaskReportConfigFactory, InnerTaskOverridesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskTaskReportConfigFactory> combinedResult, Action<Humidifier.DataSync.TaskTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T5, subFactoryAction));
}
