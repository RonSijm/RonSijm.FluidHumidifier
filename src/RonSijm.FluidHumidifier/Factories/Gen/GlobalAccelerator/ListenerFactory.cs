// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GlobalAccelerator;

public class ListenerFactory(string resourceName = null, Action<Humidifier.GlobalAccelerator.Listener> factoryAction = null) : ResourceFactory<Humidifier.GlobalAccelerator.Listener>(resourceName)
{

    internal List<InnerListenerPortRangeFactory> PortRangesFactories { get; set; } = [];

    protected override Humidifier.GlobalAccelerator.Listener Create()
    {
        var listenerResult = CreateListener();
        factoryAction?.Invoke(listenerResult);

        return listenerResult;
    }

    private Humidifier.GlobalAccelerator.Listener CreateListener()
    {
        var listenerResult = new Humidifier.GlobalAccelerator.Listener
        {
            GivenName = InputResourceName,
        };

        return listenerResult;
    }
    public override void CreateChildren(Humidifier.GlobalAccelerator.Listener result)
    {
        base.CreateChildren(result);

        result.PortRanges = PortRangesFactories.Any() ? PortRangesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ListenerFactoryExtensions
{
    public static CombinedResult<ListenerFactory, InnerListenerPortRangeFactory> WithPortRanges(this ListenerFactory parentFactory, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null)
    {
        var factory = new InnerListenerPortRangeFactory(subFactoryAction);
        parentFactory.PortRangesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ListenerFactory, T1, InnerListenerPortRangeFactory> WithPortRanges<T1>(this CombinedResult<ListenerFactory, T1> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortRanges(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerFactory, InnerListenerPortRangeFactory> WithPortRanges<T1>(this CombinedResult<T1, ListenerFactory> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortRanges(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ListenerFactory, T1, T2, InnerListenerPortRangeFactory> WithPortRanges<T1, T2>(this CombinedResult<ListenerFactory, T1, T2> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerFactory, T2, InnerListenerPortRangeFactory> WithPortRanges<T1, T2>(this CombinedResult<T1, ListenerFactory, T2> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerFactory, InnerListenerPortRangeFactory> WithPortRanges<T1, T2>(this CombinedResult<T1, T2, ListenerFactory> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ListenerFactory, T1, T2, T3, InnerListenerPortRangeFactory> WithPortRanges<T1, T2, T3>(this CombinedResult<ListenerFactory, T1, T2, T3> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerFactory, T2, T3, InnerListenerPortRangeFactory> WithPortRanges<T1, T2, T3>(this CombinedResult<T1, ListenerFactory, T2, T3> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerFactory, T3, InnerListenerPortRangeFactory> WithPortRanges<T1, T2, T3>(this CombinedResult<T1, T2, ListenerFactory, T3> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ListenerFactory, InnerListenerPortRangeFactory> WithPortRanges<T1, T2, T3>(this CombinedResult<T1, T2, T3, ListenerFactory> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ListenerFactory, T1, T2, T3, T4, InnerListenerPortRangeFactory> WithPortRanges<T1, T2, T3, T4>(this CombinedResult<ListenerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerFactory, T2, T3, T4, InnerListenerPortRangeFactory> WithPortRanges<T1, T2, T3, T4>(this CombinedResult<T1, ListenerFactory, T2, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerFactory, T3, T4, InnerListenerPortRangeFactory> WithPortRanges<T1, T2, T3, T4>(this CombinedResult<T1, T2, ListenerFactory, T3, T4> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ListenerFactory, T4, InnerListenerPortRangeFactory> WithPortRanges<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ListenerFactory, T4> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ListenerFactory, InnerListenerPortRangeFactory> WithPortRanges<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ListenerFactory> combinedResult, Action<Humidifier.GlobalAccelerator.ListenerTypes.PortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortRanges(combinedResult.T5, subFactoryAction));
}
