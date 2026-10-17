// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerEventSourcePartnerEventsConfigurationFactory(Action<Humidifier.EventsV2.EventSourceTypes.PartnerEventsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.EventSourceTypes.PartnerEventsConfiguration>
{

    internal InnerEventSourceOnFailureConfigurationFactory OnFailureConfigurationFactory { get; set; }

    protected override Humidifier.EventsV2.EventSourceTypes.PartnerEventsConfiguration Create()
    {
        var partnerEventsConfigurationResult = CreatePartnerEventsConfiguration();
        factoryAction?.Invoke(partnerEventsConfigurationResult);

        return partnerEventsConfigurationResult;
    }

    private Humidifier.EventsV2.EventSourceTypes.PartnerEventsConfiguration CreatePartnerEventsConfiguration()
    {
        var partnerEventsConfigurationResult = new Humidifier.EventsV2.EventSourceTypes.PartnerEventsConfiguration();

        return partnerEventsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.EventsV2.EventSourceTypes.PartnerEventsConfiguration result)
    {
        base.CreateChildren(result);

        result.OnFailureConfiguration ??= OnFailureConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerEventSourcePartnerEventsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerEventSourcePartnerEventsConfigurationFactory, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration(this InnerEventSourcePartnerEventsConfigurationFactory parentFactory, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null)
    {
        parentFactory.OnFailureConfigurationFactory = new InnerEventSourceOnFailureConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OnFailureConfigurationFactory);
    }

    public static CombinedResult<InnerEventSourcePartnerEventsConfigurationFactory, T1, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1>(this CombinedResult<InnerEventSourcePartnerEventsConfigurationFactory, T1> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourcePartnerEventsConfigurationFactory, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1>(this CombinedResult<T1, InnerEventSourcePartnerEventsConfigurationFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourcePartnerEventsConfigurationFactory, T1, T2, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2>(this CombinedResult<InnerEventSourcePartnerEventsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourcePartnerEventsConfigurationFactory, T2, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2>(this CombinedResult<T1, InnerEventSourcePartnerEventsConfigurationFactory, T2> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourcePartnerEventsConfigurationFactory, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerEventSourcePartnerEventsConfigurationFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourcePartnerEventsConfigurationFactory, T1, T2, T3, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3>(this CombinedResult<InnerEventSourcePartnerEventsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourcePartnerEventsConfigurationFactory, T2, T3, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerEventSourcePartnerEventsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourcePartnerEventsConfigurationFactory, T3, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerEventSourcePartnerEventsConfigurationFactory, T3> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventSourcePartnerEventsConfigurationFactory, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEventSourcePartnerEventsConfigurationFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEventSourcePartnerEventsConfigurationFactory, T1, T2, T3, T4, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerEventSourcePartnerEventsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventSourcePartnerEventsConfigurationFactory, T2, T3, T4, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerEventSourcePartnerEventsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventSourcePartnerEventsConfigurationFactory, T3, T4, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEventSourcePartnerEventsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventSourcePartnerEventsConfigurationFactory, T4, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEventSourcePartnerEventsConfigurationFactory, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEventSourcePartnerEventsConfigurationFactory, InnerEventSourceOnFailureConfigurationFactory> WithOnFailureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEventSourcePartnerEventsConfigurationFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailureConfiguration(combinedResult.T5, subFactoryAction).T2);
}
