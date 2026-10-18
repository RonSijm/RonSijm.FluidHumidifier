// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseAssetRuleSetMatchingRuleStatementFactory(Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement>
{

    protected override Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement Create()
    {
        var matchingRuleStatementResult = CreateMatchingRuleStatement();
        factoryAction?.Invoke(matchingRuleStatementResult);

        return matchingRuleStatementResult;
    }

    private Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement CreateMatchingRuleStatement()
    {
        var matchingRuleStatementResult = new Humidifier.LicenseManager.LicenseAssetRuleSetTypes.MatchingRuleStatement();

        return matchingRuleStatementResult;
    }

} // End Of Class

public static class InnerLicenseAssetRuleSetMatchingRuleStatementFactoryExtensions
{
}
