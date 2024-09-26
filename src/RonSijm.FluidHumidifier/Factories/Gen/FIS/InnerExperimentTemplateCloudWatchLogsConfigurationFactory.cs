// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class InnerExperimentTemplateCloudWatchLogsConfigurationFactory(Action<Humidifier.FIS.ExperimentTemplateTypes.CloudWatchLogsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FIS.ExperimentTemplateTypes.CloudWatchLogsConfiguration>
{

    protected override Humidifier.FIS.ExperimentTemplateTypes.CloudWatchLogsConfiguration Create()
    {
        var cloudWatchLogsConfigurationResult = CreateCloudWatchLogsConfiguration();
        factoryAction?.Invoke(cloudWatchLogsConfigurationResult);

        return cloudWatchLogsConfigurationResult;
    }

    private Humidifier.FIS.ExperimentTemplateTypes.CloudWatchLogsConfiguration CreateCloudWatchLogsConfiguration()
    {
        var cloudWatchLogsConfigurationResult = new Humidifier.FIS.ExperimentTemplateTypes.CloudWatchLogsConfiguration();

        return cloudWatchLogsConfigurationResult;
    }

} // End Of Class

public static class InnerExperimentTemplateCloudWatchLogsConfigurationFactoryExtensions
{
}
