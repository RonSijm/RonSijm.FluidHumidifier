// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PaymentCryptography;

public class AliasFactory(string resourceName = null, Action<Humidifier.PaymentCryptography.Alias> factoryAction = null) : ResourceFactory<Humidifier.PaymentCryptography.Alias>(resourceName)
{

    protected override Humidifier.PaymentCryptography.Alias Create()
    {
        var aliasResult = CreateAlias();
        factoryAction?.Invoke(aliasResult);

        return aliasResult;
    }

    private Humidifier.PaymentCryptography.Alias CreateAlias()
    {
        var aliasResult = new Humidifier.PaymentCryptography.Alias
        {
            GivenName = InputResourceName,
        };

        return aliasResult;
    }

} // End Of Class

public static class AliasFactoryExtensions
{
}
