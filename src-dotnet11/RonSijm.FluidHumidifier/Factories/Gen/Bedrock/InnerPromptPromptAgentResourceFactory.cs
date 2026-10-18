// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptPromptAgentResourceFactory(Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.PromptAgentResource>
{

    protected override Humidifier.Bedrock.PromptTypes.PromptAgentResource Create()
    {
        var promptAgentResourceResult = CreatePromptAgentResource();
        factoryAction?.Invoke(promptAgentResourceResult);

        return promptAgentResourceResult;
    }

    private Humidifier.Bedrock.PromptTypes.PromptAgentResource CreatePromptAgentResource()
    {
        var promptAgentResourceResult = new Humidifier.Bedrock.PromptTypes.PromptAgentResource();

        return promptAgentResourceResult;
    }

} // End Of Class

public static class InnerPromptPromptAgentResourceFactoryExtensions
{
}
