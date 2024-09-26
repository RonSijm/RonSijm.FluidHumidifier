// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainKernelGatewayAppSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings>
{

    internal InnerDomainResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    protected override Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings Create()
    {
        var kernelGatewayAppSettingsResult = CreateKernelGatewayAppSettings();
        factoryAction?.Invoke(kernelGatewayAppSettingsResult);

        return kernelGatewayAppSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings CreateKernelGatewayAppSettings()
    {
        var kernelGatewayAppSettingsResult = new Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings();

        return kernelGatewayAppSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
    }

} // End Of Class

public static class InnerDomainKernelGatewayAppSettingsFactoryExtensions
{
    public static CombinedResult<InnerDomainKernelGatewayAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec(this InnerDomainKernelGatewayAppSettingsFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerDomainResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerDomainKernelGatewayAppSettingsFactory, T1, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerDomainKernelGatewayAppSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainKernelGatewayAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerDomainKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainKernelGatewayAppSettingsFactory, T1, T2, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerDomainKernelGatewayAppSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainKernelGatewayAppSettingsFactory, T2, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerDomainKernelGatewayAppSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainKernelGatewayAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerDomainKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainKernelGatewayAppSettingsFactory, T1, T2, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerDomainKernelGatewayAppSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainKernelGatewayAppSettingsFactory, T2, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerDomainKernelGatewayAppSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainKernelGatewayAppSettingsFactory, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainKernelGatewayAppSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainKernelGatewayAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainKernelGatewayAppSettingsFactory, T1, T2, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerDomainKernelGatewayAppSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainKernelGatewayAppSettingsFactory, T2, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainKernelGatewayAppSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainKernelGatewayAppSettingsFactory, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainKernelGatewayAppSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainKernelGatewayAppSettingsFactory, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainKernelGatewayAppSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainKernelGatewayAppSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainKernelGatewayAppSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
}
