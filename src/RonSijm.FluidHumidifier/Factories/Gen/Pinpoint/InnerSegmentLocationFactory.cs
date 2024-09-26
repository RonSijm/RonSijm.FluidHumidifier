// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerSegmentLocationFactory(Action<Humidifier.Pinpoint.SegmentTypes.Location> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.SegmentTypes.Location>
{

    internal InnerSegmentGPSPointFactory GPSPointFactory { get; set; }

    internal InnerSegmentSetDimensionFactory CountryFactory { get; set; }

    protected override Humidifier.Pinpoint.SegmentTypes.Location Create()
    {
        var locationResult = CreateLocation();
        factoryAction?.Invoke(locationResult);

        return locationResult;
    }

    private Humidifier.Pinpoint.SegmentTypes.Location CreateLocation()
    {
        var locationResult = new Humidifier.Pinpoint.SegmentTypes.Location();

        return locationResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.SegmentTypes.Location result)
    {
        base.CreateChildren(result);

        result.GPSPoint ??= GPSPointFactory?.Build();
        result.Country ??= CountryFactory?.Build();
    }

} // End Of Class

public static class InnerSegmentLocationFactoryExtensions
{
    public static CombinedResult<InnerSegmentLocationFactory, InnerSegmentGPSPointFactory> WithGPSPoint(this InnerSegmentLocationFactory parentFactory, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null)
    {
        parentFactory.GPSPointFactory = new InnerSegmentGPSPointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GPSPointFactory);
    }

    public static CombinedResult<InnerSegmentLocationFactory, InnerSegmentSetDimensionFactory> WithCountry(this InnerSegmentLocationFactory parentFactory, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null)
    {
        parentFactory.CountryFactory = new InnerSegmentSetDimensionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CountryFactory);
    }

    public static CombinedResult<InnerSegmentLocationFactory, T1, InnerSegmentGPSPointFactory> WithGPSPoint<T1>(this CombinedResult<InnerSegmentLocationFactory, T1> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithGPSPoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentLocationFactory, InnerSegmentGPSPointFactory> WithGPSPoint<T1>(this CombinedResult<T1, InnerSegmentLocationFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithGPSPoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSegmentLocationFactory, T1, T2, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2>(this CombinedResult<InnerSegmentLocationFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentLocationFactory, T2, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2>(this CombinedResult<T1, InnerSegmentLocationFactory, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentLocationFactory, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2>(this CombinedResult<T1, T2, InnerSegmentLocationFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSegmentLocationFactory, T1, T2, T3, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2, T3>(this CombinedResult<InnerSegmentLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentLocationFactory, T2, T3, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2, T3>(this CombinedResult<T1, InnerSegmentLocationFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentLocationFactory, T3, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2, T3>(this CombinedResult<T1, T2, InnerSegmentLocationFactory, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentLocationFactory, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSegmentLocationFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSegmentLocationFactory, T1, T2, T3, T4, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2, T3, T4>(this CombinedResult<InnerSegmentLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentLocationFactory, T2, T3, T4, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2, T3, T4>(this CombinedResult<T1, InnerSegmentLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentLocationFactory, T3, T4, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSegmentLocationFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentLocationFactory, T4, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSegmentLocationFactory, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSegmentLocationFactory, InnerSegmentGPSPointFactory> WithGPSPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSegmentLocationFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGPSPoint(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerSegmentLocationFactory, T1, InnerSegmentSetDimensionFactory> WithCountry<T1>(this CombinedResult<InnerSegmentLocationFactory, T1> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, WithCountry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentLocationFactory, InnerSegmentSetDimensionFactory> WithCountry<T1>(this CombinedResult<T1, InnerSegmentLocationFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, WithCountry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSegmentLocationFactory, T1, T2, InnerSegmentSetDimensionFactory> WithCountry<T1, T2>(this CombinedResult<InnerSegmentLocationFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentLocationFactory, T2, InnerSegmentSetDimensionFactory> WithCountry<T1, T2>(this CombinedResult<T1, InnerSegmentLocationFactory, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentLocationFactory, InnerSegmentSetDimensionFactory> WithCountry<T1, T2>(this CombinedResult<T1, T2, InnerSegmentLocationFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSegmentLocationFactory, T1, T2, T3, InnerSegmentSetDimensionFactory> WithCountry<T1, T2, T3>(this CombinedResult<InnerSegmentLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentLocationFactory, T2, T3, InnerSegmentSetDimensionFactory> WithCountry<T1, T2, T3>(this CombinedResult<T1, InnerSegmentLocationFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentLocationFactory, T3, InnerSegmentSetDimensionFactory> WithCountry<T1, T2, T3>(this CombinedResult<T1, T2, InnerSegmentLocationFactory, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentLocationFactory, InnerSegmentSetDimensionFactory> WithCountry<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSegmentLocationFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSegmentLocationFactory, T1, T2, T3, T4, InnerSegmentSetDimensionFactory> WithCountry<T1, T2, T3, T4>(this CombinedResult<InnerSegmentLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentLocationFactory, T2, T3, T4, InnerSegmentSetDimensionFactory> WithCountry<T1, T2, T3, T4>(this CombinedResult<T1, InnerSegmentLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentLocationFactory, T3, T4, InnerSegmentSetDimensionFactory> WithCountry<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSegmentLocationFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentLocationFactory, T4, InnerSegmentSetDimensionFactory> WithCountry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSegmentLocationFactory, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSegmentLocationFactory, InnerSegmentSetDimensionFactory> WithCountry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSegmentLocationFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SetDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCountry(combinedResult.T5, subFactoryAction));
}
