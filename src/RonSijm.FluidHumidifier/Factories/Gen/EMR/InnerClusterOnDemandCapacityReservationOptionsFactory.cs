// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterOnDemandCapacityReservationOptionsFactory(Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions>
{

    protected override Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions Create()
    {
        var onDemandCapacityReservationOptionsResult = CreateOnDemandCapacityReservationOptions();
        factoryAction?.Invoke(onDemandCapacityReservationOptionsResult);

        return onDemandCapacityReservationOptionsResult;
    }

    private Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions CreateOnDemandCapacityReservationOptions()
    {
        var onDemandCapacityReservationOptionsResult = new Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions();

        return onDemandCapacityReservationOptionsResult;
    }

} // End Of Class

public static class InnerClusterOnDemandCapacityReservationOptionsFactoryExtensions
{
}
