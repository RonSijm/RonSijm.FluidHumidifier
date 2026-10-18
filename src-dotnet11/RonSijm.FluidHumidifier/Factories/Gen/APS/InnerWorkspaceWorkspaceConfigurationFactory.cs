// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerWorkspaceWorkspaceConfigurationFactory(Action<Humidifier.APS.WorkspaceTypes.WorkspaceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.WorkspaceTypes.WorkspaceConfiguration>
{

    protected override Humidifier.APS.WorkspaceTypes.WorkspaceConfiguration Create()
    {
        var workspaceConfigurationResult = CreateWorkspaceConfiguration();
        factoryAction?.Invoke(workspaceConfigurationResult);

        return workspaceConfigurationResult;
    }

    private Humidifier.APS.WorkspaceTypes.WorkspaceConfiguration CreateWorkspaceConfiguration()
    {
        var workspaceConfigurationResult = new Humidifier.APS.WorkspaceTypes.WorkspaceConfiguration();

        return workspaceConfigurationResult;
    }

} // End Of Class

public static class InnerWorkspaceWorkspaceConfigurationFactoryExtensions
{
}
