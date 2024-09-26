// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerDataQualityRulesetDataQualityTargetTableFactory(Action<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable> factoryAction = null) : SubResourceFactory<Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable>
{

    protected override Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable Create()
    {
        var dataQualityTargetTableResult = CreateDataQualityTargetTable();
        factoryAction?.Invoke(dataQualityTargetTableResult);

        return dataQualityTargetTableResult;
    }

    private Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable CreateDataQualityTargetTable()
    {
        var dataQualityTargetTableResult = new Humidifier.Glue.DataQualityRulesetTypes.DataQualityTargetTable();

        return dataQualityTargetTableResult;
    }

} // End Of Class

public static class InnerDataQualityRulesetDataQualityTargetTableFactoryExtensions
{
}
