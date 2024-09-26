// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectSourceFactory(Action<Humidifier.CodeBuild.ProjectTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.Source>
{

    internal InnerProjectSourceAuthFactory AuthFactory { get; set; }

    internal InnerProjectBuildStatusConfigFactory BuildStatusConfigFactory { get; set; }

    internal InnerProjectGitSubmodulesConfigFactory GitSubmodulesConfigFactory { get; set; }

    protected override Humidifier.CodeBuild.ProjectTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.CodeBuild.ProjectTypes.Source();

        return sourceResult;
    }
    public override void CreateChildren(Humidifier.CodeBuild.ProjectTypes.Source result)
    {
        base.CreateChildren(result);

        result.Auth ??= AuthFactory?.Build();
        result.BuildStatusConfig ??= BuildStatusConfigFactory?.Build();
        result.GitSubmodulesConfig ??= GitSubmodulesConfigFactory?.Build();
    }

} // End Of Class

public static class InnerProjectSourceFactoryExtensions
{
    public static CombinedResult<InnerProjectSourceFactory, InnerProjectSourceAuthFactory> WithAuth(this InnerProjectSourceFactory parentFactory, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null)
    {
        parentFactory.AuthFactory = new InnerProjectSourceAuthFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthFactory);
    }

    public static CombinedResult<InnerProjectSourceFactory, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig(this InnerProjectSourceFactory parentFactory, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null)
    {
        parentFactory.BuildStatusConfigFactory = new InnerProjectBuildStatusConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BuildStatusConfigFactory);
    }

    public static CombinedResult<InnerProjectSourceFactory, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig(this InnerProjectSourceFactory parentFactory, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null)
    {
        parentFactory.GitSubmodulesConfigFactory = new InnerProjectGitSubmodulesConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GitSubmodulesConfigFactory);
    }

    public static CombinedResult<InnerProjectSourceFactory, T1, InnerProjectSourceAuthFactory> WithAuth<T1>(this CombinedResult<InnerProjectSourceFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, InnerProjectSourceAuthFactory> WithAuth<T1>(this CombinedResult<T1, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, T2, InnerProjectSourceAuthFactory> WithAuth<T1, T2>(this CombinedResult<InnerProjectSourceFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, T2, InnerProjectSourceAuthFactory> WithAuth<T1, T2>(this CombinedResult<T1, InnerProjectSourceFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectSourceFactory, InnerProjectSourceAuthFactory> WithAuth<T1, T2>(this CombinedResult<T1, T2, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, T2, T3, InnerProjectSourceAuthFactory> WithAuth<T1, T2, T3>(this CombinedResult<InnerProjectSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, T2, T3, InnerProjectSourceAuthFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, InnerProjectSourceFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectSourceFactory, T3, InnerProjectSourceAuthFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectSourceFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectSourceFactory, InnerProjectSourceAuthFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, T2, T3, T4, InnerProjectSourceAuthFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<InnerProjectSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, T2, T3, T4, InnerProjectSourceAuthFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectSourceFactory, T3, T4, InnerProjectSourceAuthFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectSourceFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectSourceFactory, T4, InnerProjectSourceAuthFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectSourceFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProjectSourceFactory, InnerProjectSourceAuthFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.SourceAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1>(this CombinedResult<InnerProjectSourceFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1>(this CombinedResult<T1, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, T2, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2>(this CombinedResult<InnerProjectSourceFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, T2, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2>(this CombinedResult<T1, InnerProjectSourceFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectSourceFactory, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2>(this CombinedResult<T1, T2, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, T2, T3, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2, T3>(this CombinedResult<InnerProjectSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, T2, T3, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2, T3>(this CombinedResult<T1, InnerProjectSourceFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectSourceFactory, T3, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectSourceFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectSourceFactory, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, T2, T3, T4, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2, T3, T4>(this CombinedResult<InnerProjectSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, T2, T3, T4, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectSourceFactory, T3, T4, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectSourceFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectSourceFactory, T4, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectSourceFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProjectSourceFactory, InnerProjectBuildStatusConfigFactory> WithBuildStatusConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildStatusConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1>(this CombinedResult<InnerProjectSourceFactory, T1> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1>(this CombinedResult<T1, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, T2, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2>(this CombinedResult<InnerProjectSourceFactory, T1, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, T2, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2>(this CombinedResult<T1, InnerProjectSourceFactory, T2> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectSourceFactory, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2>(this CombinedResult<T1, T2, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, T2, T3, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2, T3>(this CombinedResult<InnerProjectSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, T2, T3, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2, T3>(this CombinedResult<T1, InnerProjectSourceFactory, T2, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectSourceFactory, T3, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerProjectSourceFactory, T3> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectSourceFactory, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerProjectSourceFactory, T1, T2, T3, T4, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2, T3, T4>(this CombinedResult<InnerProjectSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerProjectSourceFactory, T2, T3, T4, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerProjectSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerProjectSourceFactory, T3, T4, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProjectSourceFactory, T3, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerProjectSourceFactory, T4, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProjectSourceFactory, T4> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerProjectSourceFactory, InnerProjectGitSubmodulesConfigFactory> WithGitSubmodulesConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProjectSourceFactory> combinedResult, Action<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitSubmodulesConfig(combinedResult.T5, subFactoryAction));
}
