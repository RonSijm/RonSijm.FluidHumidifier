// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InstanceEventWindowFactory(string resourceName = null, Action<Humidifier.EC2.InstanceEventWindow> factoryAction = null) : ResourceFactory<Humidifier.EC2.InstanceEventWindow>(resourceName)
{

    internal List<InnerInstanceEventWindowTimeRangeFactory> TimeRangesFactories { get; set; } = [];

    protected override Humidifier.EC2.InstanceEventWindow Create()
    {
        var instanceEventWindowResult = CreateInstanceEventWindow();
        factoryAction?.Invoke(instanceEventWindowResult);

        return instanceEventWindowResult;
    }

    private Humidifier.EC2.InstanceEventWindow CreateInstanceEventWindow()
    {
        var instanceEventWindowResult = new Humidifier.EC2.InstanceEventWindow
        {
            GivenName = InputResourceName,
        };

        return instanceEventWindowResult;
    }
    public override void CreateChildren(Humidifier.EC2.InstanceEventWindow result)
    {
        base.CreateChildren(result);

        result.TimeRanges = TimeRangesFactories.Any() ? TimeRangesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InstanceEventWindowFactoryExtensions
{
    public static CombinedResult<InstanceEventWindowFactory, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges(this InstanceEventWindowFactory parentFactory, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null)
    {
        var factory = new InnerInstanceEventWindowTimeRangeFactory(subFactoryAction);
        parentFactory.TimeRangesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InstanceEventWindowFactory, T1, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1>(this CombinedResult<InstanceEventWindowFactory, T1> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeRanges(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstanceEventWindowFactory, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1>(this CombinedResult<T1, InstanceEventWindowFactory> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeRanges(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InstanceEventWindowFactory, T1, T2, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2>(this CombinedResult<InstanceEventWindowFactory, T1, T2> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstanceEventWindowFactory, T2, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2>(this CombinedResult<T1, InstanceEventWindowFactory, T2> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InstanceEventWindowFactory, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2>(this CombinedResult<T1, T2, InstanceEventWindowFactory> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InstanceEventWindowFactory, T1, T2, T3, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2, T3>(this CombinedResult<InstanceEventWindowFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstanceEventWindowFactory, T2, T3, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2, T3>(this CombinedResult<T1, InstanceEventWindowFactory, T2, T3> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InstanceEventWindowFactory, T3, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2, T3>(this CombinedResult<T1, T2, InstanceEventWindowFactory, T3> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InstanceEventWindowFactory, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceEventWindowFactory> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InstanceEventWindowFactory, T1, T2, T3, T4, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2, T3, T4>(this CombinedResult<InstanceEventWindowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstanceEventWindowFactory, T2, T3, T4, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2, T3, T4>(this CombinedResult<T1, InstanceEventWindowFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InstanceEventWindowFactory, T3, T4, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceEventWindowFactory, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InstanceEventWindowFactory, T4, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceEventWindowFactory, T4> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InstanceEventWindowFactory, InnerInstanceEventWindowTimeRangeFactory> WithTimeRanges<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceEventWindowFactory> combinedResult, Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeRanges(combinedResult.T5, subFactoryAction).T2);
}
