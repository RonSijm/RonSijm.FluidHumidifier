// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleTimestampFactory(Action<Humidifier.IoT.TopicRuleTypes.Timestamp> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.Timestamp>
{

    protected override Humidifier.IoT.TopicRuleTypes.Timestamp Create()
    {
        var timestampResult = CreateTimestamp();
        factoryAction?.Invoke(timestampResult);

        return timestampResult;
    }

    private Humidifier.IoT.TopicRuleTypes.Timestamp CreateTimestamp()
    {
        var timestampResult = new Humidifier.IoT.TopicRuleTypes.Timestamp();

        return timestampResult;
    }

} // End Of Class

public static class InnerTopicRuleTimestampFactoryExtensions
{
}
