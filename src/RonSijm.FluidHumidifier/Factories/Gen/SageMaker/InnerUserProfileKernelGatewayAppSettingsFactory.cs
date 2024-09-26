// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileKernelGatewayAppSettingsFactory(Action<Humidifier.SageMaker.UserProfileTypes.KernelGatewayAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.KernelGatewayAppSettings>
{

    internal InnerUserProfileResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    protected override Humidifier.SageMaker.UserProfileTypes.KernelGatewayAppSettings Create()
    {
        var kernelGatewayAppSettingsResult = CreateKernelGatewayAppSettings();
        factoryAction?.Invoke(kernelGatewayAppSettingsResult);

        return kernelGatewayAppSettingsResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.KernelGatewayAppSettings CreateKernelGatewayAppSettings()
    {
        var kernelGatewayAppSettingsResult = new Humidifier.SageMaker.UserProfileTypes.KernelGatewayAppSettings();

        return kernelGatewayAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.UserProfileTypes.KernelGatewayAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
    }

} // End Of Class

public static class InnerUserProfileKernelGatewayAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerUserProfileKernelGatewayAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec(this InnerUserProfileKernelGatewayAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerUserProfileResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerUserProfileKernelGatewayAppSettingsFactory, T1, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerUserProfileKernelGatewayAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileKernelGatewayAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerUserProfileKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerUserProfileKernelGatewayAppSettingsFactory, T1, T2, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerUserProfileKernelGatewayAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileKernelGatewayAppSettingsFactory, T2, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerUserProfileKernelGatewayAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileKernelGatewayAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerUserProfileKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerUserProfileKernelGatewayAppSettingsFactory, T1, T2, T3, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerUserProfileKernelGatewayAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileKernelGatewayAppSettingsFactory, T2, T3, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerUserProfileKernelGatewayAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileKernelGatewayAppSettingsFactory, T3, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserProfileKernelGatewayAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileKernelGatewayAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserProfileKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerUserProfileKernelGatewayAppSettingsFactory, T1, T2, T3, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerUserProfileKernelGatewayAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserProfileKernelGatewayAppSettingsFactory, T2, T3, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserProfileKernelGatewayAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserProfileKernelGatewayAppSettingsFactory, T3, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserProfileKernelGatewayAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserProfileKernelGatewayAppSettingsFactory, T4, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserProfileKernelGatewayAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerUserProfileKernelGatewayAppSettingsFactory, InnerUserProfileResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserProfileKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
}
