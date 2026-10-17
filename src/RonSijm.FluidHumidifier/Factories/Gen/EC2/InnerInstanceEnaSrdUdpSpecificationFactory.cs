// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceEnaSrdUdpSpecificationFactory(Action<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification>
{

    protected override Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification Create()
    {
        var enaSrdUdpSpecificationResult = CreateEnaSrdUdpSpecification();
        factoryAction?.Invoke(enaSrdUdpSpecificationResult);

        return enaSrdUdpSpecificationResult;
    }

    private Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification CreateEnaSrdUdpSpecification()
    {
        var enaSrdUdpSpecificationResult = new Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification();

        return enaSrdUdpSpecificationResult;
    }

} // End Of Class

public static class InnerInstanceEnaSrdUdpSpecificationFactoryExtensions
{
}
