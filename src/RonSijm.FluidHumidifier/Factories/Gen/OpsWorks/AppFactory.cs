// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class AppFactory(string resourceName = null, Action<Humidifier.OpsWorks.App> factoryAction = null) : ResourceFactory<Humidifier.OpsWorks.App>(resourceName)
{

    internal List<InnerAppDataSourceFactory> DataSourcesFactories { get; set; } = [];

    internal List<InnerAppEnvironmentVariableFactory> EnvironmentFactories { get; set; } = [];

    internal InnerAppSourceFactory AppSourceFactory { get; set; }

    internal InnerAppSslConfigurationFactory SslConfigurationFactory { get; set; }

    protected override Humidifier.OpsWorks.App Create()
    {
        var appResult = CreateApp();
        factoryAction?.Invoke(appResult);

        return appResult;
    }

    private Humidifier.OpsWorks.App CreateApp()
    {
        var appResult = new Humidifier.OpsWorks.App
        {
            GivenName = InputResourceName,
        };

        return appResult;
    }
    public override void CreateChildren(Humidifier.OpsWorks.App result)
    {
        base.CreateChildren(result);

        result.DataSources = DataSourcesFactories.Any() ? DataSourcesFactories.Select(x => x.Build()).ToList() : null;
        result.Environment = EnvironmentFactories.Any() ? EnvironmentFactories.Select(x => x.Build()).ToList() : null;
        result.AppSource ??= AppSourceFactory?.Build();
        result.SslConfiguration ??= SslConfigurationFactory?.Build();
    }

} // End Of Class

public static class AppFactoryExtensions
{
    public static CombinedResult<AppFactory, InnerAppDataSourceFactory> WithDataSources(this AppFactory parentFactory, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null)
    {
        var factory = new InnerAppDataSourceFactory(subFactoryAction);
        parentFactory.DataSourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AppFactory, InnerAppEnvironmentVariableFactory> WithEnvironment(this AppFactory parentFactory, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null)
    {
        var factory = new InnerAppEnvironmentVariableFactory(subFactoryAction);
        parentFactory.EnvironmentFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AppFactory, InnerAppSourceFactory> WithAppSource(this AppFactory parentFactory, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null)
    {
        parentFactory.AppSourceFactory = new InnerAppSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AppSourceFactory);
    }

    public static CombinedResult<AppFactory, InnerAppSslConfigurationFactory> WithSslConfiguration(this AppFactory parentFactory, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null)
    {
        parentFactory.SslConfigurationFactory = new InnerAppSslConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SslConfigurationFactory);
    }

    public static CombinedResult<AppFactory, T1, InnerAppDataSourceFactory> WithDataSources<T1>(this CombinedResult<AppFactory, T1> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, InnerAppDataSourceFactory> WithDataSources<T1>(this CombinedResult<T1, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, InnerAppDataSourceFactory> WithDataSources<T1, T2>(this CombinedResult<AppFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, InnerAppDataSourceFactory> WithDataSources<T1, T2>(this CombinedResult<T1, AppFactory, T2> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, InnerAppDataSourceFactory> WithDataSources<T1, T2>(this CombinedResult<T1, T2, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, InnerAppDataSourceFactory> WithDataSources<T1, T2, T3>(this CombinedResult<AppFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, InnerAppDataSourceFactory> WithDataSources<T1, T2, T3>(this CombinedResult<T1, AppFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, InnerAppDataSourceFactory> WithDataSources<T1, T2, T3>(this CombinedResult<T1, T2, AppFactory, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, InnerAppDataSourceFactory> WithDataSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, T4, InnerAppDataSourceFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<AppFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, T4, InnerAppDataSourceFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, AppFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, T4, InnerAppDataSourceFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, T4, InnerAppDataSourceFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppFactory, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppFactory, InnerAppDataSourceFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AppFactory, T1, InnerAppEnvironmentVariableFactory> WithEnvironment<T1>(this CombinedResult<AppFactory, T1> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, InnerAppEnvironmentVariableFactory> WithEnvironment<T1>(this CombinedResult<T1, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2>(this CombinedResult<AppFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2>(this CombinedResult<T1, AppFactory, T2> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2>(this CombinedResult<T1, T2, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<AppFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<T1, AppFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, AppFactory, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, T4, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<AppFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, T4, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, AppFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, T4, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, T4, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppFactory, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppFactory, InnerAppEnvironmentVariableFactory> WithEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironment(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AppFactory, T1, InnerAppSourceFactory> WithAppSource<T1>(this CombinedResult<AppFactory, T1> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, InnerAppSourceFactory> WithAppSource<T1>(this CombinedResult<T1, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, InnerAppSourceFactory> WithAppSource<T1, T2>(this CombinedResult<AppFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, InnerAppSourceFactory> WithAppSource<T1, T2>(this CombinedResult<T1, AppFactory, T2> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, InnerAppSourceFactory> WithAppSource<T1, T2>(this CombinedResult<T1, T2, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, InnerAppSourceFactory> WithAppSource<T1, T2, T3>(this CombinedResult<AppFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, InnerAppSourceFactory> WithAppSource<T1, T2, T3>(this CombinedResult<T1, AppFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, InnerAppSourceFactory> WithAppSource<T1, T2, T3>(this CombinedResult<T1, T2, AppFactory, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, InnerAppSourceFactory> WithAppSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, T4, InnerAppSourceFactory> WithAppSource<T1, T2, T3, T4>(this CombinedResult<AppFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, T4, InnerAppSourceFactory> WithAppSource<T1, T2, T3, T4>(this CombinedResult<T1, AppFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, T4, InnerAppSourceFactory> WithAppSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, T4, InnerAppSourceFactory> WithAppSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppFactory, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppFactory, InnerAppSourceFactory> WithAppSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppSource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AppFactory, T1, InnerAppSslConfigurationFactory> WithSslConfiguration<T1>(this CombinedResult<AppFactory, T1> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSslConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, InnerAppSslConfigurationFactory> WithSslConfiguration<T1>(this CombinedResult<T1, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSslConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2>(this CombinedResult<AppFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2>(this CombinedResult<T1, AppFactory, T2> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2>(this CombinedResult<T1, T2, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2, T3>(this CombinedResult<AppFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2, T3>(this CombinedResult<T1, AppFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AppFactory, T3> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, T4, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2, T3, T4>(this CombinedResult<AppFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, T4, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AppFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, T4, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, T4, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppFactory, T4> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppFactory, InnerAppSslConfigurationFactory> WithSslConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppFactory> combinedResult, Action<Humidifier.OpsWorks.AppTypes.SslConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSslConfiguration(combinedResult.T5, subFactoryAction));
}
