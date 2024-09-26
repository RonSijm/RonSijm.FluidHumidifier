// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerWorkspaceWorkspacePropertiesFactory(Action<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties>
{

    protected override Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties Create()
    {
        var workspacePropertiesResult = CreateWorkspaceProperties();
        factoryAction?.Invoke(workspacePropertiesResult);

        return workspacePropertiesResult;
    }

    private Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties CreateWorkspaceProperties()
    {
        var workspacePropertiesResult = new Humidifier.WorkSpaces.WorkspaceTypes.WorkspaceProperties();

        return workspacePropertiesResult;
    }

} // End Of Class

public static class InnerWorkspaceWorkspacePropertiesFactoryExtensions
{
}
