// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class TrainingDatasetFactory(string resourceName = null, Action<Humidifier.CleanRoomsML.TrainingDataset> factoryAction = null) : ResourceFactory<Humidifier.CleanRoomsML.TrainingDataset>(resourceName)
{

    internal List<InnerTrainingDatasetDatasetFactory> TrainingDataFactories { get; set; } = [];

    protected override Humidifier.CleanRoomsML.TrainingDataset Create()
    {
        var trainingDatasetResult = CreateTrainingDataset();
        factoryAction?.Invoke(trainingDatasetResult);

        return trainingDatasetResult;
    }

    private Humidifier.CleanRoomsML.TrainingDataset CreateTrainingDataset()
    {
        var trainingDatasetResult = new Humidifier.CleanRoomsML.TrainingDataset
        {
            GivenName = InputResourceName,
        };

        return trainingDatasetResult;
    }
    public override void CreateChildren(Humidifier.CleanRoomsML.TrainingDataset result)
    {
        base.CreateChildren(result);

        result.TrainingData = TrainingDataFactories.Any() ? TrainingDataFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TrainingDatasetFactoryExtensions
{
    public static CombinedResult<TrainingDatasetFactory, InnerTrainingDatasetDatasetFactory> WithTrainingData(this TrainingDatasetFactory parentFactory, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null)
    {
        var factory = new InnerTrainingDatasetDatasetFactory(subFactoryAction);
        parentFactory.TrainingDataFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TrainingDatasetFactory, T1, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1>(this CombinedResult<TrainingDatasetFactory, T1> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrainingDatasetFactory, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1>(this CombinedResult<T1, TrainingDatasetFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TrainingDatasetFactory, T1, T2, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2>(this CombinedResult<TrainingDatasetFactory, T1, T2> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrainingDatasetFactory, T2, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2>(this CombinedResult<T1, TrainingDatasetFactory, T2> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrainingDatasetFactory, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2>(this CombinedResult<T1, T2, TrainingDatasetFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TrainingDatasetFactory, T1, T2, T3, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2, T3>(this CombinedResult<TrainingDatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrainingDatasetFactory, T2, T3, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2, T3>(this CombinedResult<T1, TrainingDatasetFactory, T2, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrainingDatasetFactory, T3, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2, T3>(this CombinedResult<T1, T2, TrainingDatasetFactory, T3> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrainingDatasetFactory, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrainingDatasetFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TrainingDatasetFactory, T1, T2, T3, T4, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2, T3, T4>(this CombinedResult<TrainingDatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrainingDatasetFactory, T2, T3, T4, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2, T3, T4>(this CombinedResult<T1, TrainingDatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrainingDatasetFactory, T3, T4, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrainingDatasetFactory, T3, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrainingDatasetFactory, T4, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrainingDatasetFactory, T4> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TrainingDatasetFactory, InnerTrainingDatasetDatasetFactory> WithTrainingData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrainingDatasetFactory> combinedResult, Action<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingData(combinedResult.T5, subFactoryAction));
}
