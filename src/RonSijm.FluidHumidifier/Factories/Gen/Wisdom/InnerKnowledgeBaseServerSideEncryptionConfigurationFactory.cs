// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseServerSideEncryptionConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.ServerSideEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.ServerSideEncryptionConfiguration>
{

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.ServerSideEncryptionConfiguration Create()
    {
        var serverSideEncryptionConfigurationResult = CreateServerSideEncryptionConfiguration();
        factoryAction?.Invoke(serverSideEncryptionConfigurationResult);

        return serverSideEncryptionConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.ServerSideEncryptionConfiguration CreateServerSideEncryptionConfiguration()
    {
        var serverSideEncryptionConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.ServerSideEncryptionConfiguration();

        return serverSideEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseServerSideEncryptionConfigurationFactoryExtensions
{
}
