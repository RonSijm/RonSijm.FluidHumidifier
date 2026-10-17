// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseManagedKnowledgeBaseServerSideEncryptionConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.ManagedKnowledgeBaseServerSideEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.ManagedKnowledgeBaseServerSideEncryptionConfiguration>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.ManagedKnowledgeBaseServerSideEncryptionConfiguration Create()
    {
        var managedKnowledgeBaseServerSideEncryptionConfigurationResult = CreateManagedKnowledgeBaseServerSideEncryptionConfiguration();
        factoryAction?.Invoke(managedKnowledgeBaseServerSideEncryptionConfigurationResult);

        return managedKnowledgeBaseServerSideEncryptionConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.ManagedKnowledgeBaseServerSideEncryptionConfiguration CreateManagedKnowledgeBaseServerSideEncryptionConfiguration()
    {
        var managedKnowledgeBaseServerSideEncryptionConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.ManagedKnowledgeBaseServerSideEncryptionConfiguration();

        return managedKnowledgeBaseServerSideEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseManagedKnowledgeBaseServerSideEncryptionConfigurationFactoryExtensions
{
}
