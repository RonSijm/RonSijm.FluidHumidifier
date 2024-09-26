// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerTrainingDatasetDatasetInputConfigFactory(Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig>
{

    internal InnerTrainingDatasetDataSourceFactory DataSourceFactory { get; set; }

    protected override Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig Create()
    {
        var datasetInputConfigResult = CreateDatasetInputConfig();
        factoryAction?.Invoke(datasetInputConfigResult);

        return datasetInputConfigResult;
    }

    private Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig CreateDatasetInputConfig()
    {
        var datasetInputConfigResult = new Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig();

        return datasetInputConfigResult;
    }
    public override void CreateChildren(Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig result)
    {
        base.CreateChildren(result);

        result.DataSource ??= DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerTrainingDatasetDatasetInputConfigFactoryExtensions
{
    public static CombinedResult<InnerTrainingDatasetDatasetInputConfigFactory, InnerTrainingDatasetDataSourceFactory> WithDataSource(this InnerTrainingDatasetDatasetInputConfigFactory parentFactory, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null)
    {
        parentFactory.DataSourceFactory = new InnerTrainingDatasetDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceFactory);
    }

    public static CombinedResult<InnerTrainingDatasetDatasetInputConfigFactory, T1, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1>(this CombinedResult<InnerTrainingDatasetDatasetInputConfigFactory, T1> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDatasetInputConfigFactory, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1>(this CombinedResult<T1, InnerTrainingDatasetDatasetInputConfigFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTrainingDatasetDatasetInputConfigFactory, T1, T2, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<InnerTrainingDatasetDatasetInputConfigFactory, T1, T2> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDatasetInputConfigFactory, T2, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, InnerTrainingDatasetDatasetInputConfigFactory, T2> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrainingDatasetDatasetInputConfigFactory, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, T2, InnerTrainingDatasetDatasetInputConfigFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTrainingDatasetDatasetInputConfigFactory, T1, T2, T3, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<InnerTrainingDatasetDatasetInputConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDatasetInputConfigFactory, T2, T3, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, InnerTrainingDatasetDatasetInputConfigFactory, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrainingDatasetDatasetInputConfigFactory, T3, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrainingDatasetDatasetInputConfigFactory, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTrainingDatasetDatasetInputConfigFactory, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrainingDatasetDatasetInputConfigFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTrainingDatasetDatasetInputConfigFactory, T1, T2, T3, T4, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<InnerTrainingDatasetDatasetInputConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDatasetInputConfigFactory, T2, T3, T4, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrainingDatasetDatasetInputConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrainingDatasetDatasetInputConfigFactory, T3, T4, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrainingDatasetDatasetInputConfigFactory, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTrainingDatasetDatasetInputConfigFactory, T4, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrainingDatasetDatasetInputConfigFactory, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTrainingDatasetDatasetInputConfigFactory, InnerTrainingDatasetDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrainingDatasetDatasetInputConfigFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T5, subFactoryAction));
}
