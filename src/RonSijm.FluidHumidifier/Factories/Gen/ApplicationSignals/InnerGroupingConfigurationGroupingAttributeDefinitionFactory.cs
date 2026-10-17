// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerGroupingConfigurationGroupingAttributeDefinitionFactory(Action<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition>
{

    protected override Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition Create()
    {
        var groupingAttributeDefinitionResult = CreateGroupingAttributeDefinition();
        factoryAction?.Invoke(groupingAttributeDefinitionResult);

        return groupingAttributeDefinitionResult;
    }

    private Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition CreateGroupingAttributeDefinition()
    {
        var groupingAttributeDefinitionResult = new Humidifier.ApplicationSignals.GroupingConfigurationTypes.GroupingAttributeDefinition();

        return groupingAttributeDefinitionResult;
    }

} // End Of Class

public static class InnerGroupingConfigurationGroupingAttributeDefinitionFactoryExtensions
{
}
