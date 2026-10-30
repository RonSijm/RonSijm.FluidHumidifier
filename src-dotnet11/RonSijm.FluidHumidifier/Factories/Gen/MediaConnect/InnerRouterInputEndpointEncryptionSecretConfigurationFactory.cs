// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputEndpointEncryptionSecretConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration>
{

    protected override Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration Create()
    {
        var endpointEncryptionSecretConfigurationResult = CreateEndpointEncryptionSecretConfiguration();
        factoryAction?.Invoke(endpointEncryptionSecretConfigurationResult);

        return endpointEncryptionSecretConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration CreateEndpointEncryptionSecretConfiguration()
    {
        var endpointEncryptionSecretConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionSecretConfiguration();

        return endpointEncryptionSecretConfigurationResult;
    }

} // End Of Class

public static class InnerRouterInputEndpointEncryptionSecretConfigurationFactoryExtensions
{
}
