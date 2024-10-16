// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerTrainingDatasetDataSourceFactory(Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource>
{

    internal InnerTrainingDatasetGlueDataSourceFactory GlueDataSourceFactory { get; set; }

    protected override Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource();

        return dataSourceResult;
    }
    public override void CreateChildren(Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource result)
    {
        base.CreateChildren(result);

        result.GlueDataSource ??= GlueDataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerTrainingDatasetDataSourceFactoryExtensions
{
    public static CombinedResult<InnerTrainingDatasetDataSourceFactory, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource(this InnerTrainingDatasetDataSourceFactory parentFactory, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null)
    {
        parentFactory.GlueDataSourceFactory = new InnerTrainingDatasetGlueDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GlueDataSourceFactory);
    }

    public static CombinedResult<InnerTrainingDatasetDataSourceFactory, T1, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1>(this CombinedResult<InnerTrainingDatasetDataSourceFactory, T1> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlueDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDataSourceFactory, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1>(this CombinedResult<T1, InnerTrainingDatasetDataSourceFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlueDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTrainingDatasetDataSourceFactory, T1, T2, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2>(this CombinedResult<InnerTrainingDatasetDataSourceFactory, T1, T2> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDataSourceFactory, T2, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2>(this CombinedResult<T1, InnerTrainingDatasetDataSourceFactory, T2> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrainingDatasetDataSourceFactory, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2>(this CombinedResult<T1, T2, InnerTrainingDatasetDataSourceFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTrainingDatasetDataSourceFactory, T1, T2, T3, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2, T3>(this CombinedResult<InnerTrainingDatasetDataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDataSourceFactory, T2, T3, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2, T3>(this CombinedResult<T1, InnerTrainingDatasetDataSourceFactory, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrainingDatasetDataSourceFactory, T3, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrainingDatasetDataSourceFactory, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTrainingDatasetDataSourceFactory, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrainingDatasetDataSourceFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTrainingDatasetDataSourceFactory, T1, T2, T3, T4, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2, T3, T4>(this CombinedResult<InnerTrainingDatasetDataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDataSourceFactory, T2, T3, T4, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrainingDatasetDataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrainingDatasetDataSourceFactory, T3, T4, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrainingDatasetDataSourceFactory, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTrainingDatasetDataSourceFactory, T4, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrainingDatasetDataSourceFactory, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTrainingDatasetDataSourceFactory, InnerTrainingDatasetGlueDataSourceFactory> WithGlueDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrainingDatasetDataSourceFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueDataSource(combinedResult.T5, subFactoryAction));
}
