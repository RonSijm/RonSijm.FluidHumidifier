// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetGroupGeoProximityLocationFactory(Action<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation>
{

    internal InnerRecordSetGroupCoordinatesFactory CoordinatesFactory { get; set; }

    protected override Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation Create()
    {
        var geoProximityLocationResult = CreateGeoProximityLocation();
        factoryAction?.Invoke(geoProximityLocationResult);

        return geoProximityLocationResult;
    }

    private Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation CreateGeoProximityLocation()
    {
        var geoProximityLocationResult = new Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation();

        return geoProximityLocationResult;
    }
    public override void CreateChildren(Humidifier.Route53.RecordSetGroupTypes.GeoProximityLocation result)
    {
        base.CreateChildren(result);

        result.Coordinates ??= CoordinatesFactory?.Build();
    }

} // End Of Class

public static class InnerRecordSetGroupGeoProximityLocationFactoryExtensions
{
    public static CombinedResult<InnerRecordSetGroupGeoProximityLocationFactory, InnerRecordSetGroupCoordinatesFactory> WithCoordinates(this InnerRecordSetGroupGeoProximityLocationFactory parentFactory, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null)
    {
        parentFactory.CoordinatesFactory = new InnerRecordSetGroupCoordinatesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CoordinatesFactory);
    }

    public static CombinedResult<InnerRecordSetGroupGeoProximityLocationFactory, T1, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1>(this CombinedResult<InnerRecordSetGroupGeoProximityLocationFactory, T1> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupGeoProximityLocationFactory, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1>(this CombinedResult<T1, InnerRecordSetGroupGeoProximityLocationFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupGeoProximityLocationFactory, T1, T2, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2>(this CombinedResult<InnerRecordSetGroupGeoProximityLocationFactory, T1, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupGeoProximityLocationFactory, T2, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2>(this CombinedResult<T1, InnerRecordSetGroupGeoProximityLocationFactory, T2> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupGeoProximityLocationFactory, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2>(this CombinedResult<T1, T2, InnerRecordSetGroupGeoProximityLocationFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupGeoProximityLocationFactory, T1, T2, T3, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<InnerRecordSetGroupGeoProximityLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupGeoProximityLocationFactory, T2, T3, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<T1, InnerRecordSetGroupGeoProximityLocationFactory, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupGeoProximityLocationFactory, T3, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecordSetGroupGeoProximityLocationFactory, T3> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGroupGeoProximityLocationFactory, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecordSetGroupGeoProximityLocationFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecordSetGroupGeoProximityLocationFactory, T1, T2, T3, T4, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<InnerRecordSetGroupGeoProximityLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGroupGeoProximityLocationFactory, T2, T3, T4, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecordSetGroupGeoProximityLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGroupGeoProximityLocationFactory, T3, T4, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecordSetGroupGeoProximityLocationFactory, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGroupGeoProximityLocationFactory, T4, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecordSetGroupGeoProximityLocationFactory, T4> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecordSetGroupGeoProximityLocationFactory, InnerRecordSetGroupCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecordSetGroupGeoProximityLocationFactory> combinedResult, Action<Humidifier.Route53.RecordSetGroupTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T5, subFactoryAction));
}
