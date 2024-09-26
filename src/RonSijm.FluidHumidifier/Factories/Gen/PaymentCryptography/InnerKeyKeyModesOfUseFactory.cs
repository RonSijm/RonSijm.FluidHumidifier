// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PaymentCryptography;

public class InnerKeyKeyModesOfUseFactory(Action<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse> factoryAction = null) : SubResourceFactory<Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse>
{

    protected override Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse Create()
    {
        var keyModesOfUseResult = CreateKeyModesOfUse();
        factoryAction?.Invoke(keyModesOfUseResult);

        return keyModesOfUseResult;
    }

    private Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse CreateKeyModesOfUse()
    {
        var keyModesOfUseResult = new Humidifier.PaymentCryptography.KeyTypes.KeyModesOfUse();

        return keyModesOfUseResult;
    }

} // End Of Class

public static class InnerKeyKeyModesOfUseFactoryExtensions
{
}
