// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceJupyterServerAppSettingsFactory(Action<Humidifier.SageMaker.SpaceTypes.JupyterServerAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.JupyterServerAppSettings>
{

    internal InnerSpaceResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    protected override Humidifier.SageMaker.SpaceTypes.JupyterServerAppSettings Create()
    {
        var jupyterServerAppSettingsResult = CreateJupyterServerAppSettings();
        factoryAction?.Invoke(jupyterServerAppSettingsResult);

        return jupyterServerAppSettingsResult;
    }

    private Humidifier.SageMaker.SpaceTypes.JupyterServerAppSettings CreateJupyterServerAppSettings()
    {
        var jupyterServerAppSettingsResult = new Humidifier.SageMaker.SpaceTypes.JupyterServerAppSettings();

        return jupyterServerAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.SpaceTypes.JupyterServerAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
    }

} // End Of Class

public static class InnerSpaceJupyterServerAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerSpaceJupyterServerAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec(this InnerSpaceJupyterServerAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerSpaceResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerSpaceJupyterServerAppSettingsFactory, T1, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerSpaceJupyterServerAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceJupyterServerAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerSpaceJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpaceJupyterServerAppSettingsFactory, T1, T2, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerSpaceJupyterServerAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceJupyterServerAppSettingsFactory, T2, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerSpaceJupyterServerAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceJupyterServerAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerSpaceJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpaceJupyterServerAppSettingsFactory, T1, T2, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerSpaceJupyterServerAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceJupyterServerAppSettingsFactory, T2, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerSpaceJupyterServerAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceJupyterServerAppSettingsFactory, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpaceJupyterServerAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceJupyterServerAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpaceJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpaceJupyterServerAppSettingsFactory, T1, T2, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerSpaceJupyterServerAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceJupyterServerAppSettingsFactory, T2, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpaceJupyterServerAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceJupyterServerAppSettingsFactory, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpaceJupyterServerAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceJupyterServerAppSettingsFactory, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpaceJupyterServerAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpaceJupyterServerAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpaceJupyterServerAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
}
