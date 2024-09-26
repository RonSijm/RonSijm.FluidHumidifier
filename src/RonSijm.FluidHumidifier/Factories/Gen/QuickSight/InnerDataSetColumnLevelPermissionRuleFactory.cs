// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetColumnLevelPermissionRuleFactory(Action<Humidifier.QuickSight.DataSetTypes.ColumnLevelPermissionRule> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.ColumnLevelPermissionRule>
{

    protected override Humidifier.QuickSight.DataSetTypes.ColumnLevelPermissionRule Create()
    {
        var columnLevelPermissionRuleResult = CreateColumnLevelPermissionRule();
        factoryAction?.Invoke(columnLevelPermissionRuleResult);

        return columnLevelPermissionRuleResult;
    }

    private Humidifier.QuickSight.DataSetTypes.ColumnLevelPermissionRule CreateColumnLevelPermissionRule()
    {
        var columnLevelPermissionRuleResult = new Humidifier.QuickSight.DataSetTypes.ColumnLevelPermissionRule();

        return columnLevelPermissionRuleResult;
    }

} // End Of Class

public static class InnerDataSetColumnLevelPermissionRuleFactoryExtensions
{
}
