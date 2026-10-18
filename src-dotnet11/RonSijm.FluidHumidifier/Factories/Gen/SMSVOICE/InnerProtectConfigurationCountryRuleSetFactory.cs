// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerProtectConfigurationCountryRuleSetFactory(Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet>
{

    protected override Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet Create()
    {
        var countryRuleSetResult = CreateCountryRuleSet();
        factoryAction?.Invoke(countryRuleSetResult);

        return countryRuleSetResult;
    }

    private Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet CreateCountryRuleSet()
    {
        var countryRuleSetResult = new Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet();

        return countryRuleSetResult;
    }

} // End Of Class

public static class InnerProtectConfigurationCountryRuleSetFactoryExtensions
{
}
