// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerTrainedModelInferenceJobInferenceResourceConfigFactory(Action<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceResourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceResourceConfig>
{

    protected override Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceResourceConfig Create()
    {
        var inferenceResourceConfigResult = CreateInferenceResourceConfig();
        factoryAction?.Invoke(inferenceResourceConfigResult);

        return inferenceResourceConfigResult;
    }

    private Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceResourceConfig CreateInferenceResourceConfig()
    {
        var inferenceResourceConfigResult = new Humidifier.CleanRoomsML.TrainedModelInferenceJobTypes.InferenceResourceConfig();

        return inferenceResourceConfigResult;
    }

} // End Of Class

public static class InnerTrainedModelInferenceJobInferenceResourceConfigFactoryExtensions
{
}
