// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleElasticsearchActionFactory(Action<Humidifier.IoT.TopicRuleTypes.ElasticsearchAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.ElasticsearchAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.ElasticsearchAction Create()
    {
        var elasticsearchActionResult = CreateElasticsearchAction();
        factoryAction?.Invoke(elasticsearchActionResult);

        return elasticsearchActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.ElasticsearchAction CreateElasticsearchAction()
    {
        var elasticsearchActionResult = new Humidifier.IoT.TopicRuleTypes.ElasticsearchAction();

        return elasticsearchActionResult;
    }

} // End Of Class

public static class InnerTopicRuleElasticsearchActionFactoryExtensions
{
}
