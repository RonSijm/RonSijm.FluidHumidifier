// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberTransformerFactory(Action<Humidifier.EventsV2.SubscriberTypes.Transformer> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.Transformer>
{

    internal InnerSubscriberJsonataConfigurationFactory JsonataConfigurationFactory { get; set; }

    protected override Humidifier.EventsV2.SubscriberTypes.Transformer Create()
    {
        var transformerResult = CreateTransformer();
        factoryAction?.Invoke(transformerResult);

        return transformerResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.Transformer CreateTransformer()
    {
        var transformerResult = new Humidifier.EventsV2.SubscriberTypes.Transformer();

        return transformerResult;
    }
    public override void CreateChildren(Humidifier.EventsV2.SubscriberTypes.Transformer result)
    {
        base.CreateChildren(result);

        result.JsonataConfiguration ??= JsonataConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerSubscriberTransformerFactoryExtensions
{
    public static CombinedResult<InnerSubscriberTransformerFactory, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration(this InnerSubscriberTransformerFactory parentFactory, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null)
    {
        parentFactory.JsonataConfigurationFactory = new InnerSubscriberJsonataConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JsonataConfigurationFactory);
    }

    public static CombinedResult<InnerSubscriberTransformerFactory, T1, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1>(this CombinedResult<InnerSubscriberTransformerFactory, T1> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSubscriberTransformerFactory, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1>(this CombinedResult<T1, InnerSubscriberTransformerFactory> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSubscriberTransformerFactory, T1, T2, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2>(this CombinedResult<InnerSubscriberTransformerFactory, T1, T2> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSubscriberTransformerFactory, T2, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2>(this CombinedResult<T1, InnerSubscriberTransformerFactory, T2> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSubscriberTransformerFactory, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerSubscriberTransformerFactory> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSubscriberTransformerFactory, T1, T2, T3, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2, T3>(this CombinedResult<InnerSubscriberTransformerFactory, T1, T2, T3> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSubscriberTransformerFactory, T2, T3, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerSubscriberTransformerFactory, T2, T3> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSubscriberTransformerFactory, T3, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerSubscriberTransformerFactory, T3> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSubscriberTransformerFactory, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSubscriberTransformerFactory> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSubscriberTransformerFactory, T1, T2, T3, T4, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerSubscriberTransformerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSubscriberTransformerFactory, T2, T3, T4, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerSubscriberTransformerFactory, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSubscriberTransformerFactory, T3, T4, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSubscriberTransformerFactory, T3, T4> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSubscriberTransformerFactory, T4, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSubscriberTransformerFactory, T4> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSubscriberTransformerFactory, InnerSubscriberJsonataConfigurationFactory> WithJsonataConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSubscriberTransformerFactory> combinedResult, Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJsonataConfiguration(combinedResult.T5, subFactoryAction).T2);
}
