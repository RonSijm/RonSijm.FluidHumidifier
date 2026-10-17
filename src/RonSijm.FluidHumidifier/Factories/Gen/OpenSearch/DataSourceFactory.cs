// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearch;

public class DataSourceFactory(string resourceName = null, Action<Humidifier.OpenSearch.DataSource> factoryAction = null) : ResourceFactory<Humidifier.OpenSearch.DataSource>(resourceName)
{

    internal InnerDataSourceDataSourceTypeFactory DataSourceTypeFactory { get; set; }

    protected override Humidifier.OpenSearch.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.OpenSearch.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.OpenSearch.DataSource
        {
            GivenName = InputResourceName,
        };

        return dataSourceResult;
    }
    public override void CreateChildren(Humidifier.OpenSearch.DataSource result)
    {
        base.CreateChildren(result);

        result.DataSourceType ??= DataSourceTypeFactory?.Build();
    }

} // End Of Class

public static class DataSourceFactoryExtensions
{
    public static CombinedResult<DataSourceFactory, InnerDataSourceDataSourceTypeFactory> WithDataSourceType(this DataSourceFactory parentFactory, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null)
    {
        parentFactory.DataSourceTypeFactory = new InnerDataSourceDataSourceTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceTypeFactory);
    }

    public static CombinedResult<DataSourceFactory, T1, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1>(this CombinedResult<DataSourceFactory, T1> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSourceType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataSourceFactory, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1>(this CombinedResult<T1, DataSourceFactory> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSourceType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DataSourceFactory, T1, T2, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2>(this CombinedResult<DataSourceFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataSourceFactory, T2, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2>(this CombinedResult<T1, DataSourceFactory, T2> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataSourceFactory, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2>(this CombinedResult<T1, T2, DataSourceFactory> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DataSourceFactory, T1, T2, T3, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2, T3>(this CombinedResult<DataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataSourceFactory, T2, T3, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2, T3>(this CombinedResult<T1, DataSourceFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataSourceFactory, T3, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2, T3>(this CombinedResult<T1, T2, DataSourceFactory, T3> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataSourceFactory, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataSourceFactory> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DataSourceFactory, T1, T2, T3, T4, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2, T3, T4>(this CombinedResult<DataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataSourceFactory, T2, T3, T4, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2, T3, T4>(this CombinedResult<T1, DataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataSourceFactory, T3, T4, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataSourceFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataSourceFactory, T4, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataSourceFactory, T4> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DataSourceFactory, InnerDataSourceDataSourceTypeFactory> WithDataSourceType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataSourceFactory> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSourceType(combinedResult.T5, subFactoryAction).T2);
}
