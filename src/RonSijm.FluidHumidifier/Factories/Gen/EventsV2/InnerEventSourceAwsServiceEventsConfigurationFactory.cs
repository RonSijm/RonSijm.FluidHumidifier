// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerEventSourceAwsServiceEventsConfigurationFactory(Action<Humidifier.EventsV2.EventSourceTypes.AwsServiceEventsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.EventSourceTypes.AwsServiceEventsConfiguration>
{

    internal InnerEventSourceOnFailureConfigurationFactory OnFailureConfigurationFactory { get; set; }

    protected override Humidifier.EventsV2.EventSourceTypes.AwsServiceEventsConfiguration Create()
    {
        var awsServiceEventsConfigurationResult = CreateAwsServiceEventsConfiguration();
        factoryAction?.Invoke(awsServiceEventsConfigurationResult);

        return awsServiceEventsConfigurationResult;
    }

    private Humidifier.EventsV2.EventSourceTypes.AwsServiceEventsConfiguration CreateAwsServiceEventsConfiguration()
    {
        var awsServiceEventsConfigurationResult = new Humidifier.EventsV2.EventSourceTypes.AwsServiceEventsConfiguration();

        return awsServiceEventsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.EventsV2.EventSourceTypes.AwsServiceEventsConfiguration result)
    {
        base.CreateChildren(result);

        result.OnFailureConfiguration ??= OnFailureConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerEventSourceAwsServiceEventsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerEventSourceAwsServiceEventsConfigurationFactory, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration(this InnerEventSourceAwsServiceEventsConfigurationFactory parentFactory, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null)
    {
        parentFactory.OnFailureConfigurationFactory = new InnerEventSourceOnFailureConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OnFailureConfigurationFactory);
    }

    public static CombinedResult<InnerEventSourceAwsServiceEventsConfigurationFactory, T1, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1>(this CombinedResult<InnerEventSourceAwsServiceEventsConfigurationFactory, T1> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceAwsServiceEventsConfigurationFactory, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1>(this CombinedResult<T1, InnerEventSourceAwsServiceEventsConfigurationFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourceAwsServiceEventsConfigurationFactory, T1, T2, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2>(this CombinedResult<InnerEventSourceAwsServiceEventsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceAwsServiceEventsConfigurationFactory, T2, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2>(this CombinedResult<T1, InnerEventSourceAwsServiceEventsConfigurationFactory, T2> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourceAwsServiceEventsConfigurationFactory, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerEventSourceAwsServiceEventsConfigurationFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourceAwsServiceEventsConfigurationFactory, T1, T2, T3, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3>(this CombinedResult<InnerEventSourceAwsServiceEventsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceAwsServiceEventsConfigurationFactory, T2, T3, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerEventSourceAwsServiceEventsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourceAwsServiceEventsConfigurationFactory, T3, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerEventSourceAwsServiceEventsConfigurationFactory, T3> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventSourceAwsServiceEventsConfigurationFactory, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEventSourceAwsServiceEventsConfigurationFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourceAwsServiceEventsConfigurationFactory, T1, T2, T3, T4, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerEventSourceAwsServiceEventsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourceAwsServiceEventsConfigurationFactory, T2, T3, T4, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerEventSourceAwsServiceEventsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourceAwsServiceEventsConfigurationFactory, T3, T4, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEventSourceAwsServiceEventsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventSourceAwsServiceEventsConfigurationFactory, T4, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEventSourceAwsServiceEventsConfigurationFactory, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEventSourceAwsServiceEventsConfigurationFactory, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEventSourceAwsServiceEventsConfigurationFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T5, subFactoryAction).T2);
}
