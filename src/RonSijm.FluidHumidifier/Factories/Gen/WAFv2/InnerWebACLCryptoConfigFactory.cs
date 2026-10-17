// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLCryptoConfigFactory(Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.CryptoConfig>
{

    protected override Humidifier.WAFv2.WebACLTypes.CryptoConfig Create()
    {
        var cryptoConfigResult = CreateCryptoConfig();
        factoryAction?.Invoke(cryptoConfigResult);

        return cryptoConfigResult;
    }

    private Humidifier.WAFv2.WebACLTypes.CryptoConfig CreateCryptoConfig()
    {
        var cryptoConfigResult = new Humidifier.WAFv2.WebACLTypes.CryptoConfig();

        return cryptoConfigResult;
    }

} // End Of Class

public static class InnerWebACLCryptoConfigFactoryExtensions
{
}
