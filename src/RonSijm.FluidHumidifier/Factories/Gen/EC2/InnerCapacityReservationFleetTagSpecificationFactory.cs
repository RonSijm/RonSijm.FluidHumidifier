// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerCapacityReservationFleetTagSpecificationFactory(Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification>
{

    protected override Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification Create()
    {
        var tagSpecificationResult = CreateTagSpecification();
        factoryAction?.Invoke(tagSpecificationResult);

        return tagSpecificationResult;
    }

    private Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification CreateTagSpecification()
    {
        var tagSpecificationResult = new Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification();

        return tagSpecificationResult;
    }

} // End Of Class

public static class InnerCapacityReservationFleetTagSpecificationFactoryExtensions
{
}
