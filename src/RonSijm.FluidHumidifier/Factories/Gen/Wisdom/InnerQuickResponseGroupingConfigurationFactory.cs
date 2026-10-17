// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerQuickResponseGroupingConfigurationFactory(Action<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration>
{

    protected override Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration Create()
    {
        var groupingConfigurationResult = CreateGroupingConfiguration();
        factoryAction?.Invoke(groupingConfigurationResult);

        return groupingConfigurationResult;
    }

    private Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration CreateGroupingConfiguration()
    {
        var groupingConfigurationResult = new Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration();

        return groupingConfigurationResult;
    }

} // End Of Class

public static class InnerQuickResponseGroupingConfigurationFactoryExtensions
{
}
