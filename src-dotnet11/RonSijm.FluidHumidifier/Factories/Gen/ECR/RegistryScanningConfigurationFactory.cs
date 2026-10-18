// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class RegistryScanningConfigurationFactory(string resourceName = null, Action<Humidifier.ECR.RegistryScanningConfiguration> factoryAction = null) : ResourceFactory<Humidifier.ECR.RegistryScanningConfiguration>(resourceName)
{

    internal List<InnerRegistryScanningConfigurationScanningRuleFactory> RulesFactories { get; set; } = [];

    protected override Humidifier.ECR.RegistryScanningConfiguration Create()
    {
        var registryScanningConfigurationResult = CreateRegistryScanningConfiguration();
        factoryAction?.Invoke(registryScanningConfigurationResult);

        return registryScanningConfigurationResult;
    }

    private Humidifier.ECR.RegistryScanningConfiguration CreateRegistryScanningConfiguration()
    {
        var registryScanningConfigurationResult = new Humidifier.ECR.RegistryScanningConfiguration
        {
            GivenName = InputResourceName,
        };

        return registryScanningConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECR.RegistryScanningConfiguration result)
    {
        base.CreateChildren(result);

        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RegistryScanningConfigurationFactoryExtensions
{
    public static CombinedResult<RegistryScanningConfigurationFactory, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules(this RegistryScanningConfigurationFactory parentFactory, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null)
    {
        var factory = new InnerRegistryScanningConfigurationScanningRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RegistryScanningConfigurationFactory, T1, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1>(this CombinedResult<RegistryScanningConfigurationFactory, T1> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RegistryScanningConfigurationFactory, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1>(this CombinedResult<T1, RegistryScanningConfigurationFactory> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RegistryScanningConfigurationFactory, T1, T2, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2>(this CombinedResult<RegistryScanningConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RegistryScanningConfigurationFactory, T2, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, RegistryScanningConfigurationFactory, T2> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RegistryScanningConfigurationFactory, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, RegistryScanningConfigurationFactory> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RegistryScanningConfigurationFactory, T1, T2, T3, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<RegistryScanningConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RegistryScanningConfigurationFactory, T2, T3, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, RegistryScanningConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RegistryScanningConfigurationFactory, T3, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, RegistryScanningConfigurationFactory, T3> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RegistryScanningConfigurationFactory, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, RegistryScanningConfigurationFactory> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RegistryScanningConfigurationFactory, T1, T2, T3, T4, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<RegistryScanningConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RegistryScanningConfigurationFactory, T2, T3, T4, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, RegistryScanningConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RegistryScanningConfigurationFactory, T3, T4, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, RegistryScanningConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RegistryScanningConfigurationFactory, T4, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RegistryScanningConfigurationFactory, T4> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RegistryScanningConfigurationFactory, InnerRegistryScanningConfigurationScanningRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RegistryScanningConfigurationFactory> combinedResult, Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction).T2);
}
