// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class WebFunctionRevisionFactory(string resourceName = null, Action<Humidifier.Lambda.WebFunctionRevision> factoryAction = null) : ResourceFactory<Humidifier.Lambda.WebFunctionRevision>(resourceName)
{

    internal InnerWebFunctionRevisionServiceConfigFactory ServiceConfigFactory { get; set; }

    internal InnerWebFunctionRevisionBuildConfigFactory BuildConfigFactory { get; set; }

    protected override Humidifier.Lambda.WebFunctionRevision Create()
    {
        var webFunctionRevisionResult = CreateWebFunctionRevision();
        factoryAction?.Invoke(webFunctionRevisionResult);

        return webFunctionRevisionResult;
    }

    private Humidifier.Lambda.WebFunctionRevision CreateWebFunctionRevision()
    {
        var webFunctionRevisionResult = new Humidifier.Lambda.WebFunctionRevision
        {
            GivenName = InputResourceName,
        };

        return webFunctionRevisionResult;
    }
    public override void CreateChildren(Humidifier.Lambda.WebFunctionRevision result)
    {
        base.CreateChildren(result);

        result.ServiceConfig ??= ServiceConfigFactory?.Build();
        result.BuildConfig ??= BuildConfigFactory?.Build();
    }

} // End Of Class

public static class WebFunctionRevisionFactoryExtensions
{
    public static CombinedResult<WebFunctionRevisionFactory, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig(this WebFunctionRevisionFactory parentFactory, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null)
    {
        parentFactory.ServiceConfigFactory = new InnerWebFunctionRevisionServiceConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServiceConfigFactory);
    }

    public static CombinedResult<WebFunctionRevisionFactory, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig(this WebFunctionRevisionFactory parentFactory, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null)
    {
        parentFactory.BuildConfigFactory = new InnerWebFunctionRevisionBuildConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BuildConfigFactory);
    }

    public static CombinedResult<WebFunctionRevisionFactory, T1, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1>(this CombinedResult<WebFunctionRevisionFactory, T1> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WebFunctionRevisionFactory, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1>(this CombinedResult<T1, WebFunctionRevisionFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WebFunctionRevisionFactory, T1, T2, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2>(this CombinedResult<WebFunctionRevisionFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WebFunctionRevisionFactory, T2, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2>(this CombinedResult<T1, WebFunctionRevisionFactory, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WebFunctionRevisionFactory, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2>(this CombinedResult<T1, T2, WebFunctionRevisionFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WebFunctionRevisionFactory, T1, T2, T3, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2, T3>(this CombinedResult<WebFunctionRevisionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WebFunctionRevisionFactory, T2, T3, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2, T3>(this CombinedResult<T1, WebFunctionRevisionFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WebFunctionRevisionFactory, T3, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2, T3>(this CombinedResult<T1, T2, WebFunctionRevisionFactory, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WebFunctionRevisionFactory, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, WebFunctionRevisionFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WebFunctionRevisionFactory, T1, T2, T3, T4, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2, T3, T4>(this CombinedResult<WebFunctionRevisionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WebFunctionRevisionFactory, T2, T3, T4, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2, T3, T4>(this CombinedResult<T1, WebFunctionRevisionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WebFunctionRevisionFactory, T3, T4, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, WebFunctionRevisionFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WebFunctionRevisionFactory, T4, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WebFunctionRevisionFactory, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WebFunctionRevisionFactory, InnerWebFunctionRevisionServiceConfigFactory> WithServiceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WebFunctionRevisionFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<WebFunctionRevisionFactory, T1, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1>(this CombinedResult<WebFunctionRevisionFactory, T1> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithBuildConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WebFunctionRevisionFactory, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1>(this CombinedResult<T1, WebFunctionRevisionFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithBuildConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WebFunctionRevisionFactory, T1, T2, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2>(this CombinedResult<WebFunctionRevisionFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WebFunctionRevisionFactory, T2, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2>(this CombinedResult<T1, WebFunctionRevisionFactory, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WebFunctionRevisionFactory, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2>(this CombinedResult<T1, T2, WebFunctionRevisionFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WebFunctionRevisionFactory, T1, T2, T3, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2, T3>(this CombinedResult<WebFunctionRevisionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WebFunctionRevisionFactory, T2, T3, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2, T3>(this CombinedResult<T1, WebFunctionRevisionFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WebFunctionRevisionFactory, T3, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2, T3>(this CombinedResult<T1, T2, WebFunctionRevisionFactory, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WebFunctionRevisionFactory, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, WebFunctionRevisionFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WebFunctionRevisionFactory, T1, T2, T3, T4, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2, T3, T4>(this CombinedResult<WebFunctionRevisionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WebFunctionRevisionFactory, T2, T3, T4, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2, T3, T4>(this CombinedResult<T1, WebFunctionRevisionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WebFunctionRevisionFactory, T3, T4, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, WebFunctionRevisionFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WebFunctionRevisionFactory, T4, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WebFunctionRevisionFactory, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WebFunctionRevisionFactory, InnerWebFunctionRevisionBuildConfigFactory> WithBuildConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WebFunctionRevisionFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.BuildConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildConfig(combinedResult.T5, subFactoryAction).T2);
}
