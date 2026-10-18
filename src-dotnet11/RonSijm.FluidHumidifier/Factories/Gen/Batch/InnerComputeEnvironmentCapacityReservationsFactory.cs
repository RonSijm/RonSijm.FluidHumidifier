// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentCapacityReservationsFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.CapacityReservations> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.CapacityReservations>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.CapacityReservations Create()
    {
        var capacityReservationsResult = CreateCapacityReservations();
        factoryAction?.Invoke(capacityReservationsResult);

        return capacityReservationsResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.CapacityReservations CreateCapacityReservations()
    {
        var capacityReservationsResult = new Humidifier.Batch.ComputeEnvironmentTypes.CapacityReservations();

        return capacityReservationsResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentCapacityReservationsFactoryExtensions
{
}
