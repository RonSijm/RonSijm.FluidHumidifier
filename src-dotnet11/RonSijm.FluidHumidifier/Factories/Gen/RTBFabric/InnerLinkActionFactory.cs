// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkActionFactory(Action<Humidifier.RTBFabric.LinkTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.Action>
{

    internal InnerLinkNoBidActionFactory NoBidFactory { get; set; }

    internal InnerLinkHeaderTagActionFactory HeaderTagFactory { get; set; }

    protected override Humidifier.RTBFabric.LinkTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.RTBFabric.LinkTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.RTBFabric.LinkTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.LinkTypes.Action result)
    {
        base.CreateChildren(result);

        result.NoBid ??= NoBidFactory?.Build();
        result.HeaderTag ??= HeaderTagFactory?.Build();
    }

} // End Of Class

public static class InnerLinkActionFactoryExtensions
{
    public static CombinedResult<InnerLinkActionFactory, InnerLinkNoBidActionFactory> WithNoBid(this InnerLinkActionFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null)
    {
        parentFactory.NoBidFactory = new InnerLinkNoBidActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NoBidFactory);
    }

    public static CombinedResult<InnerLinkActionFactory, InnerLinkHeaderTagActionFactory> WithHeaderTag(this InnerLinkActionFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null)
    {
        parentFactory.HeaderTagFactory = new InnerLinkHeaderTagActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HeaderTagFactory);
    }

    public static CombinedResult<InnerLinkActionFactory, T1, InnerLinkNoBidActionFactory> WithNoBid<T1>(this CombinedResult<InnerLinkActionFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithNoBid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkActionFactory, InnerLinkNoBidActionFactory> WithNoBid<T1>(this CombinedResult<T1, InnerLinkActionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithNoBid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLinkActionFactory, T1, T2, InnerLinkNoBidActionFactory> WithNoBid<T1, T2>(this CombinedResult<InnerLinkActionFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkActionFactory, T2, InnerLinkNoBidActionFactory> WithNoBid<T1, T2>(this CombinedResult<T1, InnerLinkActionFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkActionFactory, InnerLinkNoBidActionFactory> WithNoBid<T1, T2>(this CombinedResult<T1, T2, InnerLinkActionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLinkActionFactory, T1, T2, T3, InnerLinkNoBidActionFactory> WithNoBid<T1, T2, T3>(this CombinedResult<InnerLinkActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkActionFactory, T2, T3, InnerLinkNoBidActionFactory> WithNoBid<T1, T2, T3>(this CombinedResult<T1, InnerLinkActionFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkActionFactory, T3, InnerLinkNoBidActionFactory> WithNoBid<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkActionFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkActionFactory, InnerLinkNoBidActionFactory> WithNoBid<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkActionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLinkActionFactory, T1, T2, T3, T4, InnerLinkNoBidActionFactory> WithNoBid<T1, T2, T3, T4>(this CombinedResult<InnerLinkActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkActionFactory, T2, T3, T4, InnerLinkNoBidActionFactory> WithNoBid<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkActionFactory, T3, T4, InnerLinkNoBidActionFactory> WithNoBid<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkActionFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkActionFactory, T4, InnerLinkNoBidActionFactory> WithNoBid<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkActionFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLinkActionFactory, InnerLinkNoBidActionFactory> WithNoBid<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkActionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNoBid(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerLinkActionFactory, T1, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1>(this CombinedResult<InnerLinkActionFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithHeaderTag(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkActionFactory, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1>(this CombinedResult<T1, InnerLinkActionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithHeaderTag(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLinkActionFactory, T1, T2, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2>(this CombinedResult<InnerLinkActionFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkActionFactory, T2, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2>(this CombinedResult<T1, InnerLinkActionFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkActionFactory, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2>(this CombinedResult<T1, T2, InnerLinkActionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLinkActionFactory, T1, T2, T3, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2, T3>(this CombinedResult<InnerLinkActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkActionFactory, T2, T3, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2, T3>(this CombinedResult<T1, InnerLinkActionFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkActionFactory, T3, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkActionFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkActionFactory, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkActionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLinkActionFactory, T1, T2, T3, T4, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2, T3, T4>(this CombinedResult<InnerLinkActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkActionFactory, T2, T3, T4, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkActionFactory, T3, T4, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkActionFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkActionFactory, T4, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkActionFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLinkActionFactory, InnerLinkHeaderTagActionFactory> WithHeaderTag<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkActionFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHeaderTag(combinedResult.T5, subFactoryAction).T2);
}
