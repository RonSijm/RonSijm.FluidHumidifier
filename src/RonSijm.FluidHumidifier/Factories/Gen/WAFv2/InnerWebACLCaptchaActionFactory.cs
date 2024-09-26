// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLCaptchaActionFactory(Action<Humidifier.WAFv2.WebACLTypes.CaptchaAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.CaptchaAction>
{

    internal InnerWebACLCustomRequestHandlingFactory CustomRequestHandlingFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.CaptchaAction Create()
    {
        var captchaActionResult = CreateCaptchaAction();
        factoryAction?.Invoke(captchaActionResult);

        return captchaActionResult;
    }

    private Humidifier.WAFv2.WebACLTypes.CaptchaAction CreateCaptchaAction()
    {
        var captchaActionResult = new Humidifier.WAFv2.WebACLTypes.CaptchaAction();

        return captchaActionResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.CaptchaAction result)
    {
        base.CreateChildren(result);

        result.CustomRequestHandling ??= CustomRequestHandlingFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLCaptchaActionFactoryExtensions
{
    public static CombinedResult<InnerWebACLCaptchaActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling(this InnerWebACLCaptchaActionFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null)
    {
        parentFactory.CustomRequestHandlingFactory = new InnerWebACLCustomRequestHandlingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomRequestHandlingFactory);
    }

    public static CombinedResult<InnerWebACLCaptchaActionFactory, T1, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<InnerWebACLCaptchaActionFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCaptchaActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1>(this CombinedResult<T1, InnerWebACLCaptchaActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLCaptchaActionFactory, T1, T2, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<InnerWebACLCaptchaActionFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCaptchaActionFactory, T2, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, InnerWebACLCaptchaActionFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCaptchaActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2>(this CombinedResult<T1, T2, InnerWebACLCaptchaActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLCaptchaActionFactory, T1, T2, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<InnerWebACLCaptchaActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCaptchaActionFactory, T2, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, InnerWebACLCaptchaActionFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCaptchaActionFactory, T3, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLCaptchaActionFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLCaptchaActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLCaptchaActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLCaptchaActionFactory, T1, T2, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<InnerWebACLCaptchaActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCaptchaActionFactory, T2, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLCaptchaActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCaptchaActionFactory, T3, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLCaptchaActionFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLCaptchaActionFactory, T4, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLCaptchaActionFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLCaptchaActionFactory, InnerWebACLCustomRequestHandlingFactory> WithCustomRequestHandling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLCaptchaActionFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomRequestHandling(combinedResult.T5, subFactoryAction));
}
