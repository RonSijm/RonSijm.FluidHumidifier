// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetAcceleratorCapabilitiesFactory(Action<Humidifier.Deadline.FleetTypes.AcceleratorCapabilities> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.AcceleratorCapabilities>
{

    internal InnerFleetAcceleratorCountRangeFactory CountFactory { get; set; }

    protected override Humidifier.Deadline.FleetTypes.AcceleratorCapabilities Create()
    {
        var acceleratorCapabilitiesResult = CreateAcceleratorCapabilities();
        factoryAction?.Invoke(acceleratorCapabilitiesResult);

        return acceleratorCapabilitiesResult;
    }

    private Humidifier.Deadline.FleetTypes.AcceleratorCapabilities CreateAcceleratorCapabilities()
    {
        var acceleratorCapabilitiesResult = new Humidifier.Deadline.FleetTypes.AcceleratorCapabilities();

        return acceleratorCapabilitiesResult;
    }
    public override void CreateChildren(Humidifier.Deadline.FleetTypes.AcceleratorCapabilities result)
    {
        base.CreateChildren(result);

        result.Count ??= CountFactory?.Build();
    }

} // End Of Class

public static class InnerFleetAcceleratorCapabilitiesFactoryExtensions
{
    public static CombinedResult<InnerFleetAcceleratorCapabilitiesFactory, InnerFleetAcceleratorCountRangeFactory> WithCount(this InnerFleetAcceleratorCapabilitiesFactory parentFactory, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null)
    {
        parentFactory.CountFactory = new InnerFleetAcceleratorCountRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CountFactory);
    }

    public static CombinedResult<InnerFleetAcceleratorCapabilitiesFactory, T1, InnerFleetAcceleratorCountRangeFactory> WithCount<T1>(this CombinedResult<InnerFleetAcceleratorCapabilitiesFactory, T1> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetAcceleratorCapabilitiesFactory, InnerFleetAcceleratorCountRangeFactory> WithCount<T1>(this CombinedResult<T1, InnerFleetAcceleratorCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFleetAcceleratorCapabilitiesFactory, T1, T2, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2>(this CombinedResult<InnerFleetAcceleratorCapabilitiesFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetAcceleratorCapabilitiesFactory, T2, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2>(this CombinedResult<T1, InnerFleetAcceleratorCapabilitiesFactory, T2> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetAcceleratorCapabilitiesFactory, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2>(this CombinedResult<T1, T2, InnerFleetAcceleratorCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFleetAcceleratorCapabilitiesFactory, T1, T2, T3, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2, T3>(this CombinedResult<InnerFleetAcceleratorCapabilitiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetAcceleratorCapabilitiesFactory, T2, T3, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2, T3>(this CombinedResult<T1, InnerFleetAcceleratorCapabilitiesFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetAcceleratorCapabilitiesFactory, T3, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2, T3>(this CombinedResult<T1, T2, InnerFleetAcceleratorCapabilitiesFactory, T3> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetAcceleratorCapabilitiesFactory, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFleetAcceleratorCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFleetAcceleratorCapabilitiesFactory, T1, T2, T3, T4, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2, T3, T4>(this CombinedResult<InnerFleetAcceleratorCapabilitiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFleetAcceleratorCapabilitiesFactory, T2, T3, T4, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2, T3, T4>(this CombinedResult<T1, InnerFleetAcceleratorCapabilitiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFleetAcceleratorCapabilitiesFactory, T3, T4, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFleetAcceleratorCapabilitiesFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFleetAcceleratorCapabilitiesFactory, T4, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFleetAcceleratorCapabilitiesFactory, T4> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFleetAcceleratorCapabilitiesFactory, InnerFleetAcceleratorCountRangeFactory> WithCount<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFleetAcceleratorCapabilitiesFactory> combinedResult, Action<Humidifier.Deadline.FleetTypes.AcceleratorCountRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCount(combinedResult.T5, subFactoryAction));
}
