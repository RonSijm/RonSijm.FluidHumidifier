// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationFlinkRunConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.FlinkRunConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.FlinkRunConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.FlinkRunConfiguration Create()
    {
        var flinkRunConfigurationResult = CreateFlinkRunConfiguration();
        factoryAction?.Invoke(flinkRunConfigurationResult);

        return flinkRunConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.FlinkRunConfiguration CreateFlinkRunConfiguration()
    {
        var flinkRunConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.FlinkRunConfiguration();

        return flinkRunConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationFlinkRunConfigurationFactoryExtensions
{
}
