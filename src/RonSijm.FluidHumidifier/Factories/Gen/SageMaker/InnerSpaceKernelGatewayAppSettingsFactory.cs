// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceKernelGatewayAppSettingsFactory(Action<Humidifier.SageMaker.SpaceTypes.KernelGatewayAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.KernelGatewayAppSettings>
{

    internal InnerSpaceResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    protected override Humidifier.SageMaker.SpaceTypes.KernelGatewayAppSettings Create()
    {
        var kernelGatewayAppSettingsResult = CreateKernelGatewayAppSettings();
        factoryAction?.Invoke(kernelGatewayAppSettingsResult);

        return kernelGatewayAppSettingsResult;
    }

    private Humidifier.SageMaker.SpaceTypes.KernelGatewayAppSettings CreateKernelGatewayAppSettings()
    {
        var kernelGatewayAppSettingsResult = new Humidifier.SageMaker.SpaceTypes.KernelGatewayAppSettings();

        return kernelGatewayAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.SpaceTypes.KernelGatewayAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
    }

} // End Of Class

public static class InnerSpaceKernelGatewayAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerSpaceKernelGatewayAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec(this InnerSpaceKernelGatewayAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerSpaceResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerSpaceKernelGatewayAppSettingsFactory, T1, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerSpaceKernelGatewayAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceKernelGatewayAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerSpaceKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpaceKernelGatewayAppSettingsFactory, T1, T2, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerSpaceKernelGatewayAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceKernelGatewayAppSettingsFactory, T2, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerSpaceKernelGatewayAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceKernelGatewayAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerSpaceKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpaceKernelGatewayAppSettingsFactory, T1, T2, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerSpaceKernelGatewayAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceKernelGatewayAppSettingsFactory, T2, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerSpaceKernelGatewayAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceKernelGatewayAppSettingsFactory, T3, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpaceKernelGatewayAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceKernelGatewayAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpaceKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpaceKernelGatewayAppSettingsFactory, T1, T2, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerSpaceKernelGatewayAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceKernelGatewayAppSettingsFactory, T2, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpaceKernelGatewayAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceKernelGatewayAppSettingsFactory, T3, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpaceKernelGatewayAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceKernelGatewayAppSettingsFactory, T4, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpaceKernelGatewayAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpaceKernelGatewayAppSettingsFactory, InnerSpaceResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpaceKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
}
