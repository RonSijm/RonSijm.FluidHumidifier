// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainCodeEditorAppSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.CodeEditorAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.CodeEditorAppSettings>
{

    internal InnerDomainResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    internal InnerDomainAppLifecycleManagementFactory AppLifecycleManagementFactory { get; set; }

    protected override Humidifier.SageMaker.DomainTypes.CodeEditorAppSettings Create()
    {
        var codeEditorAppSettingsResult = CreateCodeEditorAppSettings();
        factoryAction?.Invoke(codeEditorAppSettingsResult);

        return codeEditorAppSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.CodeEditorAppSettings CreateCodeEditorAppSettings()
    {
        var codeEditorAppSettingsResult = new Humidifier.SageMaker.DomainTypes.CodeEditorAppSettings();

        return codeEditorAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DomainTypes.CodeEditorAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
        result.AppLifecycleManagement ??= AppLifecycleManagementFactory?.Build();
    }

} // End Of Class

public static class InnerDomainCodeEditorAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerDomainCodeEditorAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec(this InnerDomainCodeEditorAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerDomainResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerDomainCodeEditorAppSettingsFactory, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement(this InnerDomainCodeEditorAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null)
    {
        parentFactory.AppLifecycleManagementFactory = new InnerDomainAppLifecycleManagementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AppLifecycleManagementFactory);
    }

    public static CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainCodeEditorAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainCodeEditorAppSettingsFactory, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainCodeEditorAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainCodeEditorAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1>(this CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1>(this CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2>(this CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2, T3, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2, T3, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory, T3, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainCodeEditorAppSettingsFactory, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2, T3, T4, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<InnerDomainCodeEditorAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2, T3, T4, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainCodeEditorAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory, T3, T4, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainCodeEditorAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainCodeEditorAppSettingsFactory, T4, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainCodeEditorAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainCodeEditorAppSettingsFactory, InnerDomainAppLifecycleManagementFactory> WithAppLifecycleManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainCodeEditorAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppLifecycleManagement(combinedResult.T5, subFactoryAction));
}
