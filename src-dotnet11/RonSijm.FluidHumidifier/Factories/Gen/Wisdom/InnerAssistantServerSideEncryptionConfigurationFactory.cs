// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAssistantServerSideEncryptionConfigurationFactory(Action<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration>
{

    protected override Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration Create()
    {
        var serverSideEncryptionConfigurationResult = CreateServerSideEncryptionConfiguration();
        factoryAction?.Invoke(serverSideEncryptionConfigurationResult);

        return serverSideEncryptionConfigurationResult;
    }

    private Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration CreateServerSideEncryptionConfiguration()
    {
        var serverSideEncryptionConfigurationResult = new Humidifier.Wisdom.AssistantTypes.ServerSideEncryptionConfiguration();

        return serverSideEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerAssistantServerSideEncryptionConfigurationFactoryExtensions
{
}
