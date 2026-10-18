// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonTaskDefinitionLinuxParametersFactory(Action<Humidifier.ECS.DaemonTaskDefinitionTypes.LinuxParameters> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTaskDefinitionTypes.LinuxParameters>
{

    internal InnerDaemonTaskDefinitionKernelCapabilitiesFactory CapabilitiesFactory { get; set; }

    protected override Humidifier.ECS.DaemonTaskDefinitionTypes.LinuxParameters Create()
    {
        var linuxParametersResult = CreateLinuxParameters();
        factoryAction?.Invoke(linuxParametersResult);

        return linuxParametersResult;
    }

    private Humidifier.ECS.DaemonTaskDefinitionTypes.LinuxParameters CreateLinuxParameters()
    {
        var linuxParametersResult = new Humidifier.ECS.DaemonTaskDefinitionTypes.LinuxParameters();

        return linuxParametersResult;
    }
    public override void CreateChildren(Humidifier.ECS.DaemonTaskDefinitionTypes.LinuxParameters result)
    {
        base.CreateChildren(result);

        result.Capabilities ??= CapabilitiesFactory?.Build();
    }

} // End Of Class

public static class InnerDaemonTaskDefinitionLinuxParametersFactoryExtensions
{
    public static CombinedResult<InnerDaemonTaskDefinitionLinuxParametersFactory, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities(this InnerDaemonTaskDefinitionLinuxParametersFactory parentFactory, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null)
    {
        parentFactory.CapabilitiesFactory = new InnerDaemonTaskDefinitionKernelCapabilitiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapabilitiesFactory);
    }

    public static CombinedResult<InnerDaemonTaskDefinitionLinuxParametersFactory, T1, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1>(this CombinedResult<InnerDaemonTaskDefinitionLinuxParametersFactory, T1> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonTaskDefinitionLinuxParametersFactory, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1>(this CombinedResult<T1, InnerDaemonTaskDefinitionLinuxParametersFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDaemonTaskDefinitionLinuxParametersFactory, T1, T2, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2>(this CombinedResult<InnerDaemonTaskDefinitionLinuxParametersFactory, T1, T2> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonTaskDefinitionLinuxParametersFactory, T2, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2>(this CombinedResult<T1, InnerDaemonTaskDefinitionLinuxParametersFactory, T2> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDaemonTaskDefinitionLinuxParametersFactory, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2>(this CombinedResult<T1, T2, InnerDaemonTaskDefinitionLinuxParametersFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDaemonTaskDefinitionLinuxParametersFactory, T1, T2, T3, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<InnerDaemonTaskDefinitionLinuxParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonTaskDefinitionLinuxParametersFactory, T2, T3, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<T1, InnerDaemonTaskDefinitionLinuxParametersFactory, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDaemonTaskDefinitionLinuxParametersFactory, T3, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, InnerDaemonTaskDefinitionLinuxParametersFactory, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDaemonTaskDefinitionLinuxParametersFactory, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDaemonTaskDefinitionLinuxParametersFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDaemonTaskDefinitionLinuxParametersFactory, T1, T2, T3, T4, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<InnerDaemonTaskDefinitionLinuxParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonTaskDefinitionLinuxParametersFactory, T2, T3, T4, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, InnerDaemonTaskDefinitionLinuxParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDaemonTaskDefinitionLinuxParametersFactory, T3, T4, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDaemonTaskDefinitionLinuxParametersFactory, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDaemonTaskDefinitionLinuxParametersFactory, T4, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDaemonTaskDefinitionLinuxParametersFactory, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDaemonTaskDefinitionLinuxParametersFactory, InnerDaemonTaskDefinitionKernelCapabilitiesFactory> WithCapabilities<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDaemonTaskDefinitionLinuxParametersFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapabilities(combinedResult.T5, subFactoryAction).T2);
}
