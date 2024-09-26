// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetRowLevelPermissionTagConfigurationFactory(Action<Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagConfiguration>
{

    protected override Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagConfiguration Create()
    {
        var rowLevelPermissionTagConfigurationResult = CreateRowLevelPermissionTagConfiguration();
        factoryAction?.Invoke(rowLevelPermissionTagConfigurationResult);

        return rowLevelPermissionTagConfigurationResult;
    }

    private Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagConfiguration CreateRowLevelPermissionTagConfiguration()
    {
        var rowLevelPermissionTagConfigurationResult = new Humidifier.QuickSight.DataSetTypes.RowLevelPermissionTagConfiguration();

        return rowLevelPermissionTagConfigurationResult;
    }

} // End Of Class

public static class InnerDataSetRowLevelPermissionTagConfigurationFactoryExtensions
{
}
