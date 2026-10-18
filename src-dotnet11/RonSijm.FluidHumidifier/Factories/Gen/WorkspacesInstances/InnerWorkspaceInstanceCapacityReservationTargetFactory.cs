// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceCapacityReservationTargetFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget Create()
    {
        var capacityReservationTargetResult = CreateCapacityReservationTarget();
        factoryAction?.Invoke(capacityReservationTargetResult);

        return capacityReservationTargetResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget CreateCapacityReservationTarget()
    {
        var capacityReservationTargetResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget();

        return capacityReservationTargetResult;
    }

} // End Of Class

public static class InnerWorkspaceInstanceCapacityReservationTargetFactoryExtensions
{
}
