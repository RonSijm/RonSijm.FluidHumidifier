// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetVCpuCountRangeFactory(Action<Humidifier.Deadline.FleetTypes.VCpuCountRange> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.VCpuCountRange>
{

    protected override Humidifier.Deadline.FleetTypes.VCpuCountRange Create()
    {
        var vCpuCountRangeResult = CreateVCpuCountRange();
        factoryAction?.Invoke(vCpuCountRangeResult);

        return vCpuCountRangeResult;
    }

    private Humidifier.Deadline.FleetTypes.VCpuCountRange CreateVCpuCountRange()
    {
        var vCpuCountRangeResult = new Humidifier.Deadline.FleetTypes.VCpuCountRange();

        return vCpuCountRangeResult;
    }

} // End Of Class

public static class InnerFleetVCpuCountRangeFactoryExtensions
{
}
