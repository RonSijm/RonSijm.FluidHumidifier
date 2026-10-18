// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CognitoSync;

public class DatasetFactory(string resourceName = null, Action<Humidifier.CognitoSync.Dataset> factoryAction = null) : ResourceFactory<Humidifier.CognitoSync.Dataset>(resourceName)
{

    protected override Humidifier.CognitoSync.Dataset Create()
    {
        var datasetResult = CreateDataset();
        factoryAction?.Invoke(datasetResult);

        return datasetResult;
    }

    private Humidifier.CognitoSync.Dataset CreateDataset()
    {
        var datasetResult = new Humidifier.CognitoSync.Dataset
        {
            GivenName = InputResourceName,
        };

        return datasetResult;
    }

} // End Of Class

public static class DatasetFactoryExtensions
{
}
