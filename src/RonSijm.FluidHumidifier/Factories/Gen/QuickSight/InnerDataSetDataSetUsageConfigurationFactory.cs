// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetDataSetUsageConfigurationFactory(Action<Humidifier.QuickSight.DataSetTypes.DataSetUsageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.DataSetUsageConfiguration>
{

    protected override Humidifier.QuickSight.DataSetTypes.DataSetUsageConfiguration Create()
    {
        var dataSetUsageConfigurationResult = CreateDataSetUsageConfiguration();
        factoryAction?.Invoke(dataSetUsageConfigurationResult);

        return dataSetUsageConfigurationResult;
    }

    private Humidifier.QuickSight.DataSetTypes.DataSetUsageConfiguration CreateDataSetUsageConfiguration()
    {
        var dataSetUsageConfigurationResult = new Humidifier.QuickSight.DataSetTypes.DataSetUsageConfiguration();

        return dataSetUsageConfigurationResult;
    }

} // End Of Class

public static class InnerDataSetDataSetUsageConfigurationFactoryExtensions
{
}
