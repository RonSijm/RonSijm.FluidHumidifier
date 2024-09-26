// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class UrlFactory(string resourceName = null, Action<Humidifier.Lambda.Url> factoryAction = null) : ResourceFactory<Humidifier.Lambda.Url>(resourceName)
{

    internal InnerUrlCorsFactory CorsFactory { get; set; }

    protected override Humidifier.Lambda.Url Create()
    {
        var urlResult = CreateUrl();
        factoryAction?.Invoke(urlResult);

        return urlResult;
    }

    private Humidifier.Lambda.Url CreateUrl()
    {
        var urlResult = new Humidifier.Lambda.Url
        {
            GivenName = InputResourceName,
        };

        return urlResult;
    }
    public override void CreateChildren(Humidifier.Lambda.Url result)
    {
        base.CreateChildren(result);

        result.Cors ??= CorsFactory?.Build();
    }

} // End Of Class

public static class UrlFactoryExtensions
{
    public static CombinedResult<UrlFactory, InnerUrlCorsFactory> WithCors(this UrlFactory parentFactory, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null)
    {
        parentFactory.CorsFactory = new InnerUrlCorsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CorsFactory);
    }

    public static CombinedResult<UrlFactory, T1, InnerUrlCorsFactory> WithCors<T1>(this CombinedResult<UrlFactory, T1> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, WithCors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UrlFactory, InnerUrlCorsFactory> WithCors<T1>(this CombinedResult<T1, UrlFactory> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, WithCors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UrlFactory, T1, T2, InnerUrlCorsFactory> WithCors<T1, T2>(this CombinedResult<UrlFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UrlFactory, T2, InnerUrlCorsFactory> WithCors<T1, T2>(this CombinedResult<T1, UrlFactory, T2> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UrlFactory, InnerUrlCorsFactory> WithCors<T1, T2>(this CombinedResult<T1, T2, UrlFactory> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UrlFactory, T1, T2, T3, InnerUrlCorsFactory> WithCors<T1, T2, T3>(this CombinedResult<UrlFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UrlFactory, T2, T3, InnerUrlCorsFactory> WithCors<T1, T2, T3>(this CombinedResult<T1, UrlFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UrlFactory, T3, InnerUrlCorsFactory> WithCors<T1, T2, T3>(this CombinedResult<T1, T2, UrlFactory, T3> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UrlFactory, InnerUrlCorsFactory> WithCors<T1, T2, T3>(this CombinedResult<T1, T2, T3, UrlFactory> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UrlFactory, T1, T2, T3, T4, InnerUrlCorsFactory> WithCors<T1, T2, T3, T4>(this CombinedResult<UrlFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UrlFactory, T2, T3, T4, InnerUrlCorsFactory> WithCors<T1, T2, T3, T4>(this CombinedResult<T1, UrlFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UrlFactory, T3, T4, InnerUrlCorsFactory> WithCors<T1, T2, T3, T4>(this CombinedResult<T1, T2, UrlFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UrlFactory, T4, InnerUrlCorsFactory> WithCors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UrlFactory, T4> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UrlFactory, InnerUrlCorsFactory> WithCors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UrlFactory> combinedResult, Action<Humidifier.Lambda.UrlTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCors(combinedResult.T5, subFactoryAction));
}
