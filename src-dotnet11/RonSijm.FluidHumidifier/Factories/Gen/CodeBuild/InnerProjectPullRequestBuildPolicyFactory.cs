// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectPullRequestBuildPolicyFactory(Action<Humidifier.CodeBuild.ProjectTypes.PullRequestBuildPolicy> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.PullRequestBuildPolicy>
{

    protected override Humidifier.CodeBuild.ProjectTypes.PullRequestBuildPolicy Create()
    {
        var pullRequestBuildPolicyResult = CreatePullRequestBuildPolicy();
        factoryAction?.Invoke(pullRequestBuildPolicyResult);

        return pullRequestBuildPolicyResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.PullRequestBuildPolicy CreatePullRequestBuildPolicy()
    {
        var pullRequestBuildPolicyResult = new Humidifier.CodeBuild.ProjectTypes.PullRequestBuildPolicy();

        return pullRequestBuildPolicyResult;
    }

} // End Of Class

public static class InnerProjectPullRequestBuildPolicyFactoryExtensions
{
}
