// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerSegmentGPSPointFactory(Action<Humidifier.Pinpoint.SegmentTypes.GPSPoint> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.SegmentTypes.GPSPoint>
{

    internal InnerSegmentCoordinatesFactory CoordinatesFactory { get; set; }

    protected override Humidifier.Pinpoint.SegmentTypes.GPSPoint Create()
    {
        var gPSPointResult = CreateGPSPoint();
        factoryAction?.Invoke(gPSPointResult);

        return gPSPointResult;
    }

    private Humidifier.Pinpoint.SegmentTypes.GPSPoint CreateGPSPoint()
    {
        var gPSPointResult = new Humidifier.Pinpoint.SegmentTypes.GPSPoint();

        return gPSPointResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.SegmentTypes.GPSPoint result)
    {
        base.CreateChildren(result);

        result.Coordinates ??= CoordinatesFactory?.Build();
    }

} // End Of Class

public static class InnerSegmentGPSPointFactoryExtensions
{
    public static CombinedResult<InnerSegmentGPSPointFactory, InnerSegmentCoordinatesFactory> WithCoordinates(this InnerSegmentGPSPointFactory parentFactory, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null)
    {
        parentFactory.CoordinatesFactory = new InnerSegmentCoordinatesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CoordinatesFactory);
    }

    public static CombinedResult<InnerSegmentGPSPointFactory, T1, InnerSegmentCoordinatesFactory> WithCoordinates<T1>(this CombinedResult<InnerSegmentGPSPointFactory, T1> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentGPSPointFactory, InnerSegmentCoordinatesFactory> WithCoordinates<T1>(this CombinedResult<T1, InnerSegmentGPSPointFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSegmentGPSPointFactory, T1, T2, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2>(this CombinedResult<InnerSegmentGPSPointFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentGPSPointFactory, T2, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2>(this CombinedResult<T1, InnerSegmentGPSPointFactory, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentGPSPointFactory, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2>(this CombinedResult<T1, T2, InnerSegmentGPSPointFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSegmentGPSPointFactory, T1, T2, T3, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<InnerSegmentGPSPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentGPSPointFactory, T2, T3, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<T1, InnerSegmentGPSPointFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentGPSPointFactory, T3, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<T1, T2, InnerSegmentGPSPointFactory, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentGPSPointFactory, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSegmentGPSPointFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSegmentGPSPointFactory, T1, T2, T3, T4, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<InnerSegmentGPSPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentGPSPointFactory, T2, T3, T4, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, InnerSegmentGPSPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentGPSPointFactory, T3, T4, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSegmentGPSPointFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentGPSPointFactory, T4, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSegmentGPSPointFactory, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSegmentGPSPointFactory, InnerSegmentCoordinatesFactory> WithCoordinates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSegmentGPSPointFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Coordinates> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCoordinates(combinedResult.T5, subFactoryAction));
}
