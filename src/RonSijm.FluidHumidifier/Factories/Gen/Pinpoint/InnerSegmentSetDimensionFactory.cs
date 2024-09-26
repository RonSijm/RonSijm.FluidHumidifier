// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerSegmentSetDimensionFactory(Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.SegmentTypes.SetDimension>
{

    protected override Humidifier.Pinpoint.SegmentTypes.SetDimension Create()
    {
        var setDimensionResult = CreateSetDimension();
        factoryAction?.Invoke(setDimensionResult);

        return setDimensionResult;
    }

    private Humidifier.Pinpoint.SegmentTypes.SetDimension CreateSetDimension()
    {
        var setDimensionResult = new Humidifier.Pinpoint.SegmentTypes.SetDimension();

        return setDimensionResult;
    }

} // End Of Class

public static class InnerSegmentSetDimensionFactoryExtensions
{
}
