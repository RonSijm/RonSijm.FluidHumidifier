// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerConfiguredModelAlgorithmAssociationTrainedModelInferenceMaxOutputSizeFactory(Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelInferenceMaxOutputSize> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelInferenceMaxOutputSize>
{

    protected override Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelInferenceMaxOutputSize Create()
    {
        var trainedModelInferenceMaxOutputSizeResult = CreateTrainedModelInferenceMaxOutputSize();
        factoryAction?.Invoke(trainedModelInferenceMaxOutputSizeResult);

        return trainedModelInferenceMaxOutputSizeResult;
    }

    private Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelInferenceMaxOutputSize CreateTrainedModelInferenceMaxOutputSize()
    {
        var trainedModelInferenceMaxOutputSizeResult = new Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelInferenceMaxOutputSize();

        return trainedModelInferenceMaxOutputSizeResult;
    }

} // End Of Class

public static class InnerConfiguredModelAlgorithmAssociationTrainedModelInferenceMaxOutputSizeFactoryExtensions
{
}
