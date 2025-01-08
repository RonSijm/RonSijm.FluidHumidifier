// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory(Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions>
{

    protected override Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions Create()
    {
        var onDemandCapacityReservationOptionsResult = CreateOnDemandCapacityReservationOptions();
        factoryAction?.Invoke(onDemandCapacityReservationOptionsResult);

        return onDemandCapacityReservationOptionsResult;
    }

    private Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions CreateOnDemandCapacityReservationOptions()
    {
        var onDemandCapacityReservationOptionsResult = new Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions();

        return onDemandCapacityReservationOptionsResult;
    }

} // End Of Class

public static class InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactoryExtensions
{
}
