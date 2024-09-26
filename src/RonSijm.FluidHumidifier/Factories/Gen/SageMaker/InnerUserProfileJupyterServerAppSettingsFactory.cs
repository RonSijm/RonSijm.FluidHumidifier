// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileJupyterServerAppSettingsFactory(Action<Humidifier.SageMaker.UserProfileTypes.JupyterServerAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.JupyterServerAppSettings>
{

    internal InnerUserProfileResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    protected override Humidifier.SageMaker.UserProfileTypes.JupyterServerAppSettings Create()
    {
        var jupyterServerAppSettingsResult = CreateJupyterServerAppSettings();
        factoryAction?.Invoke(jupyterServerAppSettingsResult);

        return jupyterServerAppSettingsResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.JupyterServerAppSettings CreateJupyterServerAppSettings()
    {
        var jupyterServerAppSettingsResult = new Humidifier.SageMaker.UserProfileTypes.JupyterServerAppSettings();

        return jupyterServerAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.UserProfileTypes.JupyterServerAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
    }

} // End Of Class

public static class InnerUserProfileJupyterServerAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerUserProfileJupyterServerAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec(this InnerUserProfileJupyterServerAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerUserProfileResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerUserProfileJupyterServerAppSettingsFactory, T1, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerUserProfileJupyterServerAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterServerAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerUserProfileJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerUserProfileJupyterServerAppSettingsFactory, T1, T2, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerUserProfileJupyterServerAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterServerAppSettingsFactory, T2, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerUserProfileJupyterServerAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileJupyterServerAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerUserProfileJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerUserProfileJupyterServerAppSettingsFactory, T1, T2, T3, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerUserProfileJupyterServerAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterServerAppSettingsFactory, T2, T3, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerUserProfileJupyterServerAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileJupyterServerAppSettingsFactory, T3, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserProfileJupyterServerAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileJupyterServerAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserProfileJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerUserProfileJupyterServerAppSettingsFactory, T1, T2, T3, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerUserProfileJupyterServerAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileJupyterServerAppSettingsFactory, T2, T3, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserProfileJupyterServerAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileJupyterServerAppSettingsFactory, T3, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserProfileJupyterServerAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileJupyterServerAppSettingsFactory, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserProfileJupyterServerAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerUserProfileJupyterServerAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserProfileJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
}
