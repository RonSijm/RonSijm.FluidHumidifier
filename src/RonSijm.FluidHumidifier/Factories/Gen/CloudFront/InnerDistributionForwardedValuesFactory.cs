// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionForwardedValuesFactory(Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.ForwardedValues>
{

    internal InnerDistributionCookiesFactory CookiesFactory { get; set; }

    protected override Humidifier.CloudFront.DistributionTypes.ForwardedValues Create()
    {
        var forwardedValuesResult = CreateForwardedValues();
        factoryAction?.Invoke(forwardedValuesResult);

        return forwardedValuesResult;
    }

    private Humidifier.CloudFront.DistributionTypes.ForwardedValues CreateForwardedValues()
    {
        var forwardedValuesResult = new Humidifier.CloudFront.DistributionTypes.ForwardedValues();

        return forwardedValuesResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.DistributionTypes.ForwardedValues result)
    {
        base.CreateChildren(result);

        result.Cookies ??= CookiesFactory?.Build();
    }

} // End Of Class

public static class InnerDistributionForwardedValuesFactoryExtensions
{
    public static CombinedResult<InnerDistributionForwardedValuesFactory, InnerDistributionCookiesFactory> WithCookies(this InnerDistributionForwardedValuesFactory parentFactory, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null)
    {
        parentFactory.CookiesFactory = new InnerDistributionCookiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CookiesFactory);
    }

    public static CombinedResult<InnerDistributionForwardedValuesFactory, T1, InnerDistributionCookiesFactory> WithCookies<T1>(this CombinedResult<InnerDistributionForwardedValuesFactory, T1> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, WithCookies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionForwardedValuesFactory, InnerDistributionCookiesFactory> WithCookies<T1>(this CombinedResult<T1, InnerDistributionForwardedValuesFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, WithCookies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDistributionForwardedValuesFactory, T1, T2, InnerDistributionCookiesFactory> WithCookies<T1, T2>(this CombinedResult<InnerDistributionForwardedValuesFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionForwardedValuesFactory, T2, InnerDistributionCookiesFactory> WithCookies<T1, T2>(this CombinedResult<T1, InnerDistributionForwardedValuesFactory, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionForwardedValuesFactory, InnerDistributionCookiesFactory> WithCookies<T1, T2>(this CombinedResult<T1, T2, InnerDistributionForwardedValuesFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDistributionForwardedValuesFactory, T1, T2, T3, InnerDistributionCookiesFactory> WithCookies<T1, T2, T3>(this CombinedResult<InnerDistributionForwardedValuesFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionForwardedValuesFactory, T2, T3, InnerDistributionCookiesFactory> WithCookies<T1, T2, T3>(this CombinedResult<T1, InnerDistributionForwardedValuesFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionForwardedValuesFactory, T3, InnerDistributionCookiesFactory> WithCookies<T1, T2, T3>(this CombinedResult<T1, T2, InnerDistributionForwardedValuesFactory, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionForwardedValuesFactory, InnerDistributionCookiesFactory> WithCookies<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDistributionForwardedValuesFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDistributionForwardedValuesFactory, T1, T2, T3, T4, InnerDistributionCookiesFactory> WithCookies<T1, T2, T3, T4>(this CombinedResult<InnerDistributionForwardedValuesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionForwardedValuesFactory, T2, T3, T4, InnerDistributionCookiesFactory> WithCookies<T1, T2, T3, T4>(this CombinedResult<T1, InnerDistributionForwardedValuesFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionForwardedValuesFactory, T3, T4, InnerDistributionCookiesFactory> WithCookies<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDistributionForwardedValuesFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionForwardedValuesFactory, T4, InnerDistributionCookiesFactory> WithCookies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDistributionForwardedValuesFactory, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDistributionForwardedValuesFactory, InnerDistributionCookiesFactory> WithCookies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDistributionForwardedValuesFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.Cookies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCookies(combinedResult.T5, subFactoryAction));
}
