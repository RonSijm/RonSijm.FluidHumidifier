// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectCloudWatchLogsConfigFactory(Action<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig>
{

    protected override Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig Create()
    {
        var cloudWatchLogsConfigResult = CreateCloudWatchLogsConfig();
        factoryAction?.Invoke(cloudWatchLogsConfigResult);

        return cloudWatchLogsConfigResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig CreateCloudWatchLogsConfig()
    {
        var cloudWatchLogsConfigResult = new Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig();

        return cloudWatchLogsConfigResult;
    }

} // End Of Class

public static class InnerProjectCloudWatchLogsConfigFactoryExtensions
{
}
