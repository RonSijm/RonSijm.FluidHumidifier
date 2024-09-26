// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAppImageConfigKernelGatewayImageConfigFactory(Action<Humidifier.SageMaker.AppImageConfigTypes.KernelGatewayImageConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AppImageConfigTypes.KernelGatewayImageConfig>
{

    internal InnerAppImageConfigFileSystemConfigFactory FileSystemConfigFactory { get; set; }

    protected override Humidifier.SageMaker.AppImageConfigTypes.KernelGatewayImageConfig Create()
    {
        var kernelGatewayImageConfigResult = CreateKernelGatewayImageConfig();
        factoryAction?.Invoke(kernelGatewayImageConfigResult);

        return kernelGatewayImageConfigResult;
    }

    private Humidifier.SageMaker.AppImageConfigTypes.KernelGatewayImageConfig CreateKernelGatewayImageConfig()
    {
        var kernelGatewayImageConfigResult = new Humidifier.SageMaker.AppImageConfigTypes.KernelGatewayImageConfig();

        return kernelGatewayImageConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AppImageConfigTypes.KernelGatewayImageConfig result)
    {
        base.CreateChildren(result);

        result.FileSystemConfig ??= FileSystemConfigFactory?.Build();
    }

} // End Of Class

public static class InnerAppImageConfigKernelGatewayImageConfigFactoryExtensions
{
    public static CombinedResult<InnerAppImageConfigKernelGatewayImageConfigFactory, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig(this InnerAppImageConfigKernelGatewayImageConfigFactory parentFactory, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null)
    {
        parentFactory.FileSystemConfigFactory = new InnerAppImageConfigFileSystemConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileSystemConfigFactory);
    }

    public static CombinedResult<InnerAppImageConfigKernelGatewayImageConfigFactory, T1, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1>(this CombinedResult<InnerAppImageConfigKernelGatewayImageConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigKernelGatewayImageConfigFactory, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1>(this CombinedResult<T1, InnerAppImageConfigKernelGatewayImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAppImageConfigKernelGatewayImageConfigFactory, T1, T2, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2>(this CombinedResult<InnerAppImageConfigKernelGatewayImageConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigKernelGatewayImageConfigFactory, T2, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2>(this CombinedResult<T1, InnerAppImageConfigKernelGatewayImageConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppImageConfigKernelGatewayImageConfigFactory, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2>(this CombinedResult<T1, T2, InnerAppImageConfigKernelGatewayImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAppImageConfigKernelGatewayImageConfigFactory, T1, T2, T3, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2, T3>(this CombinedResult<InnerAppImageConfigKernelGatewayImageConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigKernelGatewayImageConfigFactory, T2, T3, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2, T3>(this CombinedResult<T1, InnerAppImageConfigKernelGatewayImageConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppImageConfigKernelGatewayImageConfigFactory, T3, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppImageConfigKernelGatewayImageConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppImageConfigKernelGatewayImageConfigFactory, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppImageConfigKernelGatewayImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAppImageConfigKernelGatewayImageConfigFactory, T1, T2, T3, T4, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2, T3, T4>(this CombinedResult<InnerAppImageConfigKernelGatewayImageConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppImageConfigKernelGatewayImageConfigFactory, T2, T3, T4, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppImageConfigKernelGatewayImageConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppImageConfigKernelGatewayImageConfigFactory, T3, T4, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppImageConfigKernelGatewayImageConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppImageConfigKernelGatewayImageConfigFactory, T4, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppImageConfigKernelGatewayImageConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAppImageConfigKernelGatewayImageConfigFactory, InnerAppImageConfigFileSystemConfigFactory> WithFileSystemConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppImageConfigKernelGatewayImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemConfig(combinedResult.T5, subFactoryAction));
}
