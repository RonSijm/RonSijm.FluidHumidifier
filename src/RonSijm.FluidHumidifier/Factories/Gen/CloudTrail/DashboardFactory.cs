// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class DashboardFactory(string resourceName = null, Action<Humidifier.CloudTrail.Dashboard> factoryAction = null) : ResourceFactory<Humidifier.CloudTrail.Dashboard>(resourceName)
{

    internal List<InnerDashboardWidgetFactory> WidgetsFactories { get; set; } = [];

    internal InnerDashboardRefreshScheduleFactory RefreshScheduleFactory { get; set; }

    protected override Humidifier.CloudTrail.Dashboard Create()
    {
        var dashboardResult = CreateDashboard();
        factoryAction?.Invoke(dashboardResult);

        return dashboardResult;
    }

    private Humidifier.CloudTrail.Dashboard CreateDashboard()
    {
        var dashboardResult = new Humidifier.CloudTrail.Dashboard
        {
            GivenName = InputResourceName,
        };

        return dashboardResult;
    }
    public override void CreateChildren(Humidifier.CloudTrail.Dashboard result)
    {
        base.CreateChildren(result);

        result.Widgets = WidgetsFactories.Any() ? WidgetsFactories.Select(x => x.Build()).ToList() : null;
        result.RefreshSchedule ??= RefreshScheduleFactory?.Build();
    }

} // End Of Class

public static class DashboardFactoryExtensions
{
    public static CombinedResult<DashboardFactory, InnerDashboardWidgetFactory> WithWidgets(this DashboardFactory parentFactory, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null)
    {
        var factory = new InnerDashboardWidgetFactory(subFactoryAction);
        parentFactory.WidgetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DashboardFactory, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule(this DashboardFactory parentFactory, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null)
    {
        parentFactory.RefreshScheduleFactory = new InnerDashboardRefreshScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RefreshScheduleFactory);
    }

    public static CombinedResult<DashboardFactory, T1, InnerDashboardWidgetFactory> WithWidgets<T1>(this CombinedResult<DashboardFactory, T1> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, WithWidgets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DashboardFactory, InnerDashboardWidgetFactory> WithWidgets<T1>(this CombinedResult<T1, DashboardFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, WithWidgets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DashboardFactory, T1, T2, InnerDashboardWidgetFactory> WithWidgets<T1, T2>(this CombinedResult<DashboardFactory, T1, T2> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DashboardFactory, T2, InnerDashboardWidgetFactory> WithWidgets<T1, T2>(this CombinedResult<T1, DashboardFactory, T2> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DashboardFactory, InnerDashboardWidgetFactory> WithWidgets<T1, T2>(this CombinedResult<T1, T2, DashboardFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DashboardFactory, T1, T2, T3, InnerDashboardWidgetFactory> WithWidgets<T1, T2, T3>(this CombinedResult<DashboardFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DashboardFactory, T2, T3, InnerDashboardWidgetFactory> WithWidgets<T1, T2, T3>(this CombinedResult<T1, DashboardFactory, T2, T3> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DashboardFactory, T3, InnerDashboardWidgetFactory> WithWidgets<T1, T2, T3>(this CombinedResult<T1, T2, DashboardFactory, T3> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DashboardFactory, InnerDashboardWidgetFactory> WithWidgets<T1, T2, T3>(this CombinedResult<T1, T2, T3, DashboardFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DashboardFactory, T1, T2, T3, T4, InnerDashboardWidgetFactory> WithWidgets<T1, T2, T3, T4>(this CombinedResult<DashboardFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DashboardFactory, T2, T3, T4, InnerDashboardWidgetFactory> WithWidgets<T1, T2, T3, T4>(this CombinedResult<T1, DashboardFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DashboardFactory, T3, T4, InnerDashboardWidgetFactory> WithWidgets<T1, T2, T3, T4>(this CombinedResult<T1, T2, DashboardFactory, T3, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DashboardFactory, T4, InnerDashboardWidgetFactory> WithWidgets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DashboardFactory, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DashboardFactory, InnerDashboardWidgetFactory> WithWidgets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DashboardFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.Widget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWidgets(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DashboardFactory, T1, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1>(this CombinedResult<DashboardFactory, T1> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DashboardFactory, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1>(this CombinedResult<T1, DashboardFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DashboardFactory, T1, T2, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2>(this CombinedResult<DashboardFactory, T1, T2> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DashboardFactory, T2, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2>(this CombinedResult<T1, DashboardFactory, T2> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DashboardFactory, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2>(this CombinedResult<T1, T2, DashboardFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DashboardFactory, T1, T2, T3, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2, T3>(this CombinedResult<DashboardFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DashboardFactory, T2, T3, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2, T3>(this CombinedResult<T1, DashboardFactory, T2, T3> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DashboardFactory, T3, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2, T3>(this CombinedResult<T1, T2, DashboardFactory, T3> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DashboardFactory, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, DashboardFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DashboardFactory, T1, T2, T3, T4, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2, T3, T4>(this CombinedResult<DashboardFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DashboardFactory, T2, T3, T4, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2, T3, T4>(this CombinedResult<T1, DashboardFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DashboardFactory, T3, T4, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, DashboardFactory, T3, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DashboardFactory, T4, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DashboardFactory, T4> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DashboardFactory, InnerDashboardRefreshScheduleFactory> WithRefreshSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DashboardFactory> combinedResult, Action<Humidifier.CloudTrail.DashboardTypes.RefreshSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshSchedule(combinedResult.T5, subFactoryAction));
}
