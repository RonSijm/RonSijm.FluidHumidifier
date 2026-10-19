// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceGitHubDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.GitHubDetails>
{

    internal InnerServiceGitHubPatDetailsFactory DirectAccessFactory { get; set; }

    internal InnerServiceGitHubAppVerificationDetailsFactory AppVerificationFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.GitHubDetails Create()
    {
        var gitHubDetailsResult = CreateGitHubDetails();
        factoryAction?.Invoke(gitHubDetailsResult);

        return gitHubDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.GitHubDetails CreateGitHubDetails()
    {
        var gitHubDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.GitHubDetails();

        return gitHubDetailsResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.GitHubDetails result)
    {
        base.CreateChildren(result);

        result.DirectAccess ??= DirectAccessFactory?.Build();
        result.AppVerification ??= AppVerificationFactory?.Build();
    }

} // End Of Class

public static class InnerServiceGitHubDetailsFactoryExtensions
{
    public static CombinedResult<InnerServiceGitHubDetailsFactory, InnerServiceGitHubPatDetailsFactory> WithDirectAccess(this InnerServiceGitHubDetailsFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null)
    {
        parentFactory.DirectAccessFactory = new InnerServiceGitHubPatDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DirectAccessFactory);
    }

    public static CombinedResult<InnerServiceGitHubDetailsFactory, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification(this InnerServiceGitHubDetailsFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null)
    {
        parentFactory.AppVerificationFactory = new InnerServiceGitHubAppVerificationDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AppVerificationFactory);
    }

    public static CombinedResult<InnerServiceGitHubDetailsFactory, T1, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1>(this CombinedResult<InnerServiceGitHubDetailsFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithDirectAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGitHubDetailsFactory, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1>(this CombinedResult<T1, InnerServiceGitHubDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithDirectAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2>(this CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2>(this CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2>(this CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2, T3, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2, T3>(this CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2, T3, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2, T3>(this CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory, T3, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceGitHubDetailsFactory, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceGitHubDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2, T3, T4, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2, T3, T4>(this CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2, T3, T4, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory, T3, T4, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceGitHubDetailsFactory, T4, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceGitHubDetailsFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceGitHubDetailsFactory, InnerServiceGitHubPatDetailsFactory> WithDirectAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceGitHubDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDirectAccess(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGitHubDetailsFactory, T1, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1>(this CombinedResult<InnerServiceGitHubDetailsFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppVerification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGitHubDetailsFactory, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1>(this CombinedResult<T1, InnerServiceGitHubDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppVerification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2>(this CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2>(this CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2>(this CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2, T3, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2, T3>(this CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2, T3, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2, T3>(this CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory, T3, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceGitHubDetailsFactory, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceGitHubDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2, T3, T4, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2, T3, T4>(this CombinedResult<InnerServiceGitHubDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2, T3, T4, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceGitHubDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory, T3, T4, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceGitHubDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceGitHubDetailsFactory, T4, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceGitHubDetailsFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceGitHubDetailsFactory, InnerServiceGitHubAppVerificationDetailsFactory> WithAppVerification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceGitHubDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppVerification(combinedResult.T5, subFactoryAction).T2);
}
