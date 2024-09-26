// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetCoordinatesFactory(Action<Humidifier.Route53.RecordSetTypes.Coordinates> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetTypes.Coordinates>
{

    protected override Humidifier.Route53.RecordSetTypes.Coordinates Create()
    {
        var coordinatesResult = CreateCoordinates();
        factoryAction?.Invoke(coordinatesResult);

        return coordinatesResult;
    }

    private Humidifier.Route53.RecordSetTypes.Coordinates CreateCoordinates()
    {
        var coordinatesResult = new Humidifier.Route53.RecordSetTypes.Coordinates();

        return coordinatesResult;
    }

} // End Of Class

public static class InnerRecordSetCoordinatesFactoryExtensions
{
}
