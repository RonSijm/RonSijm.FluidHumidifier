// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerDirectoryDefaultWorkspaceCreationPropertiesFactory(Action<Humidifier.WorkSpaces.DirectoryTypes.DefaultWorkspaceCreationProperties> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.DirectoryTypes.DefaultWorkspaceCreationProperties>
{

    protected override Humidifier.WorkSpaces.DirectoryTypes.DefaultWorkspaceCreationProperties Create()
    {
        var defaultWorkspaceCreationPropertiesResult = CreateDefaultWorkspaceCreationProperties();
        factoryAction?.Invoke(defaultWorkspaceCreationPropertiesResult);

        return defaultWorkspaceCreationPropertiesResult;
    }

    private Humidifier.WorkSpaces.DirectoryTypes.DefaultWorkspaceCreationProperties CreateDefaultWorkspaceCreationProperties()
    {
        var defaultWorkspaceCreationPropertiesResult = new Humidifier.WorkSpaces.DirectoryTypes.DefaultWorkspaceCreationProperties();

        return defaultWorkspaceCreationPropertiesResult;
    }

} // End Of Class

public static class InnerDirectoryDefaultWorkspaceCreationPropertiesFactoryExtensions
{
}
