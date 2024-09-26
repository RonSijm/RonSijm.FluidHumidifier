// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDashboardVisualPublishOptionsFactory(Action<Humidifier.QuickSight.DashboardTypes.DashboardVisualPublishOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DashboardVisualPublishOptions>
{

    internal InnerDashboardExportHiddenFieldsOptionFactory ExportHiddenFieldsOptionFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.DashboardVisualPublishOptions Create()
    {
        var dashboardVisualPublishOptionsResult = CreateDashboardVisualPublishOptions();
        factoryAction?.Invoke(dashboardVisualPublishOptionsResult);

        return dashboardVisualPublishOptionsResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DashboardVisualPublishOptions CreateDashboardVisualPublishOptions()
    {
        var dashboardVisualPublishOptionsResult = new Humidifier.QuickSight.DashboardTypes.DashboardVisualPublishOptions();

        return dashboardVisualPublishOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.DashboardVisualPublishOptions result)
    {
        base.CreateChildren(result);

        result.ExportHiddenFieldsOption ??= ExportHiddenFieldsOptionFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardDashboardVisualPublishOptionsFactoryExtensions
{
    public static CombinedResult<InnerDashboardDashboardVisualPublishOptionsFactory, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption(this InnerDashboardDashboardVisualPublishOptionsFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null)
    {
        parentFactory.ExportHiddenFieldsOptionFactory = new InnerDashboardExportHiddenFieldsOptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExportHiddenFieldsOptionFactory);
    }

    public static CombinedResult<InnerDashboardDashboardVisualPublishOptionsFactory, T1, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1>(this CombinedResult<InnerDashboardDashboardVisualPublishOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVisualPublishOptionsFactory, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1>(this CombinedResult<T1, InnerDashboardDashboardVisualPublishOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardVisualPublishOptionsFactory, T1, T2, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2>(this CombinedResult<InnerDashboardDashboardVisualPublishOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVisualPublishOptionsFactory, T2, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2>(this CombinedResult<T1, InnerDashboardDashboardVisualPublishOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardVisualPublishOptionsFactory, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2>(this CombinedResult<T1, T2, InnerDashboardDashboardVisualPublishOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardVisualPublishOptionsFactory, T1, T2, T3, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2, T3>(this CombinedResult<InnerDashboardDashboardVisualPublishOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVisualPublishOptionsFactory, T2, T3, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2, T3>(this CombinedResult<T1, InnerDashboardDashboardVisualPublishOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardVisualPublishOptionsFactory, T3, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardDashboardVisualPublishOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDashboardVisualPublishOptionsFactory, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardDashboardVisualPublishOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardDashboardVisualPublishOptionsFactory, T1, T2, T3, T4, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2, T3, T4>(this CombinedResult<InnerDashboardDashboardVisualPublishOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDashboardVisualPublishOptionsFactory, T2, T3, T4, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardDashboardVisualPublishOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDashboardVisualPublishOptionsFactory, T3, T4, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardDashboardVisualPublishOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDashboardVisualPublishOptionsFactory, T4, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardDashboardVisualPublishOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardDashboardVisualPublishOptionsFactory, InnerDashboardExportHiddenFieldsOptionFactory> WithExportHiddenFieldsOption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardDashboardVisualPublishOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportHiddenFieldsOption(combinedResult.T5, subFactoryAction));
}
