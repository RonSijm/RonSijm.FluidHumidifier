// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupCloudWatchLoggingConfigurationFactory(Action<Humidifier.Athena.WorkGroupTypes.CloudWatchLoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.CloudWatchLoggingConfiguration>
{

    protected override Humidifier.Athena.WorkGroupTypes.CloudWatchLoggingConfiguration Create()
    {
        var cloudWatchLoggingConfigurationResult = CreateCloudWatchLoggingConfiguration();
        factoryAction?.Invoke(cloudWatchLoggingConfigurationResult);

        return cloudWatchLoggingConfigurationResult;
    }

    private Humidifier.Athena.WorkGroupTypes.CloudWatchLoggingConfiguration CreateCloudWatchLoggingConfiguration()
    {
        var cloudWatchLoggingConfigurationResult = new Humidifier.Athena.WorkGroupTypes.CloudWatchLoggingConfiguration();

        return cloudWatchLoggingConfigurationResult;
    }

} // End Of Class

public static class InnerWorkGroupCloudWatchLoggingConfigurationFactoryExtensions
{
}
