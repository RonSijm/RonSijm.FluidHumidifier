// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseSupplementalDataStorageConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageConfiguration>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageConfiguration Create()
    {
        var supplementalDataStorageConfigurationResult = CreateSupplementalDataStorageConfiguration();
        factoryAction?.Invoke(supplementalDataStorageConfigurationResult);

        return supplementalDataStorageConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageConfiguration CreateSupplementalDataStorageConfiguration()
    {
        var supplementalDataStorageConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageConfiguration();

        return supplementalDataStorageConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseSupplementalDataStorageConfigurationFactoryExtensions
{
}
