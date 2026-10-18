// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SubnetCidrReservationFactory(string resourceName = null, Action<Humidifier.EC2.SubnetCidrReservation> factoryAction = null) : ResourceFactory<Humidifier.EC2.SubnetCidrReservation>(resourceName)
{

    protected override Humidifier.EC2.SubnetCidrReservation Create()
    {
        var subnetCidrReservationResult = CreateSubnetCidrReservation();
        factoryAction?.Invoke(subnetCidrReservationResult);

        return subnetCidrReservationResult;
    }

    private Humidifier.EC2.SubnetCidrReservation CreateSubnetCidrReservation()
    {
        var subnetCidrReservationResult = new Humidifier.EC2.SubnetCidrReservation
        {
            GivenName = InputResourceName,
        };

        return subnetCidrReservationResult;
    }

} // End Of Class

public static class SubnetCidrReservationFactoryExtensions
{
}
