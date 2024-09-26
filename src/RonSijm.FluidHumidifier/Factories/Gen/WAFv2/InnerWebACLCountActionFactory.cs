// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLCountActionFactory(Action<Humidifier.WAFv2.WebACLTypes.CountAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.CountAction>
{

    internal InnerWebACLCustomRequestHandlingFactory CustomRequestHandlingFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.CountAction Create()
    {
        var countActionResult = CreateCountAction();
        factoryAction?.Invoke(countActionResult);

        return countActionResult;
    }

    private Humidifier.WAFv2.WebACLTypes.CountAction CreateCountAction()
    {
        var countActionResult = new Humidifier.WAFv2.WebACLTypes.CountAction();

        return countActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.CountAction result)
    {
        base.CreateChildren(result);

        result.CustomRequestHandling ??= CustomRequestHandlingFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLCountActionFactoryExtensions
{
    public static CombinedResult<InnerWebACLCountActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling(this InnerWebACLCountActionFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null)
    {
        parentFactory.CustomRequestHandlingFactory = new InnerWebACLCustomRequestHandlingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomRequestHandlingFactory);
    }

    public static CombinedResult<InnerWebACLCountActionFactory, T1, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<InnerWebACLCountActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCountActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<T1, InnerWebACLCountActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLCountActionFactory, T1, T2, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<InnerWebACLCountActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCountActionFactory, T2, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, InnerWebACLCountActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCountActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, T2, InnerWebACLCountActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLCountActionFactory, T1, T2, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<InnerWebACLCountActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCountActionFactory, T2, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, InnerWebACLCountActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCountActionFactory, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLCountActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLCountActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLCountActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLCountActionFactory, T1, T2, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<InnerWebACLCountActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCountActionFactory, T2, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLCountActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCountActionFactory, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLCountActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLCountActionFactory, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLCountActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLCountActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLCountActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T5, subFactoryAction));
}
