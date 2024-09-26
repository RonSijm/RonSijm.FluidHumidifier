// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VoiceID;

public class InnerDomainServerSideEncryptionConfigurationFactory(Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration>
{

    protected override Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration Create()
    {
        var serverSideEncryptionConfigurationResult = CreateServerSideEncryptionConfiguration();
        factoryAction?.Invoke(serverSideEncryptionConfigurationResult);

        return serverSideEncryptionConfigurationResult;
    }

    private Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration CreateServerSideEncryptionConfiguration()
    {
        var serverSideEncryptionConfigurationResult = new Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration();

        return serverSideEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerDomainServerSideEncryptionConfigurationFactoryExtensions
{
}
