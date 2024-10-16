// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class AccountPolicyFactory(string resourceName = null, Action<Humidifier.Logs.AccountPolicy> factoryAction = null) : ResourceFactory<Humidifier.Logs.AccountPolicy>(resourceName)
{

    protected override Humidifier.Logs.AccountPolicy Create()
    {
        var accountPolicyResult = CreateAccountPolicy();
        factoryAction?.Invoke(accountPolicyResult);

        return accountPolicyResult;
    }

    private Humidifier.Logs.AccountPolicy CreateAccountPolicy()
    {
        var accountPolicyResult = new Humidifier.Logs.AccountPolicy
        {
            GivenName = InputResourceName,
        };

        return accountPolicyResult;
    }

} // End Of Class

public static class AccountPolicyFactoryExtensions
{
}
