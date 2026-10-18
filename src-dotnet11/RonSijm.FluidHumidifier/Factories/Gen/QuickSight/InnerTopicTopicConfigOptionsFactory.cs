// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTopicTopicConfigOptionsFactory(Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TopicTypes.TopicConfigOptions>
{

    protected override Humidifier.QuickSight.TopicTypes.TopicConfigOptions Create()
    {
        var topicConfigOptionsResult = CreateTopicConfigOptions();
        factoryAction?.Invoke(topicConfigOptionsResult);

        return topicConfigOptionsResult;
    }

    private Humidifier.QuickSight.TopicTypes.TopicConfigOptions CreateTopicConfigOptions()
    {
        var topicConfigOptionsResult = new Humidifier.QuickSight.TopicTypes.TopicConfigOptions();

        return topicConfigOptionsResult;
    }

} // End Of Class

public static class InnerTopicTopicConfigOptionsFactoryExtensions
{
}
