// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerTrainingDatasetDatasetFactory(Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset>
{

    internal InnerTrainingDatasetDatasetInputConfigFactory InputConfigFactory { get; set; }

    protected override Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset Create()
    {
        var datasetResult = CreateDataset();
        factoryAction?.Invoke(datasetResult);

        return datasetResult;
    }

    private Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset CreateDataset()
    {
        var datasetResult = new Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset();

        return datasetResult;
    }
    public override void CreateChildren(Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset result)
    {
        base.CreateChildren(result);

        result.InputConfig ??= InputConfigFactory?.Build();
    }

} // End Of Class

public static class InnerTrainingDatasetDatasetFactoryExtensions
{
    public static CombinedResult<InnerTrainingDatasetDatasetFactory, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig(this InnerTrainingDatasetDatasetFactory parentFactory, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null)
    {
        parentFactory.InputConfigFactory = new InnerTrainingDatasetDatasetInputConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputConfigFactory);
    }

    public static CombinedResult<InnerTrainingDatasetDatasetFactory, T1, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1>(this CombinedResult<InnerTrainingDatasetDatasetFactory, T1> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDatasetFactory, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1>(this CombinedResult<T1, InnerTrainingDatasetDatasetFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTrainingDatasetDatasetFactory, T1, T2, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2>(this CombinedResult<InnerTrainingDatasetDatasetFactory, T1, T2> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDatasetFactory, T2, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2>(this CombinedResult<T1, InnerTrainingDatasetDatasetFactory, T2> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrainingDatasetDatasetFactory, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2>(this CombinedResult<T1, T2, InnerTrainingDatasetDatasetFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTrainingDatasetDatasetFactory, T1, T2, T3, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2, T3>(this CombinedResult<InnerTrainingDatasetDatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDatasetFactory, T2, T3, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2, T3>(this CombinedResult<T1, InnerTrainingDatasetDatasetFactory, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrainingDatasetDatasetFactory, T3, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrainingDatasetDatasetFactory, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTrainingDatasetDatasetFactory, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrainingDatasetDatasetFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTrainingDatasetDatasetFactory, T1, T2, T3, T4, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2, T3, T4>(this CombinedResult<InnerTrainingDatasetDatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTrainingDatasetDatasetFactory, T2, T3, T4, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrainingDatasetDatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTrainingDatasetDatasetFactory, T3, T4, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrainingDatasetDatasetFactory, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTrainingDatasetDatasetFactory, T4, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrainingDatasetDatasetFactory, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTrainingDatasetDatasetFactory, InnerTrainingDatasetDatasetInputConfigFactory> WithInputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrainingDatasetDatasetFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputConfig(combinedResult.T5, subFactoryAction));
}
