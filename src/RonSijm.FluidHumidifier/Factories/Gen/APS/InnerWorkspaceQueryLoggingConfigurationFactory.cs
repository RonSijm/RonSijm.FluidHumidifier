// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerWorkspaceQueryLoggingConfigurationFactory(Action<Humidifier.APS.WorkspaceTypes.QueryLoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.WorkspaceTypes.QueryLoggingConfiguration>
{

    protected override Humidifier.APS.WorkspaceTypes.QueryLoggingConfiguration Create()
    {
        var queryLoggingConfigurationResult = CreateQueryLoggingConfiguration();
        factoryAction?.Invoke(queryLoggingConfigurationResult);

        return queryLoggingConfigurationResult;
    }

    private Humidifier.APS.WorkspaceTypes.QueryLoggingConfiguration CreateQueryLoggingConfiguration()
    {
        var queryLoggingConfigurationResult = new Humidifier.APS.WorkspaceTypes.QueryLoggingConfiguration();

        return queryLoggingConfigurationResult;
    }

} // End Of Class

public static class InnerWorkspaceQueryLoggingConfigurationFactoryExtensions
{
}
