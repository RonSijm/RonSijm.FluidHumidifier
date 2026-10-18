// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerSessionSessionCloudWatchLoggingConfigurationFactory(Action<Humidifier.EMR.SessionTypes.SessionCloudWatchLoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMR.SessionTypes.SessionCloudWatchLoggingConfiguration>
{

    protected override Humidifier.EMR.SessionTypes.SessionCloudWatchLoggingConfiguration Create()
    {
        var sessionCloudWatchLoggingConfigurationResult = CreateSessionCloudWatchLoggingConfiguration();
        factoryAction?.Invoke(sessionCloudWatchLoggingConfigurationResult);

        return sessionCloudWatchLoggingConfigurationResult;
    }

    private Humidifier.EMR.SessionTypes.SessionCloudWatchLoggingConfiguration CreateSessionCloudWatchLoggingConfiguration()
    {
        var sessionCloudWatchLoggingConfigurationResult = new Humidifier.EMR.SessionTypes.SessionCloudWatchLoggingConfiguration();

        return sessionCloudWatchLoggingConfigurationResult;
    }

} // End Of Class

public static class InnerSessionSessionCloudWatchLoggingConfigurationFactoryExtensions
{
}
