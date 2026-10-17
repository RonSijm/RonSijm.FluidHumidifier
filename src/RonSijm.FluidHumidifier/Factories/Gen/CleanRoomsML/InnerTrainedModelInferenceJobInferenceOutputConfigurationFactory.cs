// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerTrainedModelInferenceJobInferenceOutputConfigurationFactory(Action<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceOutputConfiguration>
{

    protected override Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceOutputConfiguration Create()
    {
        var inferenceOutputConfigurationResult = CreateInferenceOutputConfiguration();
        factoryAction?.Invoke(inferenceOutputConfigurationResult);

        return inferenceOutputConfigurationResult;
    }

    private Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceOutputConfiguration CreateInferenceOutputConfiguration()
    {
        var inferenceOutputConfigurationResult = new Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceOutputConfiguration();

        return inferenceOutputConfigurationResult;
    }

} // End Of Class

public static class InnerTrainedModelInferenceJobInferenceOutputConfigurationFactoryExtensions
{
}
