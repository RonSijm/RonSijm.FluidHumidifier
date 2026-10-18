// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class DatasetGroupFactory(string resourceName = null, Action<Humidifier.Personalize.DatasetGroup> factoryAction = null) : ResourceFactory<Humidifier.Personalize.DatasetGroup>(resourceName)
{

    protected override Humidifier.Personalize.DatasetGroup Create()
    {
        var datasetGroupResult = CreateDatasetGroup();
        factoryAction?.Invoke(datasetGroupResult);

        return datasetGroupResult;
    }

    private Humidifier.Personalize.DatasetGroup CreateDatasetGroup()
    {
        var datasetGroupResult = new Humidifier.Personalize.DatasetGroup
        {
            GivenName = InputResourceName,
        };

        return datasetGroupResult;
    }

} // End Of Class

public static class DatasetGroupFactoryExtensions
{
}
