// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class MailManagerTrafficPolicyFactory(string resourceName = null, Action<Humidifier.SES.MailManagerTrafficPolicy> factoryAction = null) : ResourceFactory<Humidifier.SES.MailManagerTrafficPolicy>(resourceName)
{

    internal List<InnerMailManagerTrafficPolicyPolicyStatementFactory> PolicyStatementsFactories { get; set; } = [];

    protected override Humidifier.SES.MailManagerTrafficPolicy Create()
    {
        var mailManagerTrafficPolicyResult = CreateMailManagerTrafficPolicy();
        factoryAction?.Invoke(mailManagerTrafficPolicyResult);

        return mailManagerTrafficPolicyResult;
    }

    private Humidifier.SES.MailManagerTrafficPolicy CreateMailManagerTrafficPolicy()
    {
        var mailManagerTrafficPolicyResult = new Humidifier.SES.MailManagerTrafficPolicy
        {
            GivenName = InputResourceName,
        };

        return mailManagerTrafficPolicyResult;
    }
    public override void CreateChildren(Humidifier.SES.MailManagerTrafficPolicy result)
    {
        base.CreateChildren(result);

        result.PolicyStatements = PolicyStatementsFactories.Any() ? PolicyStatementsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class MailManagerTrafficPolicyFactoryExtensions
{
    public static CombinedResult<MailManagerTrafficPolicyFactory, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements(this MailManagerTrafficPolicyFactory parentFactory, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null)
    {
        var factory = new InnerMailManagerTrafficPolicyPolicyStatementFactory(subFactoryAction);
        parentFactory.PolicyStatementsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MailManagerTrafficPolicyFactory, T1, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1>(this CombinedResult<MailManagerTrafficPolicyFactory, T1> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyStatements(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerTrafficPolicyFactory, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1>(this CombinedResult<T1, MailManagerTrafficPolicyFactory> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyStatements(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MailManagerTrafficPolicyFactory, T1, T2, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2>(this CombinedResult<MailManagerTrafficPolicyFactory, T1, T2> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerTrafficPolicyFactory, T2, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2>(this CombinedResult<T1, MailManagerTrafficPolicyFactory, T2> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerTrafficPolicyFactory, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2>(this CombinedResult<T1, T2, MailManagerTrafficPolicyFactory> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MailManagerTrafficPolicyFactory, T1, T2, T3, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2, T3>(this CombinedResult<MailManagerTrafficPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerTrafficPolicyFactory, T2, T3, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2, T3>(this CombinedResult<T1, MailManagerTrafficPolicyFactory, T2, T3> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerTrafficPolicyFactory, T3, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2, T3>(this CombinedResult<T1, T2, MailManagerTrafficPolicyFactory, T3> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MailManagerTrafficPolicyFactory, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2, T3>(this CombinedResult<T1, T2, T3, MailManagerTrafficPolicyFactory> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MailManagerTrafficPolicyFactory, T1, T2, T3, T4, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2, T3, T4>(this CombinedResult<MailManagerTrafficPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MailManagerTrafficPolicyFactory, T2, T3, T4, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2, T3, T4>(this CombinedResult<T1, MailManagerTrafficPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MailManagerTrafficPolicyFactory, T3, T4, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2, T3, T4>(this CombinedResult<T1, T2, MailManagerTrafficPolicyFactory, T3, T4> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MailManagerTrafficPolicyFactory, T4, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MailManagerTrafficPolicyFactory, T4> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MailManagerTrafficPolicyFactory, InnerMailManagerTrafficPolicyPolicyStatementFactory> WithPolicyStatements<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MailManagerTrafficPolicyFactory> combinedResult, Action<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyStatements(combinedResult.T5, subFactoryAction));
}
