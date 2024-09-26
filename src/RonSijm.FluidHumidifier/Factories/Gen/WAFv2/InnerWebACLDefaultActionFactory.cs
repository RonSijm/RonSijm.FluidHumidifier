// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLDefaultActionFactory(Action<Humidifier.WAFv2.WebACLTypes.DefaultAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.DefaultAction>
{

    internal InnerWebACLBlockActionFactory BlockFactory { get; set; }

    internal InnerWebACLAllowActionFactory AllowFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.DefaultAction Create()
    {
        var defaultActionResult = CreateDefaultAction();
        factoryAction?.Invoke(defaultActionResult);

        return defaultActionResult;
    }

    private Humidifier.WAFv2.WebACLTypes.DefaultAction CreateDefaultAction()
    {
        var defaultActionResult = new Humidifier.WAFv2.WebACLTypes.DefaultAction();

        return defaultActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.DefaultAction result)
    {
        base.CreateChildren(result);

        result.Block ??= BlockFactory?.Build();
        result.Allow ??= AllowFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLDefaultActionFactoryExtensions
{
    public static CombinedResult<InnerWebACLDefaultActionFactory, InnerWebACLBlockActionFactory> WithBlock(this InnerWebACLDefaultActionFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null)
    {
        parentFactory.BlockFactory = new InnerWebACLBlockActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BlockFactory);
    }

    public static CombinedResult<InnerWebACLDefaultActionFactory, InnerWebACLAllowActionFactory> WithAllow(this InnerWebACLDefaultActionFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null)
    {
        parentFactory.AllowFactory = new InnerWebACLAllowActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AllowFactory);
    }

    public static CombinedResult<InnerWebACLDefaultActionFactory, T1, InnerWebACLBlockActionFactory> WithBlock<T1>(this CombinedResult<InnerWebACLDefaultActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithBlock(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLDefaultActionFactory, InnerWebACLBlockActionFactory> WithBlock<T1>(this CombinedResult<T1, InnerWebACLDefaultActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithBlock(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLDefaultActionFactory, T1, T2, InnerWebACLBlockActionFactory> WithBlock<T1, T2>(this CombinedResult<InnerWebACLDefaultActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLDefaultActionFactory, T2, InnerWebACLBlockActionFactory> WithBlock<T1, T2>(this CombinedResult<T1, InnerWebACLDefaultActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLDefaultActionFactory, InnerWebACLBlockActionFactory> WithBlock<T1, T2>(this CombinedResult<T1, T2, InnerWebACLDefaultActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLDefaultActionFactory, T1, T2, T3, InnerWebACLBlockActionFactory> WithBlock<T1, T2, T3>(this CombinedResult<InnerWebACLDefaultActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLDefaultActionFactory, T2, T3, InnerWebACLBlockActionFactory> WithBlock<T1, T2, T3>(this CombinedResult<T1, InnerWebACLDefaultActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLDefaultActionFactory, T3, InnerWebACLBlockActionFactory> WithBlock<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLDefaultActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLDefaultActionFactory, InnerWebACLBlockActionFactory> WithBlock<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLDefaultActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLDefaultActionFactory, T1, T2, T3, T4, InnerWebACLBlockActionFactory> WithBlock<T1, T2, T3, T4>(this CombinedResult<InnerWebACLDefaultActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLDefaultActionFactory, T2, T3, T4, InnerWebACLBlockActionFactory> WithBlock<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLDefaultActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLDefaultActionFactory, T3, T4, InnerWebACLBlockActionFactory> WithBlock<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLDefaultActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLDefaultActionFactory, T4, InnerWebACLBlockActionFactory> WithBlock<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLDefaultActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLDefaultActionFactory, InnerWebACLBlockActionFactory> WithBlock<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLDefaultActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.BlockAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlock(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerWebACLDefaultActionFactory, T1, InnerWebACLAllowActionFactory> WithAllow<T1>(this CombinedResult<InnerWebACLDefaultActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAllow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLDefaultActionFactory, InnerWebACLAllowActionFactory> WithAllow<T1>(this CombinedResult<T1, InnerWebACLDefaultActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAllow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLDefaultActionFactory, T1, T2, InnerWebACLAllowActionFactory> WithAllow<T1, T2>(this CombinedResult<InnerWebACLDefaultActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLDefaultActionFactory, T2, InnerWebACLAllowActionFactory> WithAllow<T1, T2>(this CombinedResult<T1, InnerWebACLDefaultActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLDefaultActionFactory, InnerWebACLAllowActionFactory> WithAllow<T1, T2>(this CombinedResult<T1, T2, InnerWebACLDefaultActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLDefaultActionFactory, T1, T2, T3, InnerWebACLAllowActionFactory> WithAllow<T1, T2, T3>(this CombinedResult<InnerWebACLDefaultActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLDefaultActionFactory, T2, T3, InnerWebACLAllowActionFactory> WithAllow<T1, T2, T3>(this CombinedResult<T1, InnerWebACLDefaultActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLDefaultActionFactory, T3, InnerWebACLAllowActionFactory> WithAllow<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLDefaultActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLDefaultActionFactory, InnerWebACLAllowActionFactory> WithAllow<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLDefaultActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLDefaultActionFactory, T1, T2, T3, T4, InnerWebACLAllowActionFactory> WithAllow<T1, T2, T3, T4>(this CombinedResult<InnerWebACLDefaultActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLDefaultActionFactory, T2, T3, T4, InnerWebACLAllowActionFactory> WithAllow<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLDefaultActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLDefaultActionFactory, T3, T4, InnerWebACLAllowActionFactory> WithAllow<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLDefaultActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLDefaultActionFactory, T4, InnerWebACLAllowActionFactory> WithAllow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLDefaultActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLDefaultActionFactory, InnerWebACLAllowActionFactory> WithAllow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLDefaultActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.AllowAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAllow(combinedResult.T5, subFactoryAction));
}
