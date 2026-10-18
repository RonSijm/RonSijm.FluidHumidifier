// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerConfiguredModelAlgorithmInferenceContainerConfigFactory(Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.InferenceContainerConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.InferenceContainerConfig>
{

    protected override Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.InferenceContainerConfig Create()
    {
        var inferenceContainerConfigResult = CreateInferenceContainerConfig();
        factoryAction?.Invoke(inferenceContainerConfigResult);

        return inferenceContainerConfigResult;
    }

    private Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.InferenceContainerConfig CreateInferenceContainerConfig()
    {
        var inferenceContainerConfigResult = new Humidifier.CleanRoomsML.ConfiguredModelAlgorithmTypes.InferenceContainerConfig();

        return inferenceContainerConfigResult;
    }

} // End Of Class

public static class InnerConfiguredModelAlgorithmInferenceContainerConfigFactoryExtensions
{
}
