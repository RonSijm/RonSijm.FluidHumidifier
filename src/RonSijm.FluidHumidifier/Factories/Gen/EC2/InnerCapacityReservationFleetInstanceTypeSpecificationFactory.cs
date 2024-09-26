// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerCapacityReservationFleetInstanceTypeSpecificationFactory(Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification>
{

    protected override Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification Create()
    {
        var instanceTypeSpecificationResult = CreateInstanceTypeSpecification();
        factoryAction?.Invoke(instanceTypeSpecificationResult);

        return instanceTypeSpecificationResult;
    }

    private Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification CreateInstanceTypeSpecification()
    {
        var instanceTypeSpecificationResult = new Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification();

        return instanceTypeSpecificationResult;
    }

} // End Of Class

public static class InnerCapacityReservationFleetInstanceTypeSpecificationFactoryExtensions
{
}
