// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerConfiguredModelAlgorithmAssociationTrainedModelArtifactMaxSizeFactory(Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelArtifactMaxSize> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelArtifactMaxSize>
{

    protected override Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelArtifactMaxSize Create()
    {
        var trainedModelArtifactMaxSizeResult = CreateTrainedModelArtifactMaxSize();
        factoryAction?.Invoke(trainedModelArtifactMaxSizeResult);

        return trainedModelArtifactMaxSizeResult;
    }

    private Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelArtifactMaxSize CreateTrainedModelArtifactMaxSize()
    {
        var trainedModelArtifactMaxSizeResult = new Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelArtifactMaxSize();

        return trainedModelArtifactMaxSizeResult;
    }

} // End Of Class

public static class InnerConfiguredModelAlgorithmAssociationTrainedModelArtifactMaxSizeFactoryExtensions
{
}
