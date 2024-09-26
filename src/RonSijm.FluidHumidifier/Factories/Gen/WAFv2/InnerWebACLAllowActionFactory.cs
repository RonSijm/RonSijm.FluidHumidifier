// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLAllowActionFactory(Action<Humidifier.WAFv2.WebACLTypes.AllowAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.AllowAction>
{

    internal InnerWebACLCustomRequestHandlingFactory CustomRequestHandlingFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.AllowAction Create()
    {
        var allowActionResult = CreateAllowAction();
        factoryAction?.Invoke(allowActionResult);

        return allowActionResult;
    }

    private Humidifier.WAFv2.WebACLTypes.AllowAction CreateAllowAction()
    {
        var allowActionResult = new Humidifier.WAFv2.WebACLTypes.AllowAction();

        return allowActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.AllowAction result)
    {
        base.CreateChildren(result);

        result.CustomRequestHandling ??= CustomRequestHandlingFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLAllowActionFactoryExtensions
{
    public static CombinedResult<InnerWebACLAllowActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling(this InnerWebACLAllowActionFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null)
    {
        parentFactory.CustomRequestHandlingFactory = new InnerWebACLCustomRequestHandlingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomRequestHandlingFactory);
    }

    public static CombinedResult<InnerWebACLAllowActionFactory, T1, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<InnerWebACLAllowActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLAllowActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<T1, InnerWebACLAllowActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLAllowActionFactory, T1, T2, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<InnerWebACLAllowActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLAllowActionFactory, T2, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, InnerWebACLAllowActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLAllowActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, T2, InnerWebACLAllowActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLAllowActionFactory, T1, T2, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<InnerWebACLAllowActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLAllowActionFactory, T2, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, InnerWebACLAllowActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLAllowActionFactory, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLAllowActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLAllowActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLAllowActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLAllowActionFactory, T1, T2, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<InnerWebACLAllowActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLAllowActionFactory, T2, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLAllowActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLAllowActionFactory, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLAllowActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLAllowActionFactory, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLAllowActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLAllowActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLAllowActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T5, subFactoryAction));
}
