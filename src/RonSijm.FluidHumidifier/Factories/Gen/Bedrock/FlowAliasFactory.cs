// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class FlowAliasFactory(string resourceName = null, Action<Humidifier.Bedrock.FlowAlias> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.FlowAlias>(resourceName)
{

    internal List<InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> RoutingConfigurationFactories { get; set; } = [];

    protected override Humidifier.Bedrock.FlowAlias Create()
    {
        var flowAliasResult = CreateFlowAlias();
        factoryAction?.Invoke(flowAliasResult);

        return flowAliasResult;
    }

    private Humidifier.Bedrock.FlowAlias CreateFlowAlias()
    {
        var flowAliasResult = new Humidifier.Bedrock.FlowAlias
        {
            GivenName = InputResourceName,
        };

        return flowAliasResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.FlowAlias result)
    {
        base.CreateChildren(result);

        result.RoutingConfiguration = RoutingConfigurationFactories.Any() ? RoutingConfigurationFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class FlowAliasFactoryExtensions
{
    public static CombinedResult<FlowAliasFactory, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration(this FlowAliasFactory parentFactory, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null)
    {
        var factory = new InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory(subFactoryAction);
        parentFactory.RoutingConfigurationFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FlowAliasFactory, T1, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1>(this CombinedResult<FlowAliasFactory, T1> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowAliasFactory, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1>(this CombinedResult<T1, FlowAliasFactory> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FlowAliasFactory, T1, T2, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2>(this CombinedResult<FlowAliasFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowAliasFactory, T2, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2>(this CombinedResult<T1, FlowAliasFactory, T2> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowAliasFactory, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2>(this CombinedResult<T1, T2, FlowAliasFactory> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FlowAliasFactory, T1, T2, T3, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<FlowAliasFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowAliasFactory, T2, T3, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, FlowAliasFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowAliasFactory, T3, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, FlowAliasFactory, T3> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowAliasFactory, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlowAliasFactory> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FlowAliasFactory, T1, T2, T3, T4, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<FlowAliasFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowAliasFactory, T2, T3, T4, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, FlowAliasFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowAliasFactory, T3, T4, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlowAliasFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowAliasFactory, T4, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlowAliasFactory, T4> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FlowAliasFactory, InnerFlowAliasFlowAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlowAliasFactory> combinedResult, Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T5, subFactoryAction));
}
