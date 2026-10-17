// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerIntelligentPromptRouterPromptRouterTargetModelFactory(Action<Humidifier.Bedrock.IntelligentPromptRouterTypes.PromptRouterTargetModel> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.IntelligentPromptRouterTypes.PromptRouterTargetModel>
{

    protected override Humidifier.Bedrock.IntelligentPromptRouterTypes.PromptRouterTargetModel Create()
    {
        var promptRouterTargetModelResult = CreatePromptRouterTargetModel();
        factoryAction?.Invoke(promptRouterTargetModelResult);

        return promptRouterTargetModelResult;
    }

    private Humidifier.Bedrock.IntelligentPromptRouterTypes.PromptRouterTargetModel CreatePromptRouterTargetModel()
    {
        var promptRouterTargetModelResult = new Humidifier.Bedrock.IntelligentPromptRouterTypes.PromptRouterTargetModel();

        return promptRouterTargetModelResult;
    }

} // End Of Class

public static class InnerIntelligentPromptRouterPromptRouterTargetModelFactoryExtensions
{
}
