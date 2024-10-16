// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceSpaceJupyterLabAppSettingsFactory(Action<Humidifier.SageMaker.SpaceTypes.SpaceJupyterLabAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.SpaceJupyterLabAppSettings>
{

    internal InnerSpaceResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    internal InnerSpaceSpaceAppLifecycleManagementFactory AppLifecycleManagementFactory { get; set; }

    protected override Humidifier.SageMaker.SpaceTypes.SpaceJupyterLabAppSettings Create()
    {
        var spaceJupyterLabAppSettingsResult = CreateSpaceJupyterLabAppSettings();
        factoryAction?.Invoke(spaceJupyterLabAppSettingsResult);

        return spaceJupyterLabAppSettingsResult;
    }

    private Humidifier.SageMaker.SpaceTypes.SpaceJupyterLabAppSettings CreateSpaceJupyterLabAppSettings()
    {
        var spaceJupyterLabAppSettingsResult = new Humidifier.SageMaker.SpaceTypes.SpaceJupyterLabAppSettings();

        return spaceJupyterLabAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.SpaceTypes.SpaceJupyterLabAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
        result.AppLifecycleManagement ??= AppLifecycleManagementFactory?.Build();
    }

} // End Of Class

public static class InnerSpaceSpaceJupyterLabAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec(this InnerSpaceSpaceJupyterLabAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerSpaceResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement(this InnerSpaceSpaceJupyterLabAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null)
    {
        parentFactory.AppLifecycleManagementFactory = new InnerSpaceSpaceAppLifecycleManagementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AppLifecycleManagementFactory);
    }

    public static CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceJupyterLabAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceJupyterLabAppSettingsFactory, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceJupyterLabAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceJupyterLabAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1>(this CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1>(this CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2, T3, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2, T3, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory, T3, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceJupyterLabAppSettingsFactory, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2, T3, T4, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<InnerSpaceSpaceJupyterLabAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2, T3, T4, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpaceSpaceJupyterLabAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory, T3, T4, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpaceSpaceJupyterLabAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceJupyterLabAppSettingsFactory, T4, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceJupyterLabAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceJupyterLabAppSettingsFactory, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceJupyterLabAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T5, subFactoryAction));
}
