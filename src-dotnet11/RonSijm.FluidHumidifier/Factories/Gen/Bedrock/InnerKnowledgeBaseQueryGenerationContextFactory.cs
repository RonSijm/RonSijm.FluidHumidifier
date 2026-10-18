// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerKnowledgeBaseQueryGenerationContextFactory(Action<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext>
{

    protected override Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext Create()
    {
        var queryGenerationContextResult = CreateQueryGenerationContext();
        factoryAction?.Invoke(queryGenerationContextResult);

        return queryGenerationContextResult;
    }

    private Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext CreateQueryGenerationContext()
    {
        var queryGenerationContextResult = new Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext();

        return queryGenerationContextResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseQueryGenerationContextFactoryExtensions
{
}
