// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class TopicRuleDestinationFactory(string resourceName = null, Action<Humidifier.IoT.TopicRuleDestination> factoryAction = null) : ResourceFactory<Humidifier.IoT.TopicRuleDestination>(resourceName)
{

    internal InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory HttpUrlPropertiesFactory { get; set; }

    internal InnerTopicRuleDestinationVpcDestinationPropertiesFactory VpcPropertiesFactory { get; set; }

    protected override Humidifier.IoT.TopicRuleDestination Create()
    {
        var topicRuleDestinationResult = CreateTopicRuleDestination();
        factoryAction?.Invoke(topicRuleDestinationResult);

        return topicRuleDestinationResult;
    }

    private Humidifier.IoT.TopicRuleDestination CreateTopicRuleDestination()
    {
        var topicRuleDestinationResult = new Humidifier.IoT.TopicRuleDestination
        {
            GivenName = InputResourceName,
        };

        return topicRuleDestinationResult;
    }
    public override void CreateChildren(Humidifier.IoT.TopicRuleDestination result)
    {
        base.CreateChildren(result);

        result.HttpUrlProperties ??= HttpUrlPropertiesFactory?.Build();
        result.VpcProperties ??= VpcPropertiesFactory?.Build();
    }

} // End Of Class

public static class TopicRuleDestinationFactoryExtensions
{
    public static CombinedResult<TopicRuleDestinationFactory, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties(this TopicRuleDestinationFactory parentFactory, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null)
    {
        parentFactory.HttpUrlPropertiesFactory = new InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HttpUrlPropertiesFactory);
    }

    public static CombinedResult<TopicRuleDestinationFactory, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties(this TopicRuleDestinationFactory parentFactory, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null)
    {
        parentFactory.VpcPropertiesFactory = new InnerTopicRuleDestinationVpcDestinationPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcPropertiesFactory);
    }

    public static CombinedResult<TopicRuleDestinationFactory, T1, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1>(this CombinedResult<TopicRuleDestinationFactory, T1> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleDestinationFactory, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1>(this CombinedResult<T1, TopicRuleDestinationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TopicRuleDestinationFactory, T1, T2, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2>(this CombinedResult<TopicRuleDestinationFactory, T1, T2> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleDestinationFactory, T2, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2>(this CombinedResult<T1, TopicRuleDestinationFactory, T2> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicRuleDestinationFactory, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2>(this CombinedResult<T1, T2, TopicRuleDestinationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TopicRuleDestinationFactory, T1, T2, T3, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2, T3>(this CombinedResult<TopicRuleDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleDestinationFactory, T2, T3, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2, T3>(this CombinedResult<T1, TopicRuleDestinationFactory, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicRuleDestinationFactory, T3, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2, T3>(this CombinedResult<T1, T2, TopicRuleDestinationFactory, T3> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TopicRuleDestinationFactory, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, TopicRuleDestinationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TopicRuleDestinationFactory, T1, T2, T3, T4, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2, T3, T4>(this CombinedResult<TopicRuleDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleDestinationFactory, T2, T3, T4, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2, T3, T4>(this CombinedResult<T1, TopicRuleDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicRuleDestinationFactory, T3, T4, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, TopicRuleDestinationFactory, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TopicRuleDestinationFactory, T4, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TopicRuleDestinationFactory, T4> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TopicRuleDestinationFactory, InnerTopicRuleDestinationHttpUrlDestinationSummaryFactory> WithHttpUrlProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TopicRuleDestinationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpUrlProperties(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TopicRuleDestinationFactory, T1, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1>(this CombinedResult<TopicRuleDestinationFactory, T1> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleDestinationFactory, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1>(this CombinedResult<T1, TopicRuleDestinationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TopicRuleDestinationFactory, T1, T2, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2>(this CombinedResult<TopicRuleDestinationFactory, T1, T2> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleDestinationFactory, T2, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2>(this CombinedResult<T1, TopicRuleDestinationFactory, T2> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicRuleDestinationFactory, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2>(this CombinedResult<T1, T2, TopicRuleDestinationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TopicRuleDestinationFactory, T1, T2, T3, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2, T3>(this CombinedResult<TopicRuleDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleDestinationFactory, T2, T3, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2, T3>(this CombinedResult<T1, TopicRuleDestinationFactory, T2, T3> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicRuleDestinationFactory, T3, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2, T3>(this CombinedResult<T1, T2, TopicRuleDestinationFactory, T3> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TopicRuleDestinationFactory, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, TopicRuleDestinationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TopicRuleDestinationFactory, T1, T2, T3, T4, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2, T3, T4>(this CombinedResult<TopicRuleDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicRuleDestinationFactory, T2, T3, T4, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2, T3, T4>(this CombinedResult<T1, TopicRuleDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicRuleDestinationFactory, T3, T4, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, TopicRuleDestinationFactory, T3, T4> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TopicRuleDestinationFactory, T4, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TopicRuleDestinationFactory, T4> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TopicRuleDestinationFactory, InnerTopicRuleDestinationVpcDestinationPropertiesFactory> WithVpcProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TopicRuleDestinationFactory> combinedResult, Action<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcProperties(combinedResult.T5, subFactoryAction));
}
