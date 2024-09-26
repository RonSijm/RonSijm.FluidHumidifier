// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeStar;

public class InnerGitHubRepositoryCodeFactory(Action<Humidifier.CodeStar.GitHubRepositoryTypes.Code> factoryAction = null) : SubResourceFactory<Humidifier.CodeStar.GitHubRepositoryTypes.Code>
{

    internal InnerGitHubRepositoryS3Factory S3Factory { get; set; }

    protected override Humidifier.CodeStar.GitHubRepositoryTypes.Code Create()
    {
        var codeResult = CreateCode();
        factoryAction?.Invoke(codeResult);

        return codeResult;
    }

    private Humidifier.CodeStar.GitHubRepositoryTypes.Code CreateCode()
    {
        var codeResult = new Humidifier.CodeStar.GitHubRepositoryTypes.Code();

        return codeResult;
    }
    public override void CreateChildren(Humidifier.CodeStar.GitHubRepositoryTypes.Code result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerGitHubRepositoryCodeFactoryExtensions
{
    public static CombinedResult<InnerGitHubRepositoryCodeFactory, InnerGitHubRepositoryS3Factory> WithS3(this InnerGitHubRepositoryCodeFactory parentFactory, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerGitHubRepositoryS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerGitHubRepositoryCodeFactory, T1, InnerGitHubRepositoryS3Factory> WithS3<T1>(this CombinedResult<InnerGitHubRepositoryCodeFactory, T1> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGitHubRepositoryCodeFactory, InnerGitHubRepositoryS3Factory> WithS3<T1>(this CombinedResult<T1, InnerGitHubRepositoryCodeFactory> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGitHubRepositoryCodeFactory, T1, T2, InnerGitHubRepositoryS3Factory> WithS3<T1, T2>(this CombinedResult<InnerGitHubRepositoryCodeFactory, T1, T2> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGitHubRepositoryCodeFactory, T2, InnerGitHubRepositoryS3Factory> WithS3<T1, T2>(this CombinedResult<T1, InnerGitHubRepositoryCodeFactory, T2> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGitHubRepositoryCodeFactory, InnerGitHubRepositoryS3Factory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerGitHubRepositoryCodeFactory> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGitHubRepositoryCodeFactory, T1, T2, T3, InnerGitHubRepositoryS3Factory> WithS3<T1, T2, T3>(this CombinedResult<InnerGitHubRepositoryCodeFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGitHubRepositoryCodeFactory, T2, T3, InnerGitHubRepositoryS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerGitHubRepositoryCodeFactory, T2, T3> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGitHubRepositoryCodeFactory, T3, InnerGitHubRepositoryS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerGitHubRepositoryCodeFactory, T3> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGitHubRepositoryCodeFactory, InnerGitHubRepositoryS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGitHubRepositoryCodeFactory> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGitHubRepositoryCodeFactory, T1, T2, T3, T4, InnerGitHubRepositoryS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerGitHubRepositoryCodeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGitHubRepositoryCodeFactory, T2, T3, T4, InnerGitHubRepositoryS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerGitHubRepositoryCodeFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGitHubRepositoryCodeFactory, T3, T4, InnerGitHubRepositoryS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGitHubRepositoryCodeFactory, T3, T4> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGitHubRepositoryCodeFactory, T4, InnerGitHubRepositoryS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGitHubRepositoryCodeFactory, T4> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGitHubRepositoryCodeFactory, InnerGitHubRepositoryS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGitHubRepositoryCodeFactory> combinedResult, Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
