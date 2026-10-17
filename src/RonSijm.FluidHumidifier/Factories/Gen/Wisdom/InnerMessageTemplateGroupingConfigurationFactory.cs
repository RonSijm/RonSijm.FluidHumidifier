// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerMessageTemplateGroupingConfigurationFactory(Action<Humidifier.Wisdom.MessageTemplateTypes.GroupingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.MessageTemplateTypes.GroupingConfiguration>
{

    protected override Humidifier.Wisdom.MessageTemplateTypes.GroupingConfiguration Create()
    {
        var groupingConfigurationResult = CreateGroupingConfiguration();
        factoryAction?.Invoke(groupingConfigurationResult);

        return groupingConfigurationResult;
    }

    private Humidifier.Wisdom.MessageTemplateTypes.GroupingConfiguration CreateGroupingConfiguration()
    {
        var groupingConfigurationResult = new Humidifier.Wisdom.MessageTemplateTypes.GroupingConfiguration();

        return groupingConfigurationResult;
    }

} // End Of Class

public static class InnerMessageTemplateGroupingConfigurationFactoryExtensions
{
}
