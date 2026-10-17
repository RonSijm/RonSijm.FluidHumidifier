// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerTrainedModelInferenceJobModelInferenceDataSourceFactory(Action<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.ModelInferenceDataSource> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.ModelInferenceDataSource>
{

    protected override Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.ModelInferenceDataSource Create()
    {
        var modelInferenceDataSourceResult = CreateModelInferenceDataSource();
        factoryAction?.Invoke(modelInferenceDataSourceResult);

        return modelInferenceDataSourceResult;
    }

    private Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.ModelInferenceDataSource CreateModelInferenceDataSource()
    {
        var modelInferenceDataSourceResult = new Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.ModelInferenceDataSource();

        return modelInferenceDataSourceResult;
    }

} // End Of Class

public static class InnerTrainedModelInferenceJobModelInferenceDataSourceFactoryExtensions
{
}
