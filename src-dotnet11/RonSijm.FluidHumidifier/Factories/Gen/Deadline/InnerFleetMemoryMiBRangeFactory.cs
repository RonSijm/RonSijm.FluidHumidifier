// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetMemoryMiBRangeFactory(Action<Humidifier.Deadline.FleetTypes.MemoryMiBRange> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.MemoryMiBRange>
{

    protected override Humidifier.Deadline.FleetTypes.MemoryMiBRange Create()
    {
        var memoryMiBRangeResult = CreateMemoryMiBRange();
        factoryAction?.Invoke(memoryMiBRangeResult);

        return memoryMiBRangeResult;
    }

    private Humidifier.Deadline.FleetTypes.MemoryMiBRange CreateMemoryMiBRange()
    {
        var memoryMiBRangeResult = new Humidifier.Deadline.FleetTypes.MemoryMiBRange();

        return memoryMiBRangeResult;
    }

} // End Of Class

public static class InnerFleetMemoryMiBRangeFactoryExtensions
{
}
