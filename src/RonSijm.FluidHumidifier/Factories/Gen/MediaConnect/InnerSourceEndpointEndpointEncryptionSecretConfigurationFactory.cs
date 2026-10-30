// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerSourceEndpointEndpointEncryptionSecretConfigurationFactory(Action<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration>
{

    protected override Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration Create()
    {
        var endpointEncryptionSecretConfigurationResult = CreateEndpointEncryptionSecretConfiguration();
        factoryAction?.Invoke(endpointEncryptionSecretConfigurationResult);

        return endpointEncryptionSecretConfigurationResult;
    }

    private Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration CreateEndpointEncryptionSecretConfiguration()
    {
        var endpointEncryptionSecretConfigurationResult = new Humidifier.MediaConnect.SourceEndpointTypes.EndpointEncryptionSecretConfiguration();

        return endpointEncryptionSecretConfigurationResult;
    }

} // End Of Class

public static class InnerSourceEndpointEndpointEncryptionSecretConfigurationFactoryExtensions
{
}
