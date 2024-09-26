// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeStar;

public class GitHubRepositoryFactory(string resourceName = null, Action<Humidifier.CodeStar.GitHubRepository> factoryAction = null) : ResourceFactory<Humidifier.CodeStar.GitHubRepository>(resourceName)
{

    internal InnerGitHubRepositoryCodeFactory CodeFactory { get; set; }

    protected override Humidifier.CodeStar.GitHubRepository Create()
    {
        var gitHubRepositoryResult = CreateGitHubRepository();
        factoryAction?.Invoke(gitHubRepositoryResult);

        return gitHubRepositoryResult;
    }

    private Humidifier.CodeStar.GitHubRepository CreateGitHubRepository()
    {
        var gitHubRepositoryResult = new Humidifier.CodeStar.GitHubRepository
        {
            GivenName = InputResourceName,
        };

        return gitHubRepositoryResult;
    }
    public override void CreateChildren(Humidifier.CodeStar.GitHubRepository result)
    {
        base.CreateChildren(result);

        result.Code ??= CodeFactory?.Build();
    }

} // End Of Class

public static class GitHubRepositoryFactoryExtensions
{
    public static CombinedResult<GitHubRepositoryFactory, InnerGitHubRepositoryCodeFactory> WithCode(this GitHubRepositoryFactory parentFactory, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null)
    {
        parentFactory.CodeFactory = new InnerGitHubRepositoryCodeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeFactory);
    }

    public static CombinedResult<GitHubRepositoryFactory, T1, InnerGitHubRepositoryCodeFactory> WithCode<T1>(this CombinedResult<GitHubRepositoryFactory, T1> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GitHubRepositoryFactory, InnerGitHubRepositoryCodeFactory> WithCode<T1>(this CombinedResult<T1, GitHubRepositoryFactory> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GitHubRepositoryFactory, T1, T2, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2>(this CombinedResult<GitHubRepositoryFactory, T1, T2> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GitHubRepositoryFactory, T2, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2>(this CombinedResult<T1, GitHubRepositoryFactory, T2> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GitHubRepositoryFactory, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2>(this CombinedResult<T1, T2, GitHubRepositoryFactory> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GitHubRepositoryFactory, T1, T2, T3, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<GitHubRepositoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GitHubRepositoryFactory, T2, T3, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<T1, GitHubRepositoryFactory, T2, T3> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GitHubRepositoryFactory, T3, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<T1, T2, GitHubRepositoryFactory, T3> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GitHubRepositoryFactory, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<T1, T2, T3, GitHubRepositoryFactory> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GitHubRepositoryFactory, T1, T2, T3, T4, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<GitHubRepositoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GitHubRepositoryFactory, T2, T3, T4, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, GitHubRepositoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GitHubRepositoryFactory, T3, T4, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, T2, GitHubRepositoryFactory, T3, T4> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GitHubRepositoryFactory, T4, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GitHubRepositoryFactory, T4> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GitHubRepositoryFactory, InnerGitHubRepositoryCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GitHubRepositoryFactory> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T5, subFactoryAction));
}
