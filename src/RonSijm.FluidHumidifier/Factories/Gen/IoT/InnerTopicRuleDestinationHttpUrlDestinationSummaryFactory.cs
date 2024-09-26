// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory(Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> factoryAction = null) : SubResourceFactory<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary>
{

    protected override Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary Create()
    {
        var httpUrlDestinationSummaryResult = CreateHttpUrlDestinationSummary();
        factoryAction?.Invoke(httpUrlDestinationSummaryResult);

        return httpUrlDestinationSummaryResult;
    }

    private Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary CreateHttpUrlDestinationSummary()
    {
        var httpUrlDestinationSummaryResult = new Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary();

        return httpUrlDestinationSummaryResult;
    }

} // End Of Class

public static class InnerTopicRuleDestinationHttpUrlDestinationSummaryFactoryExtensions
{
}
