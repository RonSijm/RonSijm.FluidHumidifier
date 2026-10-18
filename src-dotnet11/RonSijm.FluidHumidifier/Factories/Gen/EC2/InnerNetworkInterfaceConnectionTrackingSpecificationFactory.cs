// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkInterfaceConnectionTrackingSpecificationFactory(Action<Humidifier.EC2.NetworkInterfaceTypes.ConnectionTrackingSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkInterfaceTypes.ConnectionTrackingSpecification>
{

    protected override Humidifier.EC2.NetworkInterfaceTypes.ConnectionTrackingSpecification Create()
    {
        var connectionTrackingSpecificationResult = CreateConnectionTrackingSpecification();
        factoryAction?.Invoke(connectionTrackingSpecificationResult);

        return connectionTrackingSpecificationResult;
    }

    private Humidifier.EC2.NetworkInterfaceTypes.ConnectionTrackingSpecification CreateConnectionTrackingSpecification()
    {
        var connectionTrackingSpecificationResult = new Humidifier.EC2.NetworkInterfaceTypes.ConnectionTrackingSpecification();

        return connectionTrackingSpecificationResult;
    }

} // End Of Class

public static class InnerNetworkInterfaceConnectionTrackingSpecificationFactoryExtensions
{
}
