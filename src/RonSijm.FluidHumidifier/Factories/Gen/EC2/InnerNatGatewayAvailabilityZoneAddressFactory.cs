// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNatGatewayAvailabilityZoneAddressFactory(Action<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress>
{

    protected override Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress Create()
    {
        var availabilityZoneAddressResult = CreateAvailabilityZoneAddress();
        factoryAction?.Invoke(availabilityZoneAddressResult);

        return availabilityZoneAddressResult;
    }

    private Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress CreateAvailabilityZoneAddress()
    {
        var availabilityZoneAddressResult = new Humidifier.EC2.NatGatewayTypes.AvailabilityZoneAddress();

        return availabilityZoneAddressResult;
    }

} // End Of Class

public static class InnerNatGatewayAvailabilityZoneAddressFactoryExtensions
{
}
