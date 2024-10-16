// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectProjectCacheFactory(Action<Humidifier.CodeBuild.ProjectTypes.ProjectCache> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.ProjectCache>
{

    protected override Humidifier.CodeBuild.ProjectTypes.ProjectCache Create()
    {
        var projectCacheResult = CreateProjectCache();
        factoryAction?.Invoke(projectCacheResult);

        return projectCacheResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.ProjectCache CreateProjectCache()
    {
        var projectCacheResult = new Humidifier.CodeBuild.ProjectTypes.ProjectCache();

        return projectCacheResult;
    }

} // End Of Class

public static class InnerProjectProjectCacheFactoryExtensions
{
}
