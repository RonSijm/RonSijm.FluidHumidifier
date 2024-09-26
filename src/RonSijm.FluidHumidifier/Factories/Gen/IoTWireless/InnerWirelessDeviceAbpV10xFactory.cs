// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerWirelessDeviceAbpV10xFactory(Action<Humidifier.IoTWireless.WirelessDeviceTypes.AbpV10x> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.WirelessDeviceTypes.AbpV10x>
{

    internal InnerWirelessDeviceSessionKeysAbpV10xFactory SessionKeysFactory { get; set; }

    protected override Humidifier.IoTWireless.WirelessDeviceTypes.AbpV10x Create()
    {
        var abpV10xResult = CreateAbpV10x();
        factoryAction?.Invoke(abpV10xResult);

        return abpV10xResult;
    }

    private Humidifier.IoTWireless.WirelessDeviceTypes.AbpV10x CreateAbpV10x()
    {
        var abpV10xResult = new Humidifier.IoTWireless.WirelessDeviceTypes.AbpV10x();

        return abpV10xResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.WirelessDeviceTypes.AbpV10x result)
    {
        base.CreateChildren(result);

        result.SessionKeys ??= SessionKeysFactory?.Build();
    }

} // End Of Class

public static class InnerWirelessDeviceAbpV10xFactoryExtensions
{
    public static CombinedResult<InnerWirelessDeviceAbpV10xFactory, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys(this InnerWirelessDeviceAbpV10xFactory parentFactory, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null)
    {
        parentFactory.SessionKeysFactory = new InnerWirelessDeviceSessionKeysAbpV10xFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SessionKeysFactory);
    }

    public static CombinedResult<InnerWirelessDeviceAbpV10xFactory, T1, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1>(this CombinedResult<InnerWirelessDeviceAbpV10xFactory, T1> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWirelessDeviceAbpV10xFactory, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1>(this CombinedResult<T1, InnerWirelessDeviceAbpV10xFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWirelessDeviceAbpV10xFactory, T1, T2, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2>(this CombinedResult<InnerWirelessDeviceAbpV10xFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWirelessDeviceAbpV10xFactory, T2, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2>(this CombinedResult<T1, InnerWirelessDeviceAbpV10xFactory, T2> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWirelessDeviceAbpV10xFactory, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2>(this CombinedResult<T1, T2, InnerWirelessDeviceAbpV10xFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWirelessDeviceAbpV10xFactory, T1, T2, T3, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2, T3>(this CombinedResult<InnerWirelessDeviceAbpV10xFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWirelessDeviceAbpV10xFactory, T2, T3, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2, T3>(this CombinedResult<T1, InnerWirelessDeviceAbpV10xFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWirelessDeviceAbpV10xFactory, T3, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2, T3>(this CombinedResult<T1, T2, InnerWirelessDeviceAbpV10xFactory, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWirelessDeviceAbpV10xFactory, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWirelessDeviceAbpV10xFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWirelessDeviceAbpV10xFactory, T1, T2, T3, T4, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2, T3, T4>(this CombinedResult<InnerWirelessDeviceAbpV10xFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWirelessDeviceAbpV10xFactory, T2, T3, T4, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2, T3, T4>(this CombinedResult<T1, InnerWirelessDeviceAbpV10xFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWirelessDeviceAbpV10xFactory, T3, T4, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWirelessDeviceAbpV10xFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWirelessDeviceAbpV10xFactory, T4, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWirelessDeviceAbpV10xFactory, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWirelessDeviceAbpV10xFactory, InnerWirelessDeviceSessionKeysAbpV10xFactory> WithSessionKeys<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWirelessDeviceAbpV10xFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionKeys(combinedResult.T5, subFactoryAction));
}
