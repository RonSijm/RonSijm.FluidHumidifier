// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputMaintenanceConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.MaintenanceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.MaintenanceConfiguration>
{

    internal InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory PreferredDayTimeFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.MaintenanceConfiguration Create()
    {
        var maintenanceConfigurationResult = CreateMaintenanceConfiguration();
        factoryAction?.Invoke(maintenanceConfigurationResult);

        return maintenanceConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.MaintenanceConfiguration CreateMaintenanceConfiguration()
    {
        var maintenanceConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.MaintenanceConfiguration();

        return maintenanceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.MaintenanceConfiguration result)
    {
        base.CreateChildren(result);

        result.PreferredDayTime ??= PreferredDayTimeFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputMaintenanceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputMaintenanceConfigurationFactory, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime(this InnerRouterInputMaintenanceConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null)
    {
        parentFactory.PreferredDayTimeFactory = new InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PreferredDayTimeFactory);
    }

    public static CombinedResult<InnerRouterInputMaintenanceConfigurationFactory, T1, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1>(this CombinedResult<InnerRouterInputMaintenanceConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMaintenanceConfigurationFactory, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1>(this CombinedResult<T1, InnerRouterInputMaintenanceConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMaintenanceConfigurationFactory, T1, T2, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2>(this CombinedResult<InnerRouterInputMaintenanceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMaintenanceConfigurationFactory, T2, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2>(this CombinedResult<T1, InnerRouterInputMaintenanceConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMaintenanceConfigurationFactory, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputMaintenanceConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMaintenanceConfigurationFactory, T1, T2, T3, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3>(this CombinedResult<InnerRouterInputMaintenanceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMaintenanceConfigurationFactory, T2, T3, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputMaintenanceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMaintenanceConfigurationFactory, T3, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputMaintenanceConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputMaintenanceConfigurationFactory, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputMaintenanceConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMaintenanceConfigurationFactory, T1, T2, T3, T4, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputMaintenanceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMaintenanceConfigurationFactory, T2, T3, T4, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputMaintenanceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMaintenanceConfigurationFactory, T3, T4, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputMaintenanceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputMaintenanceConfigurationFactory, T4, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputMaintenanceConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputMaintenanceConfigurationFactory, InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputMaintenanceConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T5, subFactoryAction).T2);
}
