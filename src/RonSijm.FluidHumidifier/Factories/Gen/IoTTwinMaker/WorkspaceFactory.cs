// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTTwinMaker;

public class WorkspaceFactory(string resourceName = null, Action<Humidifier.IoTTwinMaker.Workspace> factoryAction = null) : ResourceFactory<Humidifier.IoTTwinMaker.Workspace>(resourceName)
{

    protected override Humidifier.IoTTwinMaker.Workspace Create()
    {
        var workspaceResult = CreateWorkspace();
        factoryAction?.Invoke(workspaceResult);

        return workspaceResult;
    }

    private Humidifier.IoTTwinMaker.Workspace CreateWorkspace()
    {
        var workspaceResult = new Humidifier.IoTTwinMaker.Workspace
        {
            GivenName = InputResourceName,
        };

        return workspaceResult;
    }

} // End Of Class

public static class WorkspaceFactoryExtensions
{
}
