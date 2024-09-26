// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainJupyterLabAppSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings>
{

    internal InnerDomainResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    internal InnerDomainAppLifecycleManagementFactory AppLifecycleManagementFactory { get; set; }

    protected override Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings Create()
    {
        var jupyterLabAppSettingsResult = CreateJupyterLabAppSettings();
        factoryAction?.Invoke(jupyterLabAppSettingsResult);

        return jupyterLabAppSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings CreateJupyterLabAppSettings()
    {
        var jupyterLabAppSettingsResult = new Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings();

        return jupyterLabAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
        result.AppLifecycleManagement ??= AppLifecycleManagementFactory?.Build();
    }

} // End Of Class

public static class InnerDomainJupyterLabAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerDomainJupyterLabAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec(this InnerDomainJupyterLabAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerDomainResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerDomainJupyterLabAppSettingsFactory, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement(this InnerDomainJupyterLabAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null)
    {
        parentFactory.AppLifecycleManagementFactory = new InnerDomainAppLifecycleManagementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AppLifecycleManagementFactory);
    }

    public static CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainJupyterLabAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainJupyterLabAppSettingsFactory, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainJupyterLabAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainJupyterLabAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1>(this CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1>(this CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2, T3, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2, T3, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory, T3, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainJupyterLabAppSettingsFactory, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2, T3, T4, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<InnerDomainJupyterLabAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2, T3, T4, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainJupyterLabAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory, T3, T4, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainJupyterLabAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainJupyterLabAppSettingsFactory, T4, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainJupyterLabAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainJupyterLabAppSettingsFactory, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T5, subFactoryAction));
}
