// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerThingTypeThingTypePropertiesFactory(Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> factoryAction = null) : SubResourceFactory<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties>
{

    internal InnerThingTypeMqtt5ConfigurationFactory Mqtt5ConfigurationFactory { get; set; }

    protected override Humidifier.IoT.ThingTypeTypes.ThingTypeProperties Create()
    {
        var thingTypePropertiesResult = CreateThingTypeProperties();
        factoryAction?.Invoke(thingTypePropertiesResult);

        return thingTypePropertiesResult;
    }

    private Humidifier.IoT.ThingTypeTypes.ThingTypeProperties CreateThingTypeProperties()
    {
        var thingTypePropertiesResult = new Humidifier.IoT.ThingTypeTypes.ThingTypeProperties();

        return thingTypePropertiesResult;
    }
    public override void CreateChildren(Humidifier.IoT.ThingTypeTypes.ThingTypeProperties result)
    {
        base.CreateChildren(result);

        result.Mqtt5Configuration ??= Mqtt5ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerThingTypeThingTypePropertiesFactoryExtensions
{
    public static CombinedResult<InnerThingTypeThingTypePropertiesFactory, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration(this InnerThingTypeThingTypePropertiesFactory parentFactory, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null)
    {
        parentFactory.Mqtt5ConfigurationFactory = new InnerThingTypeMqtt5ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Mqtt5ConfigurationFactory);
    }

    public static CombinedResult<InnerThingTypeThingTypePropertiesFactory, T1, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1>(this CombinedResult<InnerThingTypeThingTypePropertiesFactory, T1> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThingTypeThingTypePropertiesFactory, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1>(this CombinedResult<T1, InnerThingTypeThingTypePropertiesFactory> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerThingTypeThingTypePropertiesFactory, T1, T2, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2>(this CombinedResult<InnerThingTypeThingTypePropertiesFactory, T1, T2> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThingTypeThingTypePropertiesFactory, T2, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2>(this CombinedResult<T1, InnerThingTypeThingTypePropertiesFactory, T2> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThingTypeThingTypePropertiesFactory, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2>(this CombinedResult<T1, T2, InnerThingTypeThingTypePropertiesFactory> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerThingTypeThingTypePropertiesFactory, T1, T2, T3, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2, T3>(this CombinedResult<InnerThingTypeThingTypePropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThingTypeThingTypePropertiesFactory, T2, T3, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2, T3>(this CombinedResult<T1, InnerThingTypeThingTypePropertiesFactory, T2, T3> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThingTypeThingTypePropertiesFactory, T3, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerThingTypeThingTypePropertiesFactory, T3> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThingTypeThingTypePropertiesFactory, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThingTypeThingTypePropertiesFactory> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerThingTypeThingTypePropertiesFactory, T1, T2, T3, T4, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2, T3, T4>(this CombinedResult<InnerThingTypeThingTypePropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThingTypeThingTypePropertiesFactory, T2, T3, T4, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerThingTypeThingTypePropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThingTypeThingTypePropertiesFactory, T3, T4, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThingTypeThingTypePropertiesFactory, T3, T4> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThingTypeThingTypePropertiesFactory, T4, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThingTypeThingTypePropertiesFactory, T4> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerThingTypeThingTypePropertiesFactory, InnerThingTypeMqtt5ConfigurationFactory> WithMqtt5Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThingTypeThingTypePropertiesFactory> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMqtt5Configuration(combinedResult.T5, subFactoryAction));
}
