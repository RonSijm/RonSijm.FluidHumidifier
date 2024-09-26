// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceSnowflakeParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters Create()
    {
        var snowflakeParametersResult = CreateSnowflakeParameters();
        factoryAction?.Invoke(snowflakeParametersResult);

        return snowflakeParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters CreateSnowflakeParameters()
    {
        var snowflakeParametersResult = new Humidifier.QuickSight.DataSourceTypes.SnowflakeParameters();

        return snowflakeParametersResult;
    }

} // End Of Class

public static class InnerDataSourceSnowflakeParametersFactoryExtensions
{
}
