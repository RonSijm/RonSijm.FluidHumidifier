// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class CodeRepositoryFactory(string resourceName = null, Action<Humidifier.SageMaker.CodeRepository> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.CodeRepository>(resourceName)
{

    internal InnerCodeRepositoryGitConfigFactory GitConfigFactory { get; set; }

    protected override Humidifier.SageMaker.CodeRepository Create()
    {
        var codeRepositoryResult = CreateCodeRepository();
        factoryAction?.Invoke(codeRepositoryResult);

        return codeRepositoryResult;
    }

    private Humidifier.SageMaker.CodeRepository CreateCodeRepository()
    {
        var codeRepositoryResult = new Humidifier.SageMaker.CodeRepository
        {
            GivenName = InputResourceName,
        };

        return codeRepositoryResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.CodeRepository result)
    {
        base.CreateChildren(result);

        result.GitConfig ??= GitConfigFactory?.Build();
    }

} // End Of Class

public static class CodeRepositoryFactoryExtensions
{
    public static CombinedResult<CodeRepositoryFactory, InnerCodeRepositoryGitConfigFactory> WithGitConfig(this CodeRepositoryFactory parentFactory, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null)
    {
        parentFactory.GitConfigFactory = new InnerCodeRepositoryGitConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GitConfigFactory);
    }

    public static CombinedResult<CodeRepositoryFactory, T1, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1>(this CombinedResult<CodeRepositoryFactory, T1> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithGitConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeRepositoryFactory, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1>(this CombinedResult<T1, CodeRepositoryFactory> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithGitConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CodeRepositoryFactory, T1, T2, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2>(this CombinedResult<CodeRepositoryFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeRepositoryFactory, T2, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2>(this CombinedResult<T1, CodeRepositoryFactory, T2> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CodeRepositoryFactory, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2>(this CombinedResult<T1, T2, CodeRepositoryFactory> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CodeRepositoryFactory, T1, T2, T3, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2, T3>(this CombinedResult<CodeRepositoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeRepositoryFactory, T2, T3, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2, T3>(this CombinedResult<T1, CodeRepositoryFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CodeRepositoryFactory, T3, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2, T3>(this CombinedResult<T1, T2, CodeRepositoryFactory, T3> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CodeRepositoryFactory, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, CodeRepositoryFactory> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CodeRepositoryFactory, T1, T2, T3, T4, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2, T3, T4>(this CombinedResult<CodeRepositoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CodeRepositoryFactory, T2, T3, T4, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2, T3, T4>(this CombinedResult<T1, CodeRepositoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CodeRepositoryFactory, T3, T4, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, CodeRepositoryFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CodeRepositoryFactory, T4, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CodeRepositoryFactory, T4> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CodeRepositoryFactory, InnerCodeRepositoryGitConfigFactory> WithGitConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CodeRepositoryFactory> combinedResult, Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGitConfig(combinedResult.T5, subFactoryAction));
}
