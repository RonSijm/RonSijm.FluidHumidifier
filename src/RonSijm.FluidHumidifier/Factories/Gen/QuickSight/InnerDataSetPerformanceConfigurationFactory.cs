// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetPerformanceConfigurationFactory(Action<Humidifier.QuickSight.DataSetTypes.PerformanceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.PerformanceConfiguration>
{

    protected override Humidifier.QuickSight.DataSetTypes.PerformanceConfiguration Create()
    {
        var performanceConfigurationResult = CreatePerformanceConfiguration();
        factoryAction?.Invoke(performanceConfigurationResult);

        return performanceConfigurationResult;
    }

    private Humidifier.QuickSight.DataSetTypes.PerformanceConfiguration CreatePerformanceConfiguration()
    {
        var performanceConfigurationResult = new Humidifier.QuickSight.DataSetTypes.PerformanceConfiguration();

        return performanceConfigurationResult;
    }

} // End Of Class

public static class InnerDataSetPerformanceConfigurationFactoryExtensions
{
}
