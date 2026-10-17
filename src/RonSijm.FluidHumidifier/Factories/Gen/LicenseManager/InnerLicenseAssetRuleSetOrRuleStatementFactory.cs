// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseAssetRuleSetOrRuleStatementFactory(Action<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement>
{

    protected override Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement Create()
    {
        var orRuleStatementResult = CreateOrRuleStatement();
        factoryAction?.Invoke(orRuleStatementResult);

        return orRuleStatementResult;
    }

    private Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement CreateOrRuleStatement()
    {
        var orRuleStatementResult = new Humidifier.LicenseManager.LicenseAssetRuleSetTypes.OrRuleStatement();

        return orRuleStatementResult;
    }

} // End Of Class

public static class InnerLicenseAssetRuleSetOrRuleStatementFactoryExtensions
{
}
