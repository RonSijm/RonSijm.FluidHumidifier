// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonTaskDefinitionKernelCapabilitiesFactory(Action<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities>
{

    protected override Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities Create()
    {
        var kernelCapabilitiesResult = CreateKernelCapabilities();
        factoryAction?.Invoke(kernelCapabilitiesResult);

        return kernelCapabilitiesResult;
    }

    private Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities CreateKernelCapabilities()
    {
        var kernelCapabilitiesResult = new Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities();

        return kernelCapabilitiesResult;
    }

} // End Of Class

public static class InnerDaemonTaskDefinitionKernelCapabilitiesFactoryExtensions
{
}
