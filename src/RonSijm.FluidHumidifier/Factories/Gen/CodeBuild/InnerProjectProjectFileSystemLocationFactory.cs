// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectProjectFileSystemLocationFactory(Action<Humidifier.CodeBuild.ProjectTypes.ProjectFileSystemLocation> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.ProjectFileSystemLocation>
{

    protected override Humidifier.CodeBuild.ProjectTypes.ProjectFileSystemLocation Create()
    {
        var projectFileSystemLocationResult = CreateProjectFileSystemLocation();
        factoryAction?.Invoke(projectFileSystemLocationResult);

        return projectFileSystemLocationResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.ProjectFileSystemLocation CreateProjectFileSystemLocation()
    {
        var projectFileSystemLocationResult = new Humidifier.CodeBuild.ProjectTypes.ProjectFileSystemLocation();

        return projectFileSystemLocationResult;
    }

} // End Of Class

public static class InnerProjectProjectFileSystemLocationFactoryExtensions
{
}
