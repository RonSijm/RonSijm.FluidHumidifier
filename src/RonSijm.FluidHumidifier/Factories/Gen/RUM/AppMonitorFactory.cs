// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RUM;

public class AppMonitorFactory(string resourceName = null, Action<Humidifier.RUM.AppMonitor> factoryAction = null) : ResourceFactory<Humidifier.RUM.AppMonitor>(resourceName)
{

    internal InnerAppMonitorCustomEventsFactory CustomEventsFactory { get; set; }

    internal InnerAppMonitorAppMonitorConfigurationFactory AppMonitorConfigurationFactory { get; set; }

    protected override Humidifier.RUM.AppMonitor Create()
    {
        var appMonitorResult = CreateAppMonitor();
        factoryAction?.Invoke(appMonitorResult);

        return appMonitorResult;
    }

    private Humidifier.RUM.AppMonitor CreateAppMonitor()
    {
        var appMonitorResult = new Humidifier.RUM.AppMonitor
        {
            GivenName = InputResourceName,
        };

        return appMonitorResult;
    }
    public override void CreateChildren(Humidifier.RUM.AppMonitor result)
    {
        base.CreateChildren(result);

        result.CustomEvents ??= CustomEventsFactory?.Build();
        result.AppMonitorConfiguration ??= AppMonitorConfigurationFactory?.Build();
    }

} // End Of Class

public static class AppMonitorFactoryExtensions
{
    public static CombinedResult<AppMonitorFactory, InnerAppMonitorCustomEventsFactory> WithCustomEvents(this AppMonitorFactory parentFactory, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null)
    {
        parentFactory.CustomEventsFactory = new InnerAppMonitorCustomEventsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomEventsFactory);
    }

    public static CombinedResult<AppMonitorFactory, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration(this AppMonitorFactory parentFactory, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null)
    {
        parentFactory.AppMonitorConfigurationFactory = new InnerAppMonitorAppMonitorConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AppMonitorConfigurationFactory);
    }

    public static CombinedResult<AppMonitorFactory, T1, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1>(this CombinedResult<AppMonitorFactory, T1> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomEvents(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppMonitorFactory, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1>(this CombinedResult<T1, AppMonitorFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomEvents(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppMonitorFactory, T1, T2, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2>(this CombinedResult<AppMonitorFactory, T1, T2> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppMonitorFactory, T2, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2>(this CombinedResult<T1, AppMonitorFactory, T2> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppMonitorFactory, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2>(this CombinedResult<T1, T2, AppMonitorFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppMonitorFactory, T1, T2, T3, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2, T3>(this CombinedResult<AppMonitorFactory, T1, T2, T3> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppMonitorFactory, T2, T3, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2, T3>(this CombinedResult<T1, AppMonitorFactory, T2, T3> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppMonitorFactory, T3, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2, T3>(this CombinedResult<T1, T2, AppMonitorFactory, T3> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppMonitorFactory, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppMonitorFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppMonitorFactory, T1, T2, T3, T4, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2, T3, T4>(this CombinedResult<AppMonitorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppMonitorFactory, T2, T3, T4, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2, T3, T4>(this CombinedResult<T1, AppMonitorFactory, T2, T3, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppMonitorFactory, T3, T4, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppMonitorFactory, T3, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppMonitorFactory, T4, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppMonitorFactory, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppMonitorFactory, InnerAppMonitorCustomEventsFactory> WithCustomEvents<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppMonitorFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.CustomEvents> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomEvents(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AppMonitorFactory, T1, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1>(this CombinedResult<AppMonitorFactory, T1> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppMonitorFactory, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1>(this CombinedResult<T1, AppMonitorFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppMonitorFactory, T1, T2, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2>(this CombinedResult<AppMonitorFactory, T1, T2> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppMonitorFactory, T2, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2>(this CombinedResult<T1, AppMonitorFactory, T2> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppMonitorFactory, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2>(this CombinedResult<T1, T2, AppMonitorFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppMonitorFactory, T1, T2, T3, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2, T3>(this CombinedResult<AppMonitorFactory, T1, T2, T3> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppMonitorFactory, T2, T3, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2, T3>(this CombinedResult<T1, AppMonitorFactory, T2, T3> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppMonitorFactory, T3, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AppMonitorFactory, T3> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppMonitorFactory, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppMonitorFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppMonitorFactory, T1, T2, T3, T4, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2, T3, T4>(this CombinedResult<AppMonitorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppMonitorFactory, T2, T3, T4, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AppMonitorFactory, T2, T3, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppMonitorFactory, T3, T4, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppMonitorFactory, T3, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppMonitorFactory, T4, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppMonitorFactory, T4> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppMonitorFactory, InnerAppMonitorAppMonitorConfigurationFactory> WithAppMonitorConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppMonitorFactory> combinedResult, Action<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppMonitorConfiguration(combinedResult.T5, subFactoryAction));
}
