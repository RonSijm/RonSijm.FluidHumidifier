// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class ResponseHeadersPolicyFactory(string resourceName = null, Action<Humidifier.CloudFront.ResponseHeadersPolicy> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicy>(resourceName)
{

    internal InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory ResponseHeadersPolicyConfigFactory { get; set; }

    protected override Humidifier.CloudFront.ResponseHeadersPolicy Create()
    {
        var responseHeadersPolicyResult = CreateResponseHeadersPolicy();
        factoryAction?.Invoke(responseHeadersPolicyResult);

        return responseHeadersPolicyResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicy CreateResponseHeadersPolicy()
    {
        var responseHeadersPolicyResult = new Humidifier.CloudFront.ResponseHeadersPolicy
        {
            GivenName = InputResourceName,
        };

        return responseHeadersPolicyResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.ResponseHeadersPolicy result)
    {
        base.CreateChildren(result);

        result.ResponseHeadersPolicyConfig ??= ResponseHeadersPolicyConfigFactory?.Build();
    }

} // End Of Class

public static class ResponseHeadersPolicyFactoryExtensions
{
    public static CombinedResult<ResponseHeadersPolicyFactory, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig(this ResponseHeadersPolicyFactory parentFactory, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null)
    {
        parentFactory.ResponseHeadersPolicyConfigFactory = new InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResponseHeadersPolicyConfigFactory);
    }

    public static CombinedResult<ResponseHeadersPolicyFactory, T1, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1>(this CombinedResult<ResponseHeadersPolicyFactory, T1> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResponseHeadersPolicyFactory, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1>(this CombinedResult<T1, ResponseHeadersPolicyFactory> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResponseHeadersPolicyFactory, T1, T2, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2>(this CombinedResult<ResponseHeadersPolicyFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResponseHeadersPolicyFactory, T2, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2>(this CombinedResult<T1, ResponseHeadersPolicyFactory, T2> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResponseHeadersPolicyFactory, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2>(this CombinedResult<T1, T2, ResponseHeadersPolicyFactory> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResponseHeadersPolicyFactory, T1, T2, T3, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2, T3>(this CombinedResult<ResponseHeadersPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResponseHeadersPolicyFactory, T2, T3, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2, T3>(this CombinedResult<T1, ResponseHeadersPolicyFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResponseHeadersPolicyFactory, T3, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2, T3>(this CombinedResult<T1, T2, ResponseHeadersPolicyFactory, T3> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResponseHeadersPolicyFactory, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResponseHeadersPolicyFactory> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResponseHeadersPolicyFactory, T1, T2, T3, T4, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2, T3, T4>(this CombinedResult<ResponseHeadersPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResponseHeadersPolicyFactory, T2, T3, T4, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, ResponseHeadersPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResponseHeadersPolicyFactory, T3, T4, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResponseHeadersPolicyFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResponseHeadersPolicyFactory, T4, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResponseHeadersPolicyFactory, T4> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResponseHeadersPolicyFactory, InnerResponseHeadersPolicyResponseHeadersPolicyConfigFactory> WithResponseHeadersPolicyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResponseHeadersPolicyFactory> combinedResult, Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ResponseHeadersPolicyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResponseHeadersPolicyConfig(combinedResult.T5, subFactoryAction));
}
