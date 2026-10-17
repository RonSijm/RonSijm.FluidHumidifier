// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseAssetRuleSetAndRuleStatementFactory(Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement>
{

    protected override Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement Create()
    {
        var andRuleStatementResult = CreateAndRuleStatement();
        factoryAction?.Invoke(andRuleStatementResult);

        return andRuleStatementResult;
    }

    private Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement CreateAndRuleStatement()
    {
        var andRuleStatementResult = new Humidifier.LicenseManager.LicenseAssetRuleSetTypes.AndRuleStatement();

        return andRuleStatementResult;
    }

} // End Of Class

public static class InnerLicenseAssetRuleSetAndRuleStatementFactoryExtensions
{
}
