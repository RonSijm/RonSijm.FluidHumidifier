// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupRevisionLocationFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation>
{

    internal InnerDeploymentGroupGitHubLocationFactory GitHubLocationFactory { get; set; }

    internal InnerDeploymentGroupS3LocationFactory S3LocationFactory { get; set; }

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation Create()
    {
        var revisionLocationResult = CreateRevisionLocation();
        factoryAction?.Invoke(revisionLocationResult);

        return revisionLocationResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation CreateRevisionLocation()
    {
        var revisionLocationResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation();

        return revisionLocationResult;
    }
    public override void CreateChildren(Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation result)
    {
        base.CreateChildren(result);

        result.GitHubLocation ??= GitHubLocationFactory?.Build();
        result.S3Location ??= S3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerDeploymentGroupRevisionLocationFactoryExtensions
{
    public static CombinedResult<InnerDeploymentGroupRevisionLocationFactory, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation(this InnerDeploymentGroupRevisionLocationFactory parentFactory, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null)
    {
        parentFactory.GitHubLocationFactory = new InnerDeploymentGroupGitHubLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GitHubLocationFactory);
    }

    public static CombinedResult<InnerDeploymentGroupRevisionLocationFactory, InnerDeploymentGroupS3LocationFactory> WithS3Location(this InnerDeploymentGroupRevisionLocationFactory parentFactory, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.S3LocationFactory = new InnerDeploymentGroupS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LocationFactory);
    }

    public static CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1>(this CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithGitHubLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1>(this CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithGitHubLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2>(this CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2>(this CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2>(this CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2, T3, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2, T3>(this CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2, T3, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2, T3>(this CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory, T3, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentGroupRevisionLocationFactory, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeploymentGroupRevisionLocationFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2, T3, T4, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2, T3, T4>(this CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2, T3, T4, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory, T3, T4, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentGroupRevisionLocationFactory, T4, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeploymentGroupRevisionLocationFactory, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeploymentGroupRevisionLocationFactory, InnerDeploymentGroupGitHubLocationFactory> WithGitHubLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeploymentGroupRevisionLocationFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitHubLocation(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1>(this CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1>(this CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2, T3, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2, T3, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory, T3, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentGroupRevisionLocationFactory, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeploymentGroupRevisionLocationFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2, T3, T4, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<InnerDeploymentGroupRevisionLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2, T3, T4, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeploymentGroupRevisionLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory, T3, T4, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeploymentGroupRevisionLocationFactory, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentGroupRevisionLocationFactory, T4, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeploymentGroupRevisionLocationFactory, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeploymentGroupRevisionLocationFactory, InnerDeploymentGroupS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeploymentGroupRevisionLocationFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T5, subFactoryAction));
}
