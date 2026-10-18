// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class ReservationFactory(string resourceName = null, Action<Humidifier.MediaLive.Reservation> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.Reservation>(resourceName)
{

    protected override Humidifier.MediaLive.Reservation Create()
    {
        var reservationResult = CreateReservation();
        factoryAction?.Invoke(reservationResult);

        return reservationResult;
    }

    private Humidifier.MediaLive.Reservation CreateReservation()
    {
        var reservationResult = new Humidifier.MediaLive.Reservation
        {
            GivenName = InputResourceName,
        };

        return reservationResult;
    }

} // End Of Class

public static class ReservationFactoryExtensions
{
}
