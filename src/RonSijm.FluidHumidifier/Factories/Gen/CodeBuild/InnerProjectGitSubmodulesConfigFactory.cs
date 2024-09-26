// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectGitSubmodulesConfigFactory(Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig>
{

    protected override Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig Create()
    {
        var gitSubmodulesConfigResult = CreateGitSubmodulesConfig();
        factoryAction?.Invoke(gitSubmodulesConfigResult);

        return gitSubmodulesConfigResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig CreateGitSubmodulesConfig()
    {
        var gitSubmodulesConfigResult = new Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig();

        return gitSubmodulesConfigResult;
    }

} // End Of Class

public static class InnerProjectGitSubmodulesConfigFactoryExtensions
{
}
