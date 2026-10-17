// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class TrainedModelFactory(string resourceName = null, Action<Humidifier.CleanRoomsML.TrainedModel> factoryAction = null) : ResourceFactory<Humidifier.CleanRoomsML.TrainedModel>(resourceName)
{

    protected override Humidifier.CleanRoomsML.TrainedModel Create()
    {
        var trainedModelResult = CreateTrainedModel();
        factoryAction?.Invoke(trainedModelResult);

        return trainedModelResult;
    }

    private Humidifier.CleanRoomsML.TrainedModel CreateTrainedModel()
    {
        var trainedModelResult = new Humidifier.CleanRoomsML.TrainedModel
        {
            GivenName = InputResourceName,
        };

        return trainedModelResult;
    }

} // End Of Class

public static class TrainedModelFactoryExtensions
{
}
