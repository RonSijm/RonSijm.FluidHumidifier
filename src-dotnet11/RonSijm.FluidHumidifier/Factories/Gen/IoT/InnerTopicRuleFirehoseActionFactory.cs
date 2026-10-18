// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleFirehoseActionFactory(Action<Humidifier.IoT.TopicRuleTypes.FirehoseAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.FirehoseAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.FirehoseAction Create()
    {
        var firehoseActionResult = CreateFirehoseAction();
        factoryAction?.Invoke(firehoseActionResult);

        return firehoseActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.FirehoseAction CreateFirehoseAction()
    {
        var firehoseActionResult = new Humidifier.IoT.TopicRuleTypes.FirehoseAction();

        return firehoseActionResult;
    }

} // End Of Class

public static class InnerTopicRuleFirehoseActionFactoryExtensions
{
}
