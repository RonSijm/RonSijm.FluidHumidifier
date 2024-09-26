// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainJupyterServerAppSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings>
{

    internal InnerDomainResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    protected override Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings Create()
    {
        var jupyterServerAppSettingsResult = CreateJupyterServerAppSettings();
        factoryAction?.Invoke(jupyterServerAppSettingsResult);

        return jupyterServerAppSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings CreateJupyterServerAppSettings()
    {
        var jupyterServerAppSettingsResult = new Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings();

        return jupyterServerAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
    }

} // End Of Class

public static class InnerDomainJupyterServerAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerDomainJupyterServerAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec(this InnerDomainJupyterServerAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerDomainResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerDomainJupyterServerAppSettingsFactory, T1, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerDomainJupyterServerAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterServerAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerDomainJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainJupyterServerAppSettingsFactory, T1, T2, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerDomainJupyterServerAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterServerAppSettingsFactory, T2, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerDomainJupyterServerAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainJupyterServerAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerDomainJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainJupyterServerAppSettingsFactory, T1, T2, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerDomainJupyterServerAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterServerAppSettingsFactory, T2, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerDomainJupyterServerAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainJupyterServerAppSettingsFactory, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainJupyterServerAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainJupyterServerAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainJupyterServerAppSettingsFactory, T1, T2, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerDomainJupyterServerAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainJupyterServerAppSettingsFactory, T2, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainJupyterServerAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainJupyterServerAppSettingsFactory, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainJupyterServerAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainJupyterServerAppSettingsFactory, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainJupyterServerAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainJupyterServerAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
}
