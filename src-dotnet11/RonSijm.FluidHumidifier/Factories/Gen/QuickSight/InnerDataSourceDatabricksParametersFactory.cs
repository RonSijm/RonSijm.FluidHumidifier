// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceDatabricksParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.DatabricksParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.DatabricksParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.DatabricksParameters Create()
    {
        var databricksParametersResult = CreateDatabricksParameters();
        factoryAction?.Invoke(databricksParametersResult);

        return databricksParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.DatabricksParameters CreateDatabricksParameters()
    {
        var databricksParametersResult = new Humidifier.QuickSight.DataSourceTypes.DatabricksParameters();

        return databricksParametersResult;
    }

} // End Of Class

public static class InnerDataSourceDatabricksParametersFactoryExtensions
{
}
