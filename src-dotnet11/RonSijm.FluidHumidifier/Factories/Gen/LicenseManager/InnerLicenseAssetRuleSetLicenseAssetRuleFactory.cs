// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseAssetRuleSetLicenseAssetRuleFactory(Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule>
{

    internal InnerLicenseAssetRuleSetRuleStatementFactory RuleStatementFactory { get; set; }

    protected override Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule Create()
    {
        var licenseAssetRuleResult = CreateLicenseAssetRule();
        factoryAction?.Invoke(licenseAssetRuleResult);

        return licenseAssetRuleResult;
    }

    private Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule CreateLicenseAssetRule()
    {
        var licenseAssetRuleResult = new Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule();

        return licenseAssetRuleResult;
    }
    public override void CreateChildren(Humidifier.LicenseManager.LicenseAssetRuleSetTypes.LicenseAssetRule result)
    {
        base.CreateChildren(result);

        result.RuleStatement ??= RuleStatementFactory?.Build();
    }

} // End Of Class

public static class InnerLicenseAssetRuleSetLicenseAssetRuleFactoryExtensions
{
    public static CombinedResult<InnerLicenseAssetRuleSetLicenseAssetRuleFactory, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement(this InnerLicenseAssetRuleSetLicenseAssetRuleFactory parentFactory, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null)
    {
        parentFactory.RuleStatementFactory = new InnerLicenseAssetRuleSetRuleStatementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleStatementFactory);
    }

    public static CombinedResult<InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T1, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1>(this CombinedResult<InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T1> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleStatement(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1>(this CombinedResult<T1, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleStatement(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T1, T2, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2>(this CombinedResult<InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T2, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2>(this CombinedResult<T1, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T2> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2>(this CombinedResult<T1, T2, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T1, T2, T3, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2, T3>(this CombinedResult<InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T2, T3, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2, T3>(this CombinedResult<T1, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T3, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2, T3>(this CombinedResult<T1, T2, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T1, T2, T3, T4, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2, T3, T4>(this CombinedResult<InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T2, T3, T4, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2, T3, T4>(this CombinedResult<T1, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T3, T4, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T4, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLicenseAssetRuleSetLicenseAssetRuleFactory, InnerLicenseAssetRuleSetRuleStatementFactory> WithRuleStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLicenseAssetRuleSetLicenseAssetRuleFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.RuleStatement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleStatement(combinedResult.T5, subFactoryAction).T2);
}
