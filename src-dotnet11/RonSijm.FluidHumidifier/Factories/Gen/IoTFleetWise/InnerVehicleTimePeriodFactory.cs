// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerVehicleTimePeriodFactory(Action<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.VehicleTypes.TimePeriod>
{

    protected override Humidifier.IoTFleetWise.VehicleTypes.TimePeriod Create()
    {
        var timePeriodResult = CreateTimePeriod();
        factoryAction?.Invoke(timePeriodResult);

        return timePeriodResult;
    }

    private Humidifier.IoTFleetWise.VehicleTypes.TimePeriod CreateTimePeriod()
    {
        var timePeriodResult = new Humidifier.IoTFleetWise.VehicleTypes.TimePeriod();

        return timePeriodResult;
    }

} // End Of Class

public static class InnerVehicleTimePeriodFactoryExtensions
{
}
