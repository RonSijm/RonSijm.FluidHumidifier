// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleKinesisActionFactory(Action<Humidifier.IoT.TopicRuleTypes.KinesisAction> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.KinesisAction>
{

    protected override Humidifier.IoT.TopicRuleTypes.KinesisAction Create()
    {
        var kinesisActionResult = CreateKinesisAction();
        factoryAction?.Invoke(kinesisActionResult);

        return kinesisActionResult;
    }

    private Humidifier.IoT.TopicRuleTypes.KinesisAction CreateKinesisAction()
    {
        var kinesisActionResult = new Humidifier.IoT.TopicRuleTypes.KinesisAction();

        return kinesisActionResult;
    }

} // End Of Class

public static class InnerTopicRuleKinesisActionFactoryExtensions
{
}
