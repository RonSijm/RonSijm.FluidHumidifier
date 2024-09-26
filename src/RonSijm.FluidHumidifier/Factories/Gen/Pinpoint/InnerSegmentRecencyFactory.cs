// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerSegmentRecencyFactory(Action<Humidifier.Pinpoint.SegmentTypes.Recency> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.SegmentTypes.Recency>
{

    protected override Humidifier.Pinpoint.SegmentTypes.Recency Create()
    {
        var recencyResult = CreateRecency();
        factoryAction?.Invoke(recencyResult);

        return recencyResult;
    }

    private Humidifier.Pinpoint.SegmentTypes.Recency CreateRecency()
    {
        var recencyResult = new Humidifier.Pinpoint.SegmentTypes.Recency();

        return recencyResult;
    }

} // End Of Class

public static class InnerSegmentRecencyFactoryExtensions
{
}
