// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputTlsEncryptionConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration>
{

    protected override Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration Create()
    {
        var tlsEncryptionConfigurationResult = CreateTlsEncryptionConfiguration();
        factoryAction?.Invoke(tlsEncryptionConfigurationResult);

        return tlsEncryptionConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration CreateTlsEncryptionConfiguration()
    {
        var tlsEncryptionConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.TlsEncryptionConfiguration();

        return tlsEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerRouterOutputTlsEncryptionConfigurationFactoryExtensions
{
}
