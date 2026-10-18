// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetDataPrepConfigurationFactory(Action<Humidifier.QuickSight.DataSetTypes.DataPrepConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.DataPrepConfiguration>
{

    protected override Humidifier.QuickSight.DataSetTypes.DataPrepConfiguration Create()
    {
        var dataPrepConfigurationResult = CreateDataPrepConfiguration();
        factoryAction?.Invoke(dataPrepConfigurationResult);

        return dataPrepConfigurationResult;
    }

    private Humidifier.QuickSight.DataSetTypes.DataPrepConfiguration CreateDataPrepConfiguration()
    {
        var dataPrepConfigurationResult = new Humidifier.QuickSight.DataSetTypes.DataPrepConfiguration();

        return dataPrepConfigurationResult;
    }

} // End Of Class

public static class InnerDataSetDataPrepConfigurationFactoryExtensions
{
}
