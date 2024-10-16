// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileJupyterLabAppSettingsFactory(Action<Humidifier.SageMaker.UserProfileTypes.JupyterLabAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.JupyterLabAppSettings>
{

    internal InnerUserProfileResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    internal InnerUserProfileAppLifecycleManagementFactory AppLifecycleManagementFactory { get; set; }

    protected override Humidifier.SageMaker.UserProfileTypes.JupyterLabAppSettings Create()
    {
        var jupyterLabAppSettingsResult = CreateJupyterLabAppSettings();
        factoryAction?.Invoke(jupyterLabAppSettingsResult);

        return jupyterLabAppSettingsResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.JupyterLabAppSettings CreateJupyterLabAppSettings()
    {
        var jupyterLabAppSettingsResult = new Humidifier.SageMaker.UserProfileTypes.JupyterLabAppSettings();

        return jupyterLabAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.UserProfileTypes.JupyterLabAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
        result.AppLifecycleManagement ??= AppLifecycleManagementFactory?.Build();
    }

} // End Of Class

public static class InnerUserProfileJupyterLabAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec(this InnerUserProfileJupyterLabAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerUserProfileResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement(this InnerUserProfileJupyterLabAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null)
    {
        parentFactory.AppLifecycleManagementFactory = new InnerUserProfileAppLifecycleManagementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AppLifecycleManagementFactory);
    }

    public static CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2, T3, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2, T3, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory, T3, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileJupyterLabAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserProfileJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2, T3, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2, T3, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory, T3, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileJupyterLabAppSettingsFactory, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserProfileJupyterLabAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerUserProfileJupyterLabAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserProfileJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1>(this CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1>(this CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2, T3, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2, T3, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory, T3, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileJupyterLabAppSettingsFactory, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserProfileJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2, T3, T4, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<InnerUserProfileJupyterLabAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2, T3, T4, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserProfileJupyterLabAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory, T3, T4, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserProfileJupyterLabAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileJupyterLabAppSettingsFactory, T4, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserProfileJupyterLabAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerUserProfileJupyterLabAppSettingsFactory, InnerUserProfileAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserProfileJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T5, subFactoryAction));
}
