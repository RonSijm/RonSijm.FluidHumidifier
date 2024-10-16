// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetGlueConfigurationFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration>
{

    protected override Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration Create()
    {
        var glueConfigurationResult = CreateGlueConfiguration();
        factoryAction?.Invoke(glueConfigurationResult);

        return glueConfigurationResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration CreateGlueConfiguration()
    {
        var glueConfigurationResult = new Humidifier.IoTAnalytics.DatasetTypes.GlueConfiguration();

        return glueConfigurationResult;
    }

} // End Of Class

public static class InnerDatasetGlueConfigurationFactoryExtensions
{
}
