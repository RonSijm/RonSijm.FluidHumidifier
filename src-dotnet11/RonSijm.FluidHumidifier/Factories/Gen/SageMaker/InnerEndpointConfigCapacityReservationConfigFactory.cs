// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigCapacityReservationConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.CapacityReservationConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.CapacityReservationConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.CapacityReservationConfig Create()
    {
        var capacityReservationConfigResult = CreateCapacityReservationConfig();
        factoryAction?.Invoke(capacityReservationConfigResult);

        return capacityReservationConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.CapacityReservationConfig CreateCapacityReservationConfig()
    {
        var capacityReservationConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.CapacityReservationConfig();

        return capacityReservationConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigCapacityReservationConfigFactoryExtensions
{
}
