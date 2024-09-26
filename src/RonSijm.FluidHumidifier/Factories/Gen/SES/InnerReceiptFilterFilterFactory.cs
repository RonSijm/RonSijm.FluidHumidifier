// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerReceiptFilterFilterFactory(Action<Humidifier.SES.ReceiptFilterTypes.Filter> factoryAction = null) : SubResourceFactory<Humidifier.SES.ReceiptFilterTypes.Filter>
{

    internal InnerReceiptFilterIpFilterFactory IpFilterFactory { get; set; }

    protected override Humidifier.SES.ReceiptFilterTypes.Filter Create()
    {
        var filterResult = CreateFilter();
        factoryAction?.Invoke(filterResult);

        return filterResult;
    }

    private Humidifier.SES.ReceiptFilterTypes.Filter CreateFilter()
    {
        var filterResult = new Humidifier.SES.ReceiptFilterTypes.Filter();

        return filterResult;
    }
    public override void CreateChildren(Humidifier.SES.ReceiptFilterTypes.Filter result)
    {
        base.CreateChildren(result);

        result.IpFilter ??= IpFilterFactory?.Build();
    }

} // End Of Class

public static class InnerReceiptFilterFilterFactoryExtensions
{
    public static CombinedResult<InnerReceiptFilterFilterFactory, InnerReceiptFilterIpFilterFactory> WithIpFilter(this InnerReceiptFilterFilterFactory parentFactory, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null)
    {
        parentFactory.IpFilterFactory = new InnerReceiptFilterIpFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IpFilterFactory);
    }

    public static CombinedResult<InnerReceiptFilterFilterFactory, T1, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1>(this CombinedResult<InnerReceiptFilterFilterFactory, T1> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReceiptFilterFilterFactory, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1>(this CombinedResult<T1, InnerReceiptFilterFilterFactory> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerReceiptFilterFilterFactory, T1, T2, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2>(this CombinedResult<InnerReceiptFilterFilterFactory, T1, T2> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReceiptFilterFilterFactory, T2, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2>(this CombinedResult<T1, InnerReceiptFilterFilterFactory, T2> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReceiptFilterFilterFactory, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2>(this CombinedResult<T1, T2, InnerReceiptFilterFilterFactory> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerReceiptFilterFilterFactory, T1, T2, T3, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2, T3>(this CombinedResult<InnerReceiptFilterFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReceiptFilterFilterFactory, T2, T3, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2, T3>(this CombinedResult<T1, InnerReceiptFilterFilterFactory, T2, T3> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReceiptFilterFilterFactory, T3, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerReceiptFilterFilterFactory, T3> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReceiptFilterFilterFactory, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerReceiptFilterFilterFactory> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerReceiptFilterFilterFactory, T1, T2, T3, T4, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2, T3, T4>(this CombinedResult<InnerReceiptFilterFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReceiptFilterFilterFactory, T2, T3, T4, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerReceiptFilterFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReceiptFilterFilterFactory, T3, T4, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerReceiptFilterFilterFactory, T3, T4> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReceiptFilterFilterFactory, T4, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerReceiptFilterFilterFactory, T4> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerReceiptFilterFilterFactory, InnerReceiptFilterIpFilterFactory> WithIpFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerReceiptFilterFilterFactory> combinedResult, Action<Humidifier.SES.ReceiptFilterTypes.IpFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpFilter(combinedResult.T5, subFactoryAction));
}
