// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerWorkspaceWorkspacePageFactory(Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> factoryAction = null) : SubResourceFactory<Humidifier.Connect.WorkspaceTypes.WorkspacePage>
{

    protected override Humidifier.Connect.WorkspaceTypes.WorkspacePage Create()
    {
        var workspacePageResult = CreateWorkspacePage();
        factoryAction?.Invoke(workspacePageResult);

        return workspacePageResult;
    }

    private Humidifier.Connect.WorkspaceTypes.WorkspacePage CreateWorkspacePage()
    {
        var workspacePageResult = new Humidifier.Connect.WorkspaceTypes.WorkspacePage();

        return workspacePageResult;
    }

} // End Of Class

public static class InnerWorkspaceWorkspacePageFactoryExtensions
{
}
