// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class InnerCloudVmClusterDataCollectionOptionsFactory(Action<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions> factoryAction = null) : SubResourceFactory<Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions>
{

    protected override Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions Create()
    {
        var dataCollectionOptionsResult = CreateDataCollectionOptions();
        factoryAction?.Invoke(dataCollectionOptionsResult);

        return dataCollectionOptionsResult;
    }

    private Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions CreateDataCollectionOptions()
    {
        var dataCollectionOptionsResult = new Humidifier.ODB.CloudVmClusterTypes.DataCollectionOptions();

        return dataCollectionOptionsResult;
    }

} // End Of Class

public static class InnerCloudVmClusterDataCollectionOptionsFactoryExtensions
{
}
