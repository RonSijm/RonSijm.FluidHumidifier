// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetTagSpecificationFactory(Action<Humidifier.EC2.EC2FleetTypes.TagSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.TagSpecification>
{

    protected override Humidifier.EC2.EC2FleetTypes.TagSpecification Create()
    {
        var tagSpecificationResult = CreateTagSpecification();
        factoryAction?.Invoke(tagSpecificationResult);

        return tagSpecificationResult;
    }

    private Humidifier.EC2.EC2FleetTypes.TagSpecification CreateTagSpecification()
    {
        var tagSpecificationResult = new Humidifier.EC2.EC2FleetTypes.TagSpecification();

        return tagSpecificationResult;
    }

} // End Of Class

public static class InnerEC2FleetTagSpecificationFactoryExtensions
{
}
