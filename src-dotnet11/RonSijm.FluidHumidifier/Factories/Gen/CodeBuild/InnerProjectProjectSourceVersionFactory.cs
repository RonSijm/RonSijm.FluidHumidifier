// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectProjectSourceVersionFactory(Action<Humidifier.CodeBuild.ProjectTypes.ProjectSourceVersion> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.ProjectSourceVersion>
{

    protected override Humidifier.CodeBuild.ProjectTypes.ProjectSourceVersion Create()
    {
        var projectSourceVersionResult = CreateProjectSourceVersion();
        factoryAction?.Invoke(projectSourceVersionResult);

        return projectSourceVersionResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.ProjectSourceVersion CreateProjectSourceVersion()
    {
        var projectSourceVersionResult = new Humidifier.CodeBuild.ProjectTypes.ProjectSourceVersion();

        return projectSourceVersionResult;
    }

} // End Of Class

public static class InnerProjectProjectSourceVersionFactoryExtensions
{
}
