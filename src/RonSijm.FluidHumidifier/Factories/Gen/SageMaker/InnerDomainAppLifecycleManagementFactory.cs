// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainAppLifecycleManagementFactory(Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement>
{

    internal InnerDomainIdleSettingsFactory IdleSettingsFactory { get; set; }

    protected override Humidifier.SageMaker.DomainTypes.AppLifecycleManagement Create()
    {
        var appLifecycleManagementResult = CreateAppLifecycleManagement();
        factoryAction?.Invoke(appLifecycleManagementResult);

        return appLifecycleManagementResult;
    }

    private Humidifier.SageMaker.DomainTypes.AppLifecycleManagement CreateAppLifecycleManagement()
    {
        var appLifecycleManagementResult = new Humidifier.SageMaker.DomainTypes.AppLifecycleManagement();

        return appLifecycleManagementResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DomainTypes.AppLifecycleManagement result)
    {
        base.CreateChildren(result);

        result.IdleSettings ??= IdleSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerDomainAppLifecycleManagementFactoryExtensions
{
    public static CombinedResult<InnerDomainAppLifecycleManagementFactory, InnerDomainIdleSettingsFactory> WithIdleSettings(this InnerDomainAppLifecycleManagementFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null)
    {
        parentFactory.IdleSettingsFactory = new InnerDomainIdleSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdleSettingsFactory);
    }

    public static CombinedResult<InnerDomainAppLifecycleManagementFactory, T1, InnerDomainIdleSettingsFactory> WithIdleSettings<T1>(this CombinedResult<InnerDomainAppLifecycleManagementFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAppLifecycleManagementFactory, InnerDomainIdleSettingsFactory> WithIdleSettings<T1>(this CombinedResult<T1, InnerDomainAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainAppLifecycleManagementFactory, T1, T2, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2>(this CombinedResult<InnerDomainAppLifecycleManagementFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAppLifecycleManagementFactory, T2, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2>(this CombinedResult<T1, InnerDomainAppLifecycleManagementFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAppLifecycleManagementFactory, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2>(this CombinedResult<T1, T2, InnerDomainAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainAppLifecycleManagementFactory, T1, T2, T3, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<InnerDomainAppLifecycleManagementFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAppLifecycleManagementFactory, T2, T3, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<T1, InnerDomainAppLifecycleManagementFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAppLifecycleManagementFactory, T3, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainAppLifecycleManagementFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainAppLifecycleManagementFactory, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainAppLifecycleManagementFactory, T1, T2, T3, T4, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<InnerDomainAppLifecycleManagementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainAppLifecycleManagementFactory, T2, T3, T4, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainAppLifecycleManagementFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainAppLifecycleManagementFactory, T3, T4, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainAppLifecycleManagementFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainAppLifecycleManagementFactory, T4, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainAppLifecycleManagementFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainAppLifecycleManagementFactory, InnerDomainIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.IdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T5, subFactoryAction));
}
