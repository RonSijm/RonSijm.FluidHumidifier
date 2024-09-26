// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetAcceleratorCountRangeFactory(Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.AcceleratorCountRange>
{

    protected override Humidifier.Deadline.FleetTypes.AcceleratorCountRange Create()
    {
        var acceleratorCountRangeResult = CreateAcceleratorCountRange();
        factoryAction?.Invoke(acceleratorCountRangeResult);

        return acceleratorCountRangeResult;
    }

    private Humidifier.Deadline.FleetTypes.AcceleratorCountRange CreateAcceleratorCountRange()
    {
        var acceleratorCountRangeResult = new Humidifier.Deadline.FleetTypes.AcceleratorCountRange();

        return acceleratorCountRangeResult;
    }

} // End Of Class

public static class InnerFleetAcceleratorCountRangeFactoryExtensions
{
}
