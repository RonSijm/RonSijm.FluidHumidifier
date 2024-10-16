// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class InnerDataSourceHttpConfigFactory(Action<Humidifier.AppSync.DataSourceTypes.HttpConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppSync.DataSourceTypes.HttpConfig>
{

    internal InnerDataSourceAuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.AppSync.DataSourceTypes.HttpConfig Create()
    {
        var httpConfigResult = CreateHttpConfig();
        factoryAction?.Invoke(httpConfigResult);

        return httpConfigResult;
    }

    private Humidifier.AppSync.DataSourceTypes.HttpConfig CreateHttpConfig()
    {
        var httpConfigResult = new Humidifier.AppSync.DataSourceTypes.HttpConfig();

        return httpConfigResult;
    }
    public override void CreateChildren(Humidifier.AppSync.DataSourceTypes.HttpConfig result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceHttpConfigFactoryExtensions
{
    public static CombinedResult<InnerDataSourceHttpConfigFactory, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig(this InnerDataSourceHttpConfigFactory parentFactory, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerDataSourceAuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerDataSourceHttpConfigFactory, T1, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerDataSourceHttpConfigFactory, T1> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceHttpConfigFactory, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerDataSourceHttpConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceHttpConfigFactory, T1, T2, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerDataSourceHttpConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceHttpConfigFactory, T2, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerDataSourceHttpConfigFactory, T2> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceHttpConfigFactory, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceHttpConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceHttpConfigFactory, T1, T2, T3, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerDataSourceHttpConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceHttpConfigFactory, T2, T3, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceHttpConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceHttpConfigFactory, T3, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceHttpConfigFactory, T3> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceHttpConfigFactory, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceHttpConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceHttpConfigFactory, T1, T2, T3, T4, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceHttpConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceHttpConfigFactory, T2, T3, T4, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceHttpConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceHttpConfigFactory, T3, T4, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceHttpConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceHttpConfigFactory, T4, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceHttpConfigFactory, T4> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceHttpConfigFactory, InnerDataSourceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceHttpConfigFactory> combinedResult, Action<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction));
}
