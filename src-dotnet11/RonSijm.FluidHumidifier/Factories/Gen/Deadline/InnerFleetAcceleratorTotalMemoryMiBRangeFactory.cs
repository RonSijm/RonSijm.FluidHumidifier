// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetAcceleratorTotalMemoryMiBRangeFactory(Action<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange>
{

    protected override Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange Create()
    {
        var acceleratorTotalMemoryMiBRangeResult = CreateAcceleratorTotalMemoryMiBRange();
        factoryAction?.Invoke(acceleratorTotalMemoryMiBRangeResult);

        return acceleratorTotalMemoryMiBRangeResult;
    }

    private Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange CreateAcceleratorTotalMemoryMiBRange()
    {
        var acceleratorTotalMemoryMiBRangeResult = new Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange();

        return acceleratorTotalMemoryMiBRangeResult;
    }

} // End Of Class

public static class InnerFleetAcceleratorTotalMemoryMiBRangeFactoryExtensions
{
}
