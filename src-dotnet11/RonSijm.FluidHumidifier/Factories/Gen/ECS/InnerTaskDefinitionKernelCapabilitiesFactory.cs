// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionKernelCapabilitiesFactory(Action<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities Create()
    {
        var kernelCapabilitiesResult = CreateKernelCapabilities();
        factoryAction?.Invoke(kernelCapabilitiesResult);

        return kernelCapabilitiesResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities CreateKernelCapabilities()
    {
        var kernelCapabilitiesResult = new Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities();

        return kernelCapabilitiesResult;
    }

} // End Of Class

public static class InnerTaskDefinitionKernelCapabilitiesFactoryExtensions
{
}
