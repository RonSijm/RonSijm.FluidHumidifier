// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class KnowledgeBasePolicyFactory(string resourceName = null, Action<Humidifier.Bedrock.KnowledgeBasePolicy> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.KnowledgeBasePolicy>(resourceName)
{

    protected override Humidifier.Bedrock.KnowledgeBasePolicy Create()
    {
        var knowledgeBasePolicyResult = CreateKnowledgeBasePolicy();
        factoryAction?.Invoke(knowledgeBasePolicyResult);

        return knowledgeBasePolicyResult;
    }

    private Humidifier.Bedrock.KnowledgeBasePolicy CreateKnowledgeBasePolicy()
    {
        var knowledgeBasePolicyResult = new Humidifier.Bedrock.KnowledgeBasePolicy
        {
            GivenName = InputResourceName,
        };

        return knowledgeBasePolicyResult;
    }

} // End Of Class

public static class KnowledgeBasePolicyFactoryExtensions
{
}
