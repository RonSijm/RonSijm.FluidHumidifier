// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderCapacityReservationRequestFactory(Action<Humidifier.ECS.CapacityProviderTypes.CapacityReservationRequest> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.CapacityReservationRequest>
{

    protected override Humidifier.ECS.CapacityProviderTypes.CapacityReservationRequest Create()
    {
        var capacityReservationRequestResult = CreateCapacityReservationRequest();
        factoryAction?.Invoke(capacityReservationRequestResult);

        return capacityReservationRequestResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.CapacityReservationRequest CreateCapacityReservationRequest()
    {
        var capacityReservationRequestResult = new Humidifier.ECS.CapacityProviderTypes.CapacityReservationRequest();

        return capacityReservationRequestResult;
    }

} // End Of Class

public static class InnerCapacityProviderCapacityReservationRequestFactoryExtensions
{
}
