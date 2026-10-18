// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectBuildStatusConfigFactory(Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig>
{

    protected override Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig Create()
    {
        var buildStatusConfigResult = CreateBuildStatusConfig();
        factoryAction?.Invoke(buildStatusConfigResult);

        return buildStatusConfigResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig CreateBuildStatusConfig()
    {
        var buildStatusConfigResult = new Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig();

        return buildStatusConfigResult;
    }

} // End Of Class

public static class InnerProjectBuildStatusConfigFactoryExtensions
{
}
