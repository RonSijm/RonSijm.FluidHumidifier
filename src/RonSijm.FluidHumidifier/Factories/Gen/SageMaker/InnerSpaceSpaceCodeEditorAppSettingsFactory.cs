// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceSpaceCodeEditorAppSettingsFactory(Action<Humidifier.SageMaker.SpaceTypes.SpaceCodeEditorAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.SpaceCodeEditorAppSettings>
{

    internal InnerSpaceResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    internal InnerSpaceSpaceAppLifecycleManagementFactory AppLifecycleManagementFactory { get; set; }

    protected override Humidifier.SageMaker.SpaceTypes.SpaceCodeEditorAppSettings Create()
    {
        var spaceCodeEditorAppSettingsResult = CreateSpaceCodeEditorAppSettings();
        factoryAction?.Invoke(spaceCodeEditorAppSettingsResult);

        return spaceCodeEditorAppSettingsResult;
    }

    private Humidifier.SageMaker.SpaceTypes.SpaceCodeEditorAppSettings CreateSpaceCodeEditorAppSettings()
    {
        var spaceCodeEditorAppSettingsResult = new Humidifier.SageMaker.SpaceTypes.SpaceCodeEditorAppSettings();

        return spaceCodeEditorAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.SpaceTypes.SpaceCodeEditorAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
        result.AppLifecycleManagement ??= AppLifecycleManagementFactory?.Build();
    }

} // End Of Class

public static class InnerSpaceSpaceCodeEditorAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec(this InnerSpaceSpaceCodeEditorAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerSpaceResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement(this InnerSpaceSpaceCodeEditorAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null)
    {
        parentFactory.AppLifecycleManagementFactory = new InnerSpaceSpaceAppLifecycleManagementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AppLifecycleManagementFactory);
    }

    public static CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceCodeEditorAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceCodeEditorAppSettingsFactory, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceCodeEditorAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceCodeEditorAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1>(this CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1>(this CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2, T3, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2, T3, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory, T3, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceCodeEditorAppSettingsFactory, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2, T3, T4, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<InnerSpaceSpaceCodeEditorAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2, T3, T4, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpaceSpaceCodeEditorAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory, T3, T4, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpaceSpaceCodeEditorAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceCodeEditorAppSettingsFactory, T4, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceCodeEditorAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceCodeEditorAppSettingsFactory, InnerSpaceSpaceAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T5, subFactoryAction));
}
