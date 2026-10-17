// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerWorkflowVersionContainerRegistryMapFactory(Action<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap> factoryAction = null) : SubResourceFactory<Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap>
{

    protected override Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap Create()
    {
        var containerRegistryMapResult = CreateContainerRegistryMap();
        factoryAction?.Invoke(containerRegistryMapResult);

        return containerRegistryMapResult;
    }

    private Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap CreateContainerRegistryMap()
    {
        var containerRegistryMapResult = new Humidifier.Omics.WorkflowVersionTypes.ContainerRegistryMap();

        return containerRegistryMapResult;
    }

} // End Of Class

public static class InnerWorkflowVersionContainerRegistryMapFactoryExtensions
{
}
