// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class DataSourceFactory(string resourceName = null, Action<Humidifier.Kendra.DataSource> factoryAction = null) : ResourceFactory<Humidifier.Kendra.DataSource>(resourceName)
{

    internal InnerDataSourceCustomDocumentEnrichmentConfigurationFactory CustomDocumentEnrichmentConfigurationFactory { get; set; }

    internal InnerDataSourceDataSourceConfigurationFactory DataSourceConfigurationFactory { get; set; }

    protected override Humidifier.Kendra.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.Kendra.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.Kendra.DataSource
        {
            GivenName = InputResourceName,
        };

        return dataSourceResult;
    }
    public override void CreateChildren(Humidifier.Kendra.DataSource result)
    {
        base.CreateChildren(result);

        result.CustomDocumentEnrichmentConfiguration ??= CustomDocumentEnrichmentConfigurationFactory?.Build();
        result.DataSourceConfiguration ??= DataSourceConfigurationFactory?.Build();
    }

} // End Of Class

public static class DataSourceFactoryExtensions
{
    public static CombinedResult<DataSourceFactory, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration(this DataSourceFactory parentFactory, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null)
    {
        parentFactory.CustomDocumentEnrichmentConfigurationFactory = new InnerDataSourceCustomDocumentEnrichmentConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomDocumentEnrichmentConfigurationFactory);
    }

    public static CombinedResult<DataSourceFactory, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration(this DataSourceFactory parentFactory, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null)
    {
        parentFactory.DataSourceConfigurationFactory = new InnerDataSourceDataSourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceConfigurationFactory);
    }

    public static CombinedResult<DataSourceFactory, T1, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1>(this CombinedResult<DataSourceFactory, T1> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1>(this CombinedResult<T1, DataSourceFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2>(this CombinedResult<DataSourceFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2>(this CombinedResult<T1, DataSourceFactory, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2>(this CombinedResult<T1, T2, DataSourceFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, T3, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2, T3>(this CombinedResult<DataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, T3, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2, T3>(this CombinedResult<T1, DataSourceFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, T3, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DataSourceFactory, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataSourceFactory, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataSourceFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, T3, T4, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2, T3, T4>(this CombinedResult<DataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, T3, T4, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, T3, T4, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataSourceFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataSourceFactory, T4, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataSourceFactory, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataSourceFactory, InnerDataSourceCustomDocumentEnrichmentConfigurationFactory> WithCustomDocumentEnrichmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataSourceFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.CustomDocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDocumentEnrichmentConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1>(this CombinedResult<DataSourceFactory, T1> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1>(this CombinedResult<T1, DataSourceFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2>(this CombinedResult<DataSourceFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2>(this CombinedResult<T1, DataSourceFactory, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2>(this CombinedResult<T1, T2, DataSourceFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, T3, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<DataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, T3, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, DataSourceFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, T3, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DataSourceFactory, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataSourceFactory, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataSourceFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, T3, T4, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<DataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, T3, T4, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, T3, T4, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataSourceFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataSourceFactory, T4, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataSourceFactory, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataSourceFactory, InnerDataSourceDataSourceConfigurationFactory> WithDataSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataSourceFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceConfiguration(combinedResult.T5, subFactoryAction));
}
