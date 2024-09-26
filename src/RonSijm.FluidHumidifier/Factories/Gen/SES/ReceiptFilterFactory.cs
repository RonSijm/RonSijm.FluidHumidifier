// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class ReceiptFilterFactory(string resourceName = null, Action<Humidifier.SES.ReceiptFilter> factoryAction = null) : ResourceFactory<Humidifier.SES.ReceiptFilter>(resourceName)
{

    internal InnerReceiptFilterFilterFactory FilterFactory { get; set; }

    protected override Humidifier.SES.ReceiptFilter Create()
    {
        var receiptFilterResult = CreateReceiptFilter();
        factoryAction?.Invoke(receiptFilterResult);

        return receiptFilterResult;
    }

    private Humidifier.SES.ReceiptFilter CreateReceiptFilter()
    {
        var receiptFilterResult = new Humidifier.SES.ReceiptFilter
        {
            GivenName = InputResourceName,
        };

        return receiptFilterResult;
    }
    public override void CreateChildren(Humidifier.SES.ReceiptFilter result)
    {
        base.CreateChildren(result);

        result.Filter ??= FilterFactory?.Build();
    }

} // End Of Class

public static class ReceiptFilterFactoryExtensions
{
    public static CombinedResult<ReceiptFilterFactory, InnerReceiptFilterFilterFactory> WithFilter(this ReceiptFilterFactory parentFactory, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null)
    {
        parentFactory.FilterFactory = new InnerReceiptFilterFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterFactory);
    }

    public static CombinedResult<ReceiptFilterFactory, T1, InnerReceiptFilterFilterFactory> WithFilter<T1>(this CombinedResult<ReceiptFilterFactory, T1> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReceiptFilterFactory, InnerReceiptFilterFilterFactory> WithFilter<T1>(this CombinedResult<T1, ReceiptFilterFactory> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ReceiptFilterFactory, T1, T2, InnerReceiptFilterFilterFactory> WithFilter<T1, T2>(this CombinedResult<ReceiptFilterFactory, T1, T2> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReceiptFilterFactory, T2, InnerReceiptFilterFilterFactory> WithFilter<T1, T2>(this CombinedResult<T1, ReceiptFilterFactory, T2> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReceiptFilterFactory, InnerReceiptFilterFilterFactory> WithFilter<T1, T2>(this CombinedResult<T1, T2, ReceiptFilterFactory> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ReceiptFilterFactory, T1, T2, T3, InnerReceiptFilterFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<ReceiptFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReceiptFilterFactory, T2, T3, InnerReceiptFilterFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<T1, ReceiptFilterFactory, T2, T3> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReceiptFilterFactory, T3, InnerReceiptFilterFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<T1, T2, ReceiptFilterFactory, T3> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReceiptFilterFactory, InnerReceiptFilterFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReceiptFilterFactory> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ReceiptFilterFactory, T1, T2, T3, T4, InnerReceiptFilterFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<ReceiptFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ReceiptFilterFactory, T2, T3, T4, InnerReceiptFilterFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, ReceiptFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ReceiptFilterFactory, T3, T4, InnerReceiptFilterFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReceiptFilterFactory, T3, T4> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ReceiptFilterFactory, T4, InnerReceiptFilterFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReceiptFilterFactory, T4> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ReceiptFilterFactory, InnerReceiptFilterFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReceiptFilterFactory> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.Filter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T5, subFactoryAction));
}
