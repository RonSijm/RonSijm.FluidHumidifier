// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerIntelligentPromptRouterRoutingCriteriaFactory(Action<Humidifier.Bedrock.IntelligentPromptRouterTypes.RoutingCriteria> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.IntelligentPromptRouterTypes.RoutingCriteria>
{

    protected override Humidifier.Bedrock.IntelligentPromptRouterTypes.RoutingCriteria Create()
    {
        var routingCriteriaResult = CreateRoutingCriteria();
        factoryAction?.Invoke(routingCriteriaResult);

        return routingCriteriaResult;
    }

    private Humidifier.Bedrock.IntelligentPromptRouterTypes.RoutingCriteria CreateRoutingCriteria()
    {
        var routingCriteriaResult = new Humidifier.Bedrock.IntelligentPromptRouterTypes.RoutingCriteria();

        return routingCriteriaResult;
    }

} // End Of Class

public static class InnerIntelligentPromptRouterRoutingCriteriaFactoryExtensions
{
}
