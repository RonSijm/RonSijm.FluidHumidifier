// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerCapacityReservationTagSpecificationFactory(Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.CapacityReservationTypes.TagSpecification>
{

    protected override Humidifier.EC2.CapacityReservationTypes.TagSpecification Create()
    {
        var tagSpecificationResult = CreateTagSpecification();
        factoryAction?.Invoke(tagSpecificationResult);

        return tagSpecificationResult;
    }

    private Humidifier.EC2.CapacityReservationTypes.TagSpecification CreateTagSpecification()
    {
        var tagSpecificationResult = new Humidifier.EC2.CapacityReservationTypes.TagSpecification();

        return tagSpecificationResult;
    }

} // End Of Class

public static class InnerCapacityReservationTagSpecificationFactoryExtensions
{
}
