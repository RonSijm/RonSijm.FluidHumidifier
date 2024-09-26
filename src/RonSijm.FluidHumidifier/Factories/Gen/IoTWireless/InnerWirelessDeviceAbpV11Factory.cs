// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerWirelessDeviceAbpV11Factory(Action<Humidifier.IoTWireless.WirelessDeviceTypes.AbpV11> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.WirelessDeviceTypes.AbpV11>
{

    internal InnerWirelessDeviceSessionKeysAbpV11Factory SessionKeysFactory { get; set; }

    protected override Humidifier.IoTWireless.WirelessDeviceTypes.AbpV11 Create()
    {
        var abpV11Result = CreateAbpV11();
        factoryAction?.Invoke(abpV11Result);

        return abpV11Result;
    }

    private Humidifier.IoTWireless.WirelessDeviceTypes.AbpV11 CreateAbpV11()
    {
        var abpV11Result = new Humidifier.IoTWireless.WirelessDeviceTypes.AbpV11();

        return abpV11Result;
    }
    public override void CreateChildren(Humidifier.IoTWireless.WirelessDeviceTypes.AbpV11 result)
    {
        base.CreateChildren(result);

        result.SessionKeys ??= SessionKeysFactory?.Build();
    }

} // End Of Class

public static class InnerWirelessDeviceAbpV11FactoryExtensions
{
    public static CombinedResult<InnerWirelessDeviceAbpV11Factory, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys(this InnerWirelessDeviceAbpV11Factory parentFactory, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null)
    {
        parentFactory.SessionKeysFactory = new InnerWirelessDeviceSessionKeysAbpV11Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SessionKeysFactory);
    }

    public static CombinedResult<InnerWirelessDeviceAbpV11Factory, T1, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1>(this CombinedResult<InnerWirelessDeviceAbpV11Factory, T1> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWirelessDeviceAbpV11Factory, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1>(this CombinedResult<T1, InnerWirelessDeviceAbpV11Factory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWirelessDeviceAbpV11Factory, T1, T2, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2>(this CombinedResult<InnerWirelessDeviceAbpV11Factory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWirelessDeviceAbpV11Factory, T2, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2>(this CombinedResult<T1, InnerWirelessDeviceAbpV11Factory, T2> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWirelessDeviceAbpV11Factory, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2>(this CombinedResult<T1, T2, InnerWirelessDeviceAbpV11Factory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWirelessDeviceAbpV11Factory, T1, T2, T3, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2, T3>(this CombinedResult<InnerWirelessDeviceAbpV11Factory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWirelessDeviceAbpV11Factory, T2, T3, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2, T3>(this CombinedResult<T1, InnerWirelessDeviceAbpV11Factory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWirelessDeviceAbpV11Factory, T3, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2, T3>(this CombinedResult<T1, T2, InnerWirelessDeviceAbpV11Factory, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWirelessDeviceAbpV11Factory, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWirelessDeviceAbpV11Factory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWirelessDeviceAbpV11Factory, T1, T2, T3, T4, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2, T3, T4>(this CombinedResult<InnerWirelessDeviceAbpV11Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWirelessDeviceAbpV11Factory, T2, T3, T4, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2, T3, T4>(this CombinedResult<T1, InnerWirelessDeviceAbpV11Factory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWirelessDeviceAbpV11Factory, T3, T4, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWirelessDeviceAbpV11Factory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWirelessDeviceAbpV11Factory, T4, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWirelessDeviceAbpV11Factory, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWirelessDeviceAbpV11Factory, InnerWirelessDeviceSessionKeysAbpV11Factory> WithSessionKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWirelessDeviceAbpV11Factory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T5, subFactoryAction));
}
