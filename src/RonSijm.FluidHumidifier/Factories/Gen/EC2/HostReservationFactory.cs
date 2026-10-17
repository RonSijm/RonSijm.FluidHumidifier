// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class HostReservationFactory(string resourceName = null, Action<Humidifier.EC2.HostReservation> factoryAction = null) : ResourceFactory<Humidifier.EC2.HostReservation>(resourceName)
{

    protected override Humidifier.EC2.HostReservation Create()
    {
        var hostReservationResult = CreateHostReservation();
        factoryAction?.Invoke(hostReservationResult);

        return hostReservationResult;
    }

    private Humidifier.EC2.HostReservation CreateHostReservation()
    {
        var hostReservationResult = new Humidifier.EC2.HostReservation
        {
            GivenName = InputResourceName,
        };

        return hostReservationResult;
    }

} // End Of Class

public static class HostReservationFactoryExtensions
{
}
