// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Forecast;

public class DatasetGroupFactory(string resourceName = null, Action<Humidifier.Forecast.DatasetGroup> factoryAction = null) : ResourceFactory<Humidifier.Forecast.DatasetGroup>(resourceName)
{

    protected override Humidifier.Forecast.DatasetGroup Create()
    {
        var datasetGroupResult = CreateDatasetGroup();
        factoryAction?.Invoke(datasetGroupResult);

        return datasetGroupResult;
    }

    private Humidifier.Forecast.DatasetGroup CreateDatasetGroup()
    {
        var datasetGroupResult = new Humidifier.Forecast.DatasetGroup
        {
            GivenName = InputResourceName,
        };

        return datasetGroupResult;
    }

} // End Of Class

public static class DatasetGroupFactoryExtensions
{
}
