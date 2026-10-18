// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerWorkspaceLoggingConfigurationFactory(Action<Humidifier.APS.WorkspaceTypes.LoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.WorkspaceTypes.LoggingConfiguration>
{

    protected override Humidifier.APS.WorkspaceTypes.LoggingConfiguration Create()
    {
        var loggingConfigurationResult = CreateLoggingConfiguration();
        factoryAction?.Invoke(loggingConfigurationResult);

        return loggingConfigurationResult;
    }

    private Humidifier.APS.WorkspaceTypes.LoggingConfiguration CreateLoggingConfiguration()
    {
        var loggingConfigurationResult = new Humidifier.APS.WorkspaceTypes.LoggingConfiguration();

        return loggingConfigurationResult;
    }

} // End Of Class

public static class InnerWorkspaceLoggingConfigurationFactoryExtensions
{
}
