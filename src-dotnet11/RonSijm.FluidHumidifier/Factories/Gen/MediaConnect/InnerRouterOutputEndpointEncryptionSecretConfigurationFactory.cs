// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputEndpointEncryptionSecretConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration>
{

    protected override Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration Create()
    {
        var endpointEncryptionSecretConfigurationResult = CreateEndpointEncryptionSecretConfiguration();
        factoryAction?.Invoke(endpointEncryptionSecretConfigurationResult);

        return endpointEncryptionSecretConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration CreateEndpointEncryptionSecretConfiguration()
    {
        var endpointEncryptionSecretConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionSecretConfiguration();

        return endpointEncryptionSecretConfigurationResult;
    }

} // End Of Class

public static class InnerRouterOutputEndpointEncryptionSecretConfigurationFactoryExtensions
{
}
