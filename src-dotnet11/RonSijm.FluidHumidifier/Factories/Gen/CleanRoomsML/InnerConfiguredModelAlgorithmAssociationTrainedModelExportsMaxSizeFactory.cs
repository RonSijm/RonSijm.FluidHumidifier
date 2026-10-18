// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactory(Action<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize> factoryAction = null) : SubResourceFactory<Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize>
{

    protected override Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize Create()
    {
        var trainedModelExportsMaxSizeResult = CreateTrainedModelExportsMaxSize();
        factoryAction?.Invoke(trainedModelExportsMaxSizeResult);

        return trainedModelExportsMaxSizeResult;
    }

    private Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize CreateTrainedModelExportsMaxSize()
    {
        var trainedModelExportsMaxSizeResult = new Humidifier.CleanRoomsML.ConfiguredModelAlgorithmAssociationTypes.TrainedModelExportsMaxSize();

        return trainedModelExportsMaxSizeResult;
    }

} // End Of Class

public static class InnerConfiguredModelAlgorithmAssociationTrainedModelExportsMaxSizeFactoryExtensions
{
}
