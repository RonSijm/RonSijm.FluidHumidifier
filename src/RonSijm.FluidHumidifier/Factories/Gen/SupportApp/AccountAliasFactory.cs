// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SupportApp;

public class AccountAliasFactory(string resourceName = null, Action<Humidifier.SupportApp.AccountAlias> factoryAction = null) : ResourceFactory<Humidifier.SupportApp.AccountAlias>(resourceName)
{

    protected override Humidifier.SupportApp.AccountAlias Create()
    {
        var accountAliasResult = CreateAccountAlias();
        factoryAction?.Invoke(accountAliasResult);

        return accountAliasResult;
    }

    private Humidifier.SupportApp.AccountAlias CreateAccountAlias()
    {
        var accountAliasResult = new Humidifier.SupportApp.AccountAlias
        {
            GivenName = InputResourceName,
        };

        return accountAliasResult;
    }

} // End Of Class

public static class AccountAliasFactoryExtensions
{
}
