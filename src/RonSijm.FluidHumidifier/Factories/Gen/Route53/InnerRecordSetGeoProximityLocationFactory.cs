// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetGeoProximityLocationFactory(Action<Humidifier.Route53.RecordSetTypes.GeoProximityLocation> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetTypes.GeoProximityLocation>
{

    internal InnerRecordSetCoordinatesFactory CoordinatesFactory { get; set; }

    protected override Humidifier.Route53.RecordSetTypes.GeoProximityLocation Create()
    {
        var geoProximityLocationResult = CreateGeoProximityLocation();
        factoryAction?.Invoke(geoProximityLocationResult);

        return geoProximityLocationResult;
    }

    private Humidifier.Route53.RecordSetTypes.GeoProximityLocation CreateGeoProximityLocation()
    {
        var geoProximityLocationResult = new Humidifier.Route53.RecordSetTypes.GeoProximityLocation();

        return geoProximityLocationResult;
    }
    public override void CreateChildren(Humidifier.Route53.RecordSetTypes.GeoProximityLocation result)
    {
        base.CreateChildren(result);

        result.Coordinates ??= CoordinatesFactory?.Build();
    }

} // End Of Class

public static class InnerRecordSetGeoProximityLocationFactoryExtensions
{
    public static CombinedResult<InnerRecordSetGeoProximityLocationFactory, InnerRecordSetCoordinatesFactory> WithCoordinates(this InnerRecordSetGeoProximityLocationFactory parentFactory, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null)
    {
        parentFactory.CoordinatesFactory = new InnerRecordSetCoordinatesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CoordinatesFactory);
    }

    public static CombinedResult<InnerRecordSetGeoProximityLocationFactory, T1, InnerRecordSetCoordinatesFactory> WithCoordinates<T1>(this CombinedResult<InnerRecordSetGeoProximityLocationFactory, T1> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGeoProximityLocationFactory, InnerRecordSetCoordinatesFactory> WithCoordinates<T1>(this CombinedResult<T1, InnerRecordSetGeoProximityLocationFactory> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecordSetGeoProximityLocationFactory, T1, T2, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2>(this CombinedResult<InnerRecordSetGeoProximityLocationFactory, T1, T2> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGeoProximityLocationFactory, T2, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2>(this CombinedResult<T1, InnerRecordSetGeoProximityLocationFactory, T2> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGeoProximityLocationFactory, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2>(this CombinedResult<T1, T2, InnerRecordSetGeoProximityLocationFactory> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecordSetGeoProximityLocationFactory, T1, T2, T3, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<InnerRecordSetGeoProximityLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGeoProximityLocationFactory, T2, T3, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<T1, InnerRecordSetGeoProximityLocationFactory, T2, T3> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGeoProximityLocationFactory, T3, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecordSetGeoProximityLocationFactory, T3> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGeoProximityLocationFactory, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecordSetGeoProximityLocationFactory> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecordSetGeoProximityLocationFactory, T1, T2, T3, T4, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<InnerRecordSetGeoProximityLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecordSetGeoProximityLocationFactory, T2, T3, T4, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecordSetGeoProximityLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecordSetGeoProximityLocationFactory, T3, T4, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecordSetGeoProximityLocationFactory, T3, T4> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecordSetGeoProximityLocationFactory, T4, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecordSetGeoProximityLocationFactory, T4> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecordSetGeoProximityLocationFactory, InnerRecordSetCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecordSetGeoProximityLocationFactory> combinedResult, Action<Humidifier.Route53.RecordSetTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T5, subFactoryAction));
}
