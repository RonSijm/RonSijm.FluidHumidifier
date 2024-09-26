// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleKafkaActionFactory(Action<Humidifier.IoT.TopicRuleTypes.KafkaAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.KafkaAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.KafkaAction Create()
    {
        var kafkaActionResult = CreateKafkaAction();
        factoryAction?.Invoke(kafkaActionResult);

        return kafkaActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.KafkaAction CreateKafkaAction()
    {
        var kafkaActionResult = new Humidifier.IoT.TopicRuleTypes.KafkaAction();

        return kafkaActionResult;
    }

} // End Of Class

public static class InnerTopicRuleKafkaActionFactoryExtensions
{
}
