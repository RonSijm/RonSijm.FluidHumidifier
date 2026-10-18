// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class AccountFactory(string resourceName = null, Action<Humidifier.ApiGateway.Account> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.Account>(resourceName)
{

    protected override Humidifier.ApiGateway.Account Create()
    {
        var accountResult = CreateAccount();
        factoryAction?.Invoke(accountResult);

        return accountResult;
    }

    private Humidifier.ApiGateway.Account CreateAccount()
    {
        var accountResult = new Humidifier.ApiGateway.Account
        {
            GivenName = InputResourceName,
        };

        return accountResult;
    }

} // End Of Class

public static class AccountFactoryExtensions
{
}
