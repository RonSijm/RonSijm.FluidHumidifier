// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory(Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem>
{

    protected override Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem Create()
    {
        var flowAliasRoutingConfigurationListItemResult = CreateFlowAliasRoutingConfigurationListItem();
        factoryAction?.Invoke(flowAliasRoutingConfigurationListItemResult);

        return flowAliasRoutingConfigurationListItemResult;
    }

    private Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem CreateFlowAliasRoutingConfigurationListItem()
    {
        var flowAliasRoutingConfigurationListItemResult = new Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem();

        return flowAliasRoutingConfigurationListItemResult;
    }

} // End Of Class

public static class InnerFlowAliasFlowAliasRoutingConfigurationListItemFactoryExtensions
{
}
