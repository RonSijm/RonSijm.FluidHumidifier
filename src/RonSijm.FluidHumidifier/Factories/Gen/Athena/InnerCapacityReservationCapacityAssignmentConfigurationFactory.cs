// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerCapacityReservationCapacityAssignmentConfigurationFactory(Action<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration>
{

    protected override Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration Create()
    {
        var capacityAssignmentConfigurationResult = CreateCapacityAssignmentConfiguration();
        factoryAction?.Invoke(capacityAssignmentConfigurationResult);

        return capacityAssignmentConfigurationResult;
    }

    private Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration CreateCapacityAssignmentConfiguration()
    {
        var capacityAssignmentConfigurationResult = new Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration();

        return capacityAssignmentConfigurationResult;
    }

} // End Of Class

public static class InnerCapacityReservationCapacityAssignmentConfigurationFactoryExtensions
{
}
