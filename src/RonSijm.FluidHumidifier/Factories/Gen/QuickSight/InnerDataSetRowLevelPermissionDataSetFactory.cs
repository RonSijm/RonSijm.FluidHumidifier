// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetRowLevelPermissionDataSetFactory(Action<Humidifier.QuickSight.DataSetTypes.RowLevelPermissionDataSet> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.RowLevelPermissionDataSet>
{

    protected override Humidifier.QuickSight.DataSetTypes.RowLevelPermissionDataSet Create()
    {
        var rowLevelPermissionDataSetResult = CreateRowLevelPermissionDataSet();
        factoryAction?.Invoke(rowLevelPermissionDataSetResult);

        return rowLevelPermissionDataSetResult;
    }

    private Humidifier.QuickSight.DataSetTypes.RowLevelPermissionDataSet CreateRowLevelPermissionDataSet()
    {
        var rowLevelPermissionDataSetResult = new Humidifier.QuickSight.DataSetTypes.RowLevelPermissionDataSet();

        return rowLevelPermissionDataSetResult;
    }

} // End Of Class

public static class InnerDataSetRowLevelPermissionDataSetFactoryExtensions
{
}
