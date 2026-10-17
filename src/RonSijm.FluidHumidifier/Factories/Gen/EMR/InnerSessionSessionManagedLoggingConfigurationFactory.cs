// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerSessionSessionManagedLoggingConfigurationFactory(Action<Humidifier.EMR.SessionTypes.SessionManagedLoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMR.SessionTypes.SessionManagedLoggingConfiguration>
{

    protected override Humidifier.EMR.SessionTypes.SessionManagedLoggingConfiguration Create()
    {
        var sessionManagedLoggingConfigurationResult = CreateSessionManagedLoggingConfiguration();
        factoryAction?.Invoke(sessionManagedLoggingConfigurationResult);

        return sessionManagedLoggingConfigurationResult;
    }

    private Humidifier.EMR.SessionTypes.SessionManagedLoggingConfiguration CreateSessionManagedLoggingConfiguration()
    {
        var sessionManagedLoggingConfigurationResult = new Humidifier.EMR.SessionTypes.SessionManagedLoggingConfiguration();

        return sessionManagedLoggingConfigurationResult;
    }

} // End Of Class

public static class InnerSessionSessionManagedLoggingConfigurationFactoryExtensions
{
}
