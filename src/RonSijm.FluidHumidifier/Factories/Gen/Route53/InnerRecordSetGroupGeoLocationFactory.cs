// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetGroupGeoLocationFactory(Action<Humidifier.Route53.RecordSetGroupTypes.GeoLocation> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetGroupTypes.GeoLocation>
{

    protected override Humidifier.Route53.RecordSetGroupTypes.GeoLocation Create()
    {
        var geoLocationResult = CreateGeoLocation();
        factoryAction?.Invoke(geoLocationResult);

        return geoLocationResult;
    }

    private Humidifier.Route53.RecordSetGroupTypes.GeoLocation CreateGeoLocation()
    {
        var geoLocationResult = new Humidifier.Route53.RecordSetGroupTypes.GeoLocation();

        return geoLocationResult;
    }

} // End Of Class

public static class InnerRecordSetGroupGeoLocationFactoryExtensions
{
}
