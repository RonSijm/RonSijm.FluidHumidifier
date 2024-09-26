// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetCapacityRebalanceFactory(Action<Humidifier.EC2.EC2FleetTypes.CapacityRebalance> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.CapacityRebalance>
{

    protected override Humidifier.EC2.EC2FleetTypes.CapacityRebalance Create()
    {
        var capacityRebalanceResult = CreateCapacityRebalance();
        factoryAction?.Invoke(capacityRebalanceResult);

        return capacityRebalanceResult;
    }

    private Humidifier.EC2.EC2FleetTypes.CapacityRebalance CreateCapacityRebalance()
    {
        var capacityRebalanceResult = new Humidifier.EC2.EC2FleetTypes.CapacityRebalance();

        return capacityRebalanceResult;
    }

} // End Of Class

public static class InnerEC2FleetCapacityRebalanceFactoryExtensions
{
}
