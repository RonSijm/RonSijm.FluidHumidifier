// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerSegmentCoordinatesFactory(Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.SegmentTypes.Coordinates>
{

    protected override Humidifier.Pinpoint.SegmentTypes.Coordinates Create()
    {
        var coordinatesResult = CreateCoordinates();
        factoryAction?.Invoke(coordinatesResult);

        return coordinatesResult;
    }

    private Humidifier.Pinpoint.SegmentTypes.Coordinates CreateCoordinates()
    {
        var coordinatesResult = new Humidifier.Pinpoint.SegmentTypes.Coordinates();

        return coordinatesResult;
    }

} // End Of Class

public static class InnerSegmentCoordinatesFactoryExtensions
{
}
