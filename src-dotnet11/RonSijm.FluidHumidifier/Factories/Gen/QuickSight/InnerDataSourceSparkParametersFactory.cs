// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceSparkParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.SparkParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.SparkParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.SparkParameters Create()
    {
        var sparkParametersResult = CreateSparkParameters();
        factoryAction?.Invoke(sparkParametersResult);

        return sparkParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.SparkParameters CreateSparkParameters()
    {
        var sparkParametersResult = new Humidifier.QuickSight.DataSourceTypes.SparkParameters();

        return sparkParametersResult;
    }

} // End Of Class

public static class InnerDataSourceSparkParametersFactoryExtensions
{
}
