// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class DataSourceFactory(string resourceName = null, Action<Humidifier.QBusiness.DataSource> factoryAction = null) : ResourceFactory<Humidifier.QBusiness.DataSource>(resourceName)
{

    internal InnerDataSourceDocumentEnrichmentConfigurationFactory DocumentEnrichmentConfigurationFactory { get; set; }

    internal InnerDataSourceDataSourceVpcConfigurationFactory VpcConfigurationFactory { get; set; }

    protected override Humidifier.QBusiness.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.QBusiness.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.QBusiness.DataSource
        {
            GivenName = InputResourceName,
        };

        return dataSourceResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.DataSource result)
    {
        base.CreateChildren(result);

        result.DocumentEnrichmentConfiguration ??= DocumentEnrichmentConfigurationFactory?.Build();
        result.VpcConfiguration ??= VpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class DataSourceFactoryExtensions
{
    public static CombinedResult<DataSourceFactory, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration(this DataSourceFactory parentFactory, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null)
    {
        parentFactory.DocumentEnrichmentConfigurationFactory = new InnerDataSourceDocumentEnrichmentConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DocumentEnrichmentConfigurationFactory);
    }

    public static CombinedResult<DataSourceFactory, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration(this DataSourceFactory parentFactory, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcConfigurationFactory = new InnerDataSourceDataSourceVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigurationFactory);
    }

    public static CombinedResult<DataSourceFactory, T1, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1>(this CombinedResult<DataSourceFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1>(this CombinedResult<T1, DataSourceFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2>(this CombinedResult<DataSourceFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2>(this CombinedResult<T1, DataSourceFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2>(this CombinedResult<T1, T2, DataSourceFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, T3, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2, T3>(this CombinedResult<DataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, T3, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2, T3>(this CombinedResult<T1, DataSourceFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, T3, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DataSourceFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataSourceFactory, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataSourceFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, T3, T4, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2, T3, T4>(this CombinedResult<DataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, T3, T4, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, T3, T4, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataSourceFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataSourceFactory, T4, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataSourceFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataSourceFactory, InnerDataSourceDocumentEnrichmentConfigurationFactory> WithDocumentEnrichmentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataSourceFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DocumentEnrichmentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentEnrichmentConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<DataSourceFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<T1, DataSourceFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<DataSourceFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, DataSourceFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, DataSourceFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, T3, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<DataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, T3, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, DataSourceFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, T3, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DataSourceFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataSourceFactory, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataSourceFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataSourceFactory, T1, T2, T3, T4, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<DataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataSourceFactory, T2, T3, T4, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataSourceFactory, T3, T4, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataSourceFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataSourceFactory, T4, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataSourceFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataSourceFactory, InnerDataSourceDataSourceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataSourceFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T5, subFactoryAction));
}
