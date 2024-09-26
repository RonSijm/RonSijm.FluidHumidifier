// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Organizations;

public class AccountFactory(string resourceName = null, Action<Humidifier.Organizations.Account> factoryAction = null) : ResourceFactory<Humidifier.Organizations.Account>(resourceName)
{

    protected override Humidifier.Organizations.Account Create()
    {
        var accountResult = CreateAccount();
        factoryAction?.Invoke(accountResult);

        return accountResult;
    }

    private Humidifier.Organizations.Account CreateAccount()
    {
        var accountResult = new Humidifier.Organizations.Account
        {
            GivenName = InputResourceName,
        };

        return accountResult;
    }

} // End Of Class

public static class AccountFactoryExtensions
{
}
