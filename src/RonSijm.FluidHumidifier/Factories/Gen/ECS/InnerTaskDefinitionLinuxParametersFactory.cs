// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionLinuxParametersFactory(Action<Humidifier.ECS.TaskDefinitionTypes.LinuxParameters> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.LinuxParameters>
{

    internal InnerTaskDefinitionKernelCapabilitiesFactory CapabilitiesFactory { get; set; }

    protected override Humidifier.ECS.TaskDefinitionTypes.LinuxParameters Create()
    {
        var linuxParametersResult = CreateLinuxParameters();
        factoryAction?.Invoke(linuxParametersResult);

        return linuxParametersResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.LinuxParameters CreateLinuxParameters()
    {
        var linuxParametersResult = new Humidifier.ECS.TaskDefinitionTypes.LinuxParameters();

        return linuxParametersResult;
    }
    public override void CreateChildren(Humidifier.ECS.TaskDefinitionTypes.LinuxParameters result)
    {
        base.CreateChildren(result);

        result.Capabilities ??= CapabilitiesFactory?.Build();
    }

} // End Of Class

public static class InnerTaskDefinitionLinuxParametersFactoryExtensions
{
    public static CombinedResult<InnerTaskDefinitionLinuxParametersFactory, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities(this InnerTaskDefinitionLinuxParametersFactory parentFactory, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null)
    {
        parentFactory.CapabilitiesFactory = new InnerTaskDefinitionKernelCapabilitiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapabilitiesFactory);
    }

    public static CombinedResult<InnerTaskDefinitionLinuxParametersFactory, T1, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1>(this CombinedResult<InnerTaskDefinitionLinuxParametersFactory, T1> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionLinuxParametersFactory, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1>(this CombinedResult<T1, InnerTaskDefinitionLinuxParametersFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionLinuxParametersFactory, T1, T2, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2>(this CombinedResult<InnerTaskDefinitionLinuxParametersFactory, T1, T2> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionLinuxParametersFactory, T2, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2>(this CombinedResult<T1, InnerTaskDefinitionLinuxParametersFactory, T2> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionLinuxParametersFactory, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2>(this CombinedResult<T1, T2, InnerTaskDefinitionLinuxParametersFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionLinuxParametersFactory, T1, T2, T3, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<InnerTaskDefinitionLinuxParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionLinuxParametersFactory, T2, T3, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<T1, InnerTaskDefinitionLinuxParametersFactory, T2, T3> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionLinuxParametersFactory, T3, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskDefinitionLinuxParametersFactory, T3> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskDefinitionLinuxParametersFactory, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskDefinitionLinuxParametersFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionLinuxParametersFactory, T1, T2, T3, T4, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<InnerTaskDefinitionLinuxParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionLinuxParametersFactory, T2, T3, T4, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskDefinitionLinuxParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionLinuxParametersFactory, T3, T4, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskDefinitionLinuxParametersFactory, T3, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskDefinitionLinuxParametersFactory, T4, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskDefinitionLinuxParametersFactory, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskDefinitionLinuxParametersFactory, InnerTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskDefinitionLinuxParametersFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T5, subFactoryAction));
}
