// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ListenerFactory(string resourceName = null, Action<Humidifier.VpcLattice.Listener> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.Listener>(resourceName)
{

    internal InnerListenerDefaultActionFactory DefaultActionFactory { get; set; }

    protected override Humidifier.VpcLattice.Listener Create()
    {
        var listenerResult = CreateListener();
        factoryAction?.Invoke(listenerResult);

        return listenerResult;
    }

    private Humidifier.VpcLattice.Listener CreateListener()
    {
        var listenerResult = new Humidifier.VpcLattice.Listener
        {
            GivenName = InputResourceName,
        };

        return listenerResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.Listener result)
    {
        base.CreateChildren(result);

        result.DefaultAction ??= DefaultActionFactory?.Build();
    }

} // End Of Class

public static class ListenerFactoryExtensions
{
    public static CombinedResult<ListenerFactory, InnerListenerDefaultActionFactory> WithDefaultAction(this ListenerFactory parentFactory, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null)
    {
        parentFactory.DefaultActionFactory = new InnerListenerDefaultActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultActionFactory);
    }

    public static CombinedResult<ListenerFactory, T1, InnerListenerDefaultActionFactory> WithDefaultAction<T1>(this CombinedResult<ListenerFactory, T1> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerFactory, InnerListenerDefaultActionFactory> WithDefaultAction<T1>(this CombinedResult<T1, ListenerFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ListenerFactory, T1, T2, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2>(this CombinedResult<ListenerFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerFactory, T2, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2>(this CombinedResult<T1, ListenerFactory, T2> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerFactory, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2>(this CombinedResult<T1, T2, ListenerFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ListenerFactory, T1, T2, T3, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<ListenerFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerFactory, T2, T3, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<T1, ListenerFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerFactory, T3, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<T1, T2, ListenerFactory, T3> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ListenerFactory, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, ListenerFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ListenerFactory, T1, T2, T3, T4, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<ListenerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerFactory, T2, T3, T4, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, ListenerFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerFactory, T3, T4, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, ListenerFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ListenerFactory, T4, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ListenerFactory, T4> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ListenerFactory, InnerListenerDefaultActionFactory> WithDefaultAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ListenerFactory> combinedResult, Action<Humidifier.VpcLattice.ListenerTypes.DefaultAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultAction(combinedResult.T5, subFactoryAction));
}
