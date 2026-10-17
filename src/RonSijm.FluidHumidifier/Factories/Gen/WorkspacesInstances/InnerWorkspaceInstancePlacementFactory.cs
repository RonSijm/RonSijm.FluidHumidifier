// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstancePlacementFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.Placement> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.Placement>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.Placement Create()
    {
        var placementResult = CreatePlacement();
        factoryAction?.Invoke(placementResult);

        return placementResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.Placement CreatePlacement()
    {
        var placementResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.Placement();

        return placementResult;
    }

} // End Of Class

public static class InnerWorkspaceInstancePlacementFactoryExtensions
{
}
