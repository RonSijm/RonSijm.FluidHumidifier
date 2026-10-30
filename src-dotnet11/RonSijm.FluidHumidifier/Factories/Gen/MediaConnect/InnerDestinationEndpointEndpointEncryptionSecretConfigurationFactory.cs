// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactory(Action<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration>
{

    protected override Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration Create()
    {
        var endpointEncryptionSecretConfigurationResult = CreateEndpointEncryptionSecretConfiguration();
        factoryAction?.Invoke(endpointEncryptionSecretConfigurationResult);

        return endpointEncryptionSecretConfigurationResult;
    }

    private Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration CreateEndpointEncryptionSecretConfiguration()
    {
        var endpointEncryptionSecretConfigurationResult = new Humidifier.MediaConnect.DestinationEndpointTypes.EndpointEncryptionSecretConfiguration();

        return endpointEncryptionSecretConfigurationResult;
    }

} // End Of Class

public static class InnerDestinationEndpointEndpointEncryptionSecretConfigurationFactoryExtensions
{
}
