// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileAppLifecycleManagementFactory(Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement>
{

    internal InnerUserProfileIdleSettingsFactory IdleSettingsFactory { get; set; }

    protected override Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement Create()
    {
        var appLifecycleManagementResult = CreateAppLifecycleManagement();
        factoryAction?.Invoke(appLifecycleManagementResult);

        return appLifecycleManagementResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement CreateAppLifecycleManagement()
    {
        var appLifecycleManagementResult = new Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement();

        return appLifecycleManagementResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement result)
    {
        base.CreateChildren(result);

        result.IdleSettings ??= IdleSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerUserProfileAppLifecycleManagementFactoryExtensions
{
    public static CombinedResult<InnerUserProfileAppLifecycleManagementFactory, InnerUserProfileIdleSettingsFactory> WithIdleSettings(this InnerUserProfileAppLifecycleManagementFactory parentFactory, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null)
    {
        parentFactory.IdleSettingsFactory = new InnerUserProfileIdleSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdleSettingsFactory);
    }

    public static CombinedResult<InnerUserProfileAppLifecycleManagementFactory, T1, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1>(this CombinedResult<InnerUserProfileAppLifecycleManagementFactory, T1> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileAppLifecycleManagementFactory, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1>(this CombinedResult<T1, InnerUserProfileAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerUserProfileAppLifecycleManagementFactory, T1, T2, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2>(this CombinedResult<InnerUserProfileAppLifecycleManagementFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileAppLifecycleManagementFactory, T2, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2>(this CombinedResult<T1, InnerUserProfileAppLifecycleManagementFactory, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileAppLifecycleManagementFactory, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2>(this CombinedResult<T1, T2, InnerUserProfileAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerUserProfileAppLifecycleManagementFactory, T1, T2, T3, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<InnerUserProfileAppLifecycleManagementFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileAppLifecycleManagementFactory, T2, T3, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<T1, InnerUserProfileAppLifecycleManagementFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileAppLifecycleManagementFactory, T3, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserProfileAppLifecycleManagementFactory, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileAppLifecycleManagementFactory, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserProfileAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerUserProfileAppLifecycleManagementFactory, T1, T2, T3, T4, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<InnerUserProfileAppLifecycleManagementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileAppLifecycleManagementFactory, T2, T3, T4, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserProfileAppLifecycleManagementFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileAppLifecycleManagementFactory, T3, T4, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserProfileAppLifecycleManagementFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileAppLifecycleManagementFactory, T4, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserProfileAppLifecycleManagementFactory, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerUserProfileAppLifecycleManagementFactory, InnerUserProfileIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserProfileAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T5, subFactoryAction));
}
