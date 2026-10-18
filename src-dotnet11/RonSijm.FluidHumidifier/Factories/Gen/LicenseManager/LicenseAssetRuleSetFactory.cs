// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class LicenseAssetRuleSetFactory(string resourceName = null, Action<Humidifier.LicenseManager.LicenseAssetRuleSet> factoryAction = null) : ResourceFactory<Humidifier.LicenseManager.LicenseAssetRuleSet>(resourceName)
{

    internal List<InnerLicenseAssetRuleSetLicenseAssetRuleFactory> RulesFactories { get; set; } = [];

    protected override Humidifier.LicenseManager.LicenseAssetRuleSet Create()
    {
        var licenseAssetRuleSetResult = CreateLicenseAssetRuleSet();
        factoryAction?.Invoke(licenseAssetRuleSetResult);

        return licenseAssetRuleSetResult;
    }

    private Humidifier.LicenseManager.LicenseAssetRuleSet CreateLicenseAssetRuleSet()
    {
        var licenseAssetRuleSetResult = new Humidifier.LicenseManager.LicenseAssetRuleSet
        {
            GivenName = InputResourceName,
        };

        return licenseAssetRuleSetResult;
    }
    public override void CreateChildren(Humidifier.LicenseManager.LicenseAssetRuleSet result)
    {
        base.CreateChildren(result);

        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class LicenseAssetRuleSetFactoryExtensions
{
    public static CombinedResult<LicenseAssetRuleSetFactory, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules(this LicenseAssetRuleSetFactory parentFactory, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null)
    {
        var factory = new InnerLicenseAssetRuleSetLicenseAssetRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LicenseAssetRuleSetFactory, T1, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1>(this CombinedResult<LicenseAssetRuleSetFactory, T1> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetRuleSetFactory, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1>(this CombinedResult<T1, LicenseAssetRuleSetFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LicenseAssetRuleSetFactory, T1, T2, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2>(this CombinedResult<LicenseAssetRuleSetFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetRuleSetFactory, T2, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, LicenseAssetRuleSetFactory, T2> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseAssetRuleSetFactory, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, LicenseAssetRuleSetFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LicenseAssetRuleSetFactory, T1, T2, T3, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<LicenseAssetRuleSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetRuleSetFactory, T2, T3, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, LicenseAssetRuleSetFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseAssetRuleSetFactory, T3, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, LicenseAssetRuleSetFactory, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LicenseAssetRuleSetFactory, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, LicenseAssetRuleSetFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LicenseAssetRuleSetFactory, T1, T2, T3, T4, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<LicenseAssetRuleSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseAssetRuleSetFactory, T2, T3, T4, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, LicenseAssetRuleSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseAssetRuleSetFactory, T3, T4, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, LicenseAssetRuleSetFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LicenseAssetRuleSetFactory, T4, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LicenseAssetRuleSetFactory, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LicenseAssetRuleSetFactory, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LicenseAssetRuleSetFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction).T2);
}
