// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class DatasetFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.Dataset> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.Dataset>(resourceName)
{

    internal InnerDatasetDataSourceTypeFactory SourceFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.Dataset Create()
    {
        var datasetResult = CreateDataset();
        factoryAction?.Invoke(datasetResult);

        return datasetResult;
    }

    private Humidifier.BedrockAgentCore.Dataset CreateDataset()
    {
        var datasetResult = new Humidifier.BedrockAgentCore.Dataset
        {
            GivenName = InputResourceName,
        };

        return datasetResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.Dataset result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class DatasetFactoryExtensions
{
    public static CombinedResult<DatasetFactory, InnerDatasetDataSourceTypeFactory> WithSource(this DatasetFactory parentFactory, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerDatasetDataSourceTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<DatasetFactory, T1, InnerDatasetDataSourceTypeFactory> WithSource<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, InnerDatasetDataSourceTypeFactory> WithSource<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetDataSourceTypeFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
