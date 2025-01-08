// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.OpenSearchService.Application> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchService.Application>(resourceName)
{

    internal List<InnerApplicationDataSourceFactory> DataSourcesFactories { get; set; } = [];

    internal List<InnerApplicationAppConfigFactory> AppConfigsFactories { get; set; } = [];

    internal InnerApplicationIamIdentityCenterOptionsFactory IamIdentityCenterOptionsFactory { get; set; }

    protected override Humidifier.OpenSearchService.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.OpenSearchService.Application CreateApplication()
    {
        var applicationResult = new Humidifier.OpenSearchService.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchService.Application result)
    {
        base.CreateChildren(result);

        result.DataSources = DataSourcesFactories.Any() ? DataSourcesFactories.Select(x => x.Build()).ToList() : null;
        result.AppConfigs = AppConfigsFactories.Any() ? AppConfigsFactories.Select(x => x.Build()).ToList() : null;
        result.IamIdentityCenterOptions ??= IamIdentityCenterOptionsFactory?.Build();
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationDataSourceFactory> WithDataSources(this ApplicationFactory parentFactory, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null)
    {
        var factory = new InnerApplicationDataSourceFactory(subFactoryAction);
        parentFactory.DataSourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ApplicationFactory, InnerApplicationAppConfigFactory> WithAppConfigs(this ApplicationFactory parentFactory, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null)
    {
        var factory = new InnerApplicationAppConfigFactory(subFactoryAction);
        parentFactory.AppConfigsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ApplicationFactory, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions(this ApplicationFactory parentFactory, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null)
    {
        parentFactory.IamIdentityCenterOptionsFactory = new InnerApplicationIamIdentityCenterOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IamIdentityCenterOptionsFactory);
    }

    public static CombinedResult<ApplicationFactory, T1, InnerApplicationDataSourceFactory> WithDataSources<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationDataSourceFactory> WithDataSources<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationDataSourceFactory> WithDataSources<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationDataSourceFactory> WithDataSources<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationDataSourceFactory> WithDataSources<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationDataSourceFactory> WithDataSources<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationDataSourceFactory> WithDataSources<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationDataSourceFactory> WithDataSources<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationDataSourceFactory> WithDataSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationDataSourceFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationDataSourceFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationDataSourceFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationDataSourceFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationDataSourceFactory> WithDataSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSources(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, InnerApplicationAppConfigFactory> WithAppConfigs<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationAppConfigFactory> WithAppConfigs<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationAppConfigFactory> WithAppConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigs(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationIamIdentityCenterOptionsFactory> WithIamIdentityCenterOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.OpenSearchService.ApplicationTypes.IamIdentityCenterOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIamIdentityCenterOptions(combinedResult.T5, subFactoryAction));
}
