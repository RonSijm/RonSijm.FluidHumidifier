// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class ReservationFactory(string resourceName = null, Action<Humidifier.MediaConnect.Reservation> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.Reservation>(resourceName)
{

    protected override Humidifier.MediaConnect.Reservation Create()
    {
        var reservationResult = CreateReservation();
        factoryAction?.Invoke(reservationResult);

        return reservationResult;
    }

    private Humidifier.MediaConnect.Reservation CreateReservation()
    {
        var reservationResult = new Humidifier.MediaConnect.Reservation
        {
            GivenName = InputResourceName,
        };

        return reservationResult;
    }

} // End Of Class

public static class ReservationFactoryExtensions
{
}
