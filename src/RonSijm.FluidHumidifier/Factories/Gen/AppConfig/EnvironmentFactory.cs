// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class EnvironmentFactory(string resourceName = null, Action<Humidifier.AppConfig.Environment> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.Environment>(resourceName)
{

    internal List<InnerEnvironmentMonitorFactory> MonitorsFactories { get; set; } = [];

    protected override Humidifier.AppConfig.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.AppConfig.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.AppConfig.Environment
        {
            GivenName = InputResourceName,
        };

        return environmentResult;
    }
    public override void CreateChildren(Humidifier.AppConfig.Environment result)
    {
        base.CreateChildren(result);

        result.Monitors = MonitorsFactories.Any() ? MonitorsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EnvironmentFactoryExtensions
{
    public static CombinedResult<EnvironmentFactory, InnerEnvironmentMonitorFactory> WithMonitors(this EnvironmentFactory parentFactory, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null)
    {
        var factory = new InnerEnvironmentMonitorFactory(subFactoryAction);
        parentFactory.MonitorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentMonitorFactory> WithMonitors<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentMonitorFactory> WithMonitors<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentMonitorFactory> WithMonitors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitors(combinedResult.T5, subFactoryAction));
}
