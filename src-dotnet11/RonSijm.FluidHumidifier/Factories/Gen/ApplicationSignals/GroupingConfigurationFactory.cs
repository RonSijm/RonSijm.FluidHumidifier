// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class GroupingConfigurationFactory(string resourceName = null, Action<Humidifier.ApplicationSignals.GroupingConfiguration> factoryAction = null) : ResourceFactory<Humidifier.ApplicationSignals.GroupingConfiguration>(resourceName)
{

    internal List<InnerGroupingConfigurationGroupingAttributeDefinitionFactory> GroupingAttributeDefinitionsFactories { get; set; } = [];

    protected override Humidifier.ApplicationSignals.GroupingConfiguration Create()
    {
        var groupingConfigurationResult = CreateGroupingConfiguration();
        factoryAction?.Invoke(groupingConfigurationResult);

        return groupingConfigurationResult;
    }

    private Humidifier.ApplicationSignals.GroupingConfiguration CreateGroupingConfiguration()
    {
        var groupingConfigurationResult = new Humidifier.ApplicationSignals.GroupingConfiguration
        {
            GivenName = InputResourceName,
        };

        return groupingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ApplicationSignals.GroupingConfiguration result)
    {
        base.CreateChildren(result);

        result.GroupingAttributeDefinitions = GroupingAttributeDefinitionsFactories.Any() ? GroupingAttributeDefinitionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class GroupingConfigurationFactoryExtensions
{
    public static CombinedResult<GroupingConfigurationFactory, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions(this GroupingConfigurationFactory parentFactory, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null)
    {
        var factory = new InnerGroupingConfigurationGroupingAttributeDefinitionFactory(subFactoryAction);
        parentFactory.GroupingAttributeDefinitionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GroupingConfigurationFactory, T1, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1>(this CombinedResult<GroupingConfigurationFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GroupingConfigurationFactory, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1>(this CombinedResult<T1, GroupingConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<GroupingConfigurationFactory, T1, T2, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2>(this CombinedResult<GroupingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GroupingConfigurationFactory, T2, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2>(this CombinedResult<T1, GroupingConfigurationFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GroupingConfigurationFactory, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2>(this CombinedResult<T1, T2, GroupingConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<GroupingConfigurationFactory, T1, T2, T3, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2, T3>(this CombinedResult<GroupingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GroupingConfigurationFactory, T2, T3, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2, T3>(this CombinedResult<T1, GroupingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GroupingConfigurationFactory, T3, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, GroupingConfigurationFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GroupingConfigurationFactory, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, T3, GroupingConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<GroupingConfigurationFactory, T1, T2, T3, T4, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2, T3, T4>(this CombinedResult<GroupingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GroupingConfigurationFactory, T2, T3, T4, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, GroupingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GroupingConfigurationFactory, T3, T4, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, GroupingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GroupingConfigurationFactory, T4, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GroupingConfigurationFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, GroupingConfigurationFactory, InnerGroupingConfigurationGroupingAttributeDefinitionFactory> WithGroupingAttributeDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GroupingConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupingAttributeDefinitions(combinedResult.T5, subFactoryAction).T2);
}
