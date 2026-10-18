// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseKendraKnowledgeBaseConfigurationFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.KendraKnowledgeBaseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.KendraKnowledgeBaseConfiguration>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.KendraKnowledgeBaseConfiguration Create()
    {
        var kendraKnowledgeBaseConfigurationResult = CreateKendraKnowledgeBaseConfiguration();
        factoryAction?.Invoke(kendraKnowledgeBaseConfigurationResult);

        return kendraKnowledgeBaseConfigurationResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.KendraKnowledgeBaseConfiguration CreateKendraKnowledgeBaseConfiguration()
    {
        var kendraKnowledgeBaseConfigurationResult = new Humidifier.Bedrock.KnowledgeBaseTypes.KendraKnowledgeBaseConfiguration();

        return kendraKnowledgeBaseConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseKendraKnowledgeBaseConfigurationFactoryExtensions
{
}
