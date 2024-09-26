// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetGroupCoordinatesFactory(Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetGroupTypes.Coordinates>
{

    protected override Humidifier.Route53.RecordSetGroupTypes.Coordinates Create()
    {
        var coordinatesResult = CreateCoordinates();
        factoryAction?.Invoke(coordinatesResult);

        return coordinatesResult;
    }

    private Humidifier.Route53.RecordSetGroupTypes.Coordinates CreateCoordinates()
    {
        var coordinatesResult = new Humidifier.Route53.RecordSetGroupTypes.Coordinates();

        return coordinatesResult;
    }

} // End Of Class

public static class InnerRecordSetGroupCoordinatesFactoryExtensions
{
}
