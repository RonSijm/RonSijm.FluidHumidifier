// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetGeoLocationFactory(Action<Humidifier.Route53.RecordSetTypes.GeoLocation> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetTypes.GeoLocation>
{

    protected override Humidifier.Route53.RecordSetTypes.GeoLocation Create()
    {
        var geoLocationResult = CreateGeoLocation();
        factoryAction?.Invoke(geoLocationResult);

        return geoLocationResult;
    }

    private Humidifier.Route53.RecordSetTypes.GeoLocation CreateGeoLocation()
    {
        var geoLocationResult = new Humidifier.Route53.RecordSetTypes.GeoLocation();

        return geoLocationResult;
    }

} // End Of Class

public static class InnerRecordSetGeoLocationFactoryExtensions
{
}
