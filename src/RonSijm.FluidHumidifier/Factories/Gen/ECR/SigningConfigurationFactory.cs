// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class SigningConfigurationFactory(string resourceName = null, Action<Humidifier.ECR.SigningConfiguration> factoryAction = null) : ResourceFactory<Humidifier.ECR.SigningConfiguration>(resourceName)
{

    internal List<InnerSigningConfigurationRuleFactory> RulesFactories { get; set; } = [];

    protected override Humidifier.ECR.SigningConfiguration Create()
    {
        var signingConfigurationResult = CreateSigningConfiguration();
        factoryAction?.Invoke(signingConfigurationResult);

        return signingConfigurationResult;
    }

    private Humidifier.ECR.SigningConfiguration CreateSigningConfiguration()
    {
        var signingConfigurationResult = new Humidifier.ECR.SigningConfiguration
        {
            GivenName = InputResourceName,
        };

        return signingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECR.SigningConfiguration result)
    {
        base.CreateChildren(result);

        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SigningConfigurationFactoryExtensions
{
    public static CombinedResult<SigningConfigurationFactory, InnerSigningConfigurationRuleFactory> WithRules(this SigningConfigurationFactory parentFactory, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null)
    {
        var factory = new InnerSigningConfigurationRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SigningConfigurationFactory, T1, InnerSigningConfigurationRuleFactory> WithRules<T1>(this CombinedResult<SigningConfigurationFactory, T1> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SigningConfigurationFactory, InnerSigningConfigurationRuleFactory> WithRules<T1>(this CombinedResult<T1, SigningConfigurationFactory> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SigningConfigurationFactory, T1, T2, InnerSigningConfigurationRuleFactory> WithRules<T1, T2>(this CombinedResult<SigningConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SigningConfigurationFactory, T2, InnerSigningConfigurationRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, SigningConfigurationFactory, T2> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SigningConfigurationFactory, InnerSigningConfigurationRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, SigningConfigurationFactory> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SigningConfigurationFactory, T1, T2, T3, InnerSigningConfigurationRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<SigningConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SigningConfigurationFactory, T2, T3, InnerSigningConfigurationRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, SigningConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SigningConfigurationFactory, T3, InnerSigningConfigurationRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, SigningConfigurationFactory, T3> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SigningConfigurationFactory, InnerSigningConfigurationRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, SigningConfigurationFactory> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SigningConfigurationFactory, T1, T2, T3, T4, InnerSigningConfigurationRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<SigningConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SigningConfigurationFactory, T2, T3, T4, InnerSigningConfigurationRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, SigningConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SigningConfigurationFactory, T3, T4, InnerSigningConfigurationRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, SigningConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SigningConfigurationFactory, T4, InnerSigningConfigurationRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SigningConfigurationFactory, T4> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SigningConfigurationFactory, InnerSigningConfigurationRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SigningConfigurationFactory> combinedResult, Action<Humidifier.ECR.SigningConfigurationTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction).T2);
}
