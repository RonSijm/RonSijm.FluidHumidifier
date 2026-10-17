// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class DatasetFactory(string resourceName = null, Action<Humidifier.Rekognition.Dataset> factoryAction = null) : ResourceFactory<Humidifier.Rekognition.Dataset>(resourceName)
{

    protected override Humidifier.Rekognition.Dataset Create()
    {
        var datasetResult = CreateDataset();
        factoryAction?.Invoke(datasetResult);

        return datasetResult;
    }

    private Humidifier.Rekognition.Dataset CreateDataset()
    {
        var datasetResult = new Humidifier.Rekognition.Dataset
        {
            GivenName = InputResourceName,
        };

        return datasetResult;
    }

} // End Of Class

public static class DatasetFactoryExtensions
{
}
