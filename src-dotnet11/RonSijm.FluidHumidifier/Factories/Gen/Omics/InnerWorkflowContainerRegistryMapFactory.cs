// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerWorkflowContainerRegistryMapFactory(Action<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap> factoryAction = null) : SubResourceFactory<Humidifier.Omics.WorkflowTypes.ContainerRegistryMap>
{

    protected override Humidifier.Omics.WorkflowTypes.ContainerRegistryMap Create()
    {
        var containerRegistryMapResult = CreateContainerRegistryMap();
        factoryAction?.Invoke(containerRegistryMapResult);

        return containerRegistryMapResult;
    }

    private Humidifier.Omics.WorkflowTypes.ContainerRegistryMap CreateContainerRegistryMap()
    {
        var containerRegistryMapResult = new Humidifier.Omics.WorkflowTypes.ContainerRegistryMap();

        return containerRegistryMapResult;
    }

} // End Of Class

public static class InnerWorkflowContainerRegistryMapFactoryExtensions
{
}
