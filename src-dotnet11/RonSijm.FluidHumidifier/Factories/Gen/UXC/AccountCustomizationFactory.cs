// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.UXC;

public class AccountCustomizationFactory(string resourceName = null, Action<Humidifier.UXC.AccountCustomization> factoryAction = null) : ResourceFactory<Humidifier.UXC.AccountCustomization>(resourceName)
{

    protected override Humidifier.UXC.AccountCustomization Create()
    {
        var accountCustomizationResult = CreateAccountCustomization();
        factoryAction?.Invoke(accountCustomizationResult);

        return accountCustomizationResult;
    }

    private Humidifier.UXC.AccountCustomization CreateAccountCustomization()
    {
        var accountCustomizationResult = new Humidifier.UXC.AccountCustomization
        {
            GivenName = InputResourceName,
        };

        return accountCustomizationResult;
    }

} // End Of Class

public static class AccountCustomizationFactoryExtensions
{
}
