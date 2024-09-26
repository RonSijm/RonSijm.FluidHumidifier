// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleTimestreamTimestampFactory(Action<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp>
{

    protected override Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp Create()
    {
        var timestreamTimestampResult = CreateTimestreamTimestamp();
        factoryAction?.Invoke(timestreamTimestampResult);

        return timestreamTimestampResult;
    }

    private Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp CreateTimestreamTimestamp()
    {
        var timestreamTimestampResult = new Humidifier.IoT.TopicRuleTypes.TimestreamTimestamp();

        return timestreamTimestampResult;
    }

} // End Of Class

public static class InnerTopicRuleTimestreamTimestampFactoryExtensions
{
}
