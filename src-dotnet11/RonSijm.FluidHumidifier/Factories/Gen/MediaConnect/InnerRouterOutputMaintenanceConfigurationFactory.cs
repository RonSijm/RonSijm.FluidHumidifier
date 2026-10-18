// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputMaintenanceConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.MaintenanceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.MaintenanceConfiguration>
{

    internal InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory PreferredDayTimeFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.MaintenanceConfiguration Create()
    {
        var maintenanceConfigurationResult = CreateMaintenanceConfiguration();
        factoryAction?.Invoke(maintenanceConfigurationResult);

        return maintenanceConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.MaintenanceConfiguration CreateMaintenanceConfiguration()
    {
        var maintenanceConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.MaintenanceConfiguration();

        return maintenanceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.MaintenanceConfiguration result)
    {
        base.CreateChildren(result);

        result.PreferredDayTime ??= PreferredDayTimeFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputMaintenanceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputMaintenanceConfigurationFactory, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime(this InnerRouterOutputMaintenanceConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null)
    {
        parentFactory.PreferredDayTimeFactory = new InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PreferredDayTimeFactory);
    }

    public static CombinedResult<InnerRouterOutputMaintenanceConfigurationFactory, T1, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1>(this CombinedResult<InnerRouterOutputMaintenanceConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMaintenanceConfigurationFactory, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1>(this CombinedResult<T1, InnerRouterOutputMaintenanceConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMaintenanceConfigurationFactory, T1, T2, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2>(this CombinedResult<InnerRouterOutputMaintenanceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMaintenanceConfigurationFactory, T2, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2>(this CombinedResult<T1, InnerRouterOutputMaintenanceConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMaintenanceConfigurationFactory, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputMaintenanceConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMaintenanceConfigurationFactory, T1, T2, T3, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3>(this CombinedResult<InnerRouterOutputMaintenanceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMaintenanceConfigurationFactory, T2, T3, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputMaintenanceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMaintenanceConfigurationFactory, T3, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputMaintenanceConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputMaintenanceConfigurationFactory, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputMaintenanceConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMaintenanceConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputMaintenanceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMaintenanceConfigurationFactory, T2, T3, T4, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputMaintenanceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMaintenanceConfigurationFactory, T3, T4, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputMaintenanceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputMaintenanceConfigurationFactory, T4, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputMaintenanceConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputMaintenanceConfigurationFactory, InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory> WithPreferredDayTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputMaintenanceConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferredDayTime(combinedResult.T5, subFactoryAction).T2);
}
