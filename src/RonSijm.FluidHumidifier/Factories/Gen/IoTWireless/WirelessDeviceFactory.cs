// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class WirelessDeviceFactory(string resourceName = null, Action<Humidifier.IoTWireless.WirelessDevice> factoryAction = null) : ResourceFactory<Humidifier.IoTWireless.WirelessDevice>(resourceName)
{

    internal InnerWirelessDeviceLoRaWANDeviceFactory LoRaWANFactory { get; set; }

    protected override Humidifier.IoTWireless.WirelessDevice Create()
    {
        var wirelessDeviceResult = CreateWirelessDevice();
        factoryAction?.Invoke(wirelessDeviceResult);

        return wirelessDeviceResult;
    }

    private Humidifier.IoTWireless.WirelessDevice CreateWirelessDevice()
    {
        var wirelessDeviceResult = new Humidifier.IoTWireless.WirelessDevice
        {
            GivenName = InputResourceName,
        };

        return wirelessDeviceResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.WirelessDevice result)
    {
        base.CreateChildren(result);

        result.LoRaWAN ??= LoRaWANFactory?.Build();
    }

} // End Of Class

public static class WirelessDeviceFactoryExtensions
{
    public static CombinedResult<WirelessDeviceFactory, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN(this WirelessDeviceFactory parentFactory, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null)
    {
        parentFactory.LoRaWANFactory = new InnerWirelessDeviceLoRaWANDeviceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoRaWANFactory);
    }

    public static CombinedResult<WirelessDeviceFactory, T1, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1>(this CombinedResult<WirelessDeviceFactory, T1> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessDeviceFactory, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1>(this CombinedResult<T1, WirelessDeviceFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WirelessDeviceFactory, T1, T2, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2>(this CombinedResult<WirelessDeviceFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessDeviceFactory, T2, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, WirelessDeviceFactory, T2> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WirelessDeviceFactory, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, T2, WirelessDeviceFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WirelessDeviceFactory, T1, T2, T3, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<WirelessDeviceFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessDeviceFactory, T2, T3, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, WirelessDeviceFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WirelessDeviceFactory, T3, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, WirelessDeviceFactory, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WirelessDeviceFactory, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, T3, WirelessDeviceFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WirelessDeviceFactory, T1, T2, T3, T4, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<WirelessDeviceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessDeviceFactory, T2, T3, T4, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, WirelessDeviceFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WirelessDeviceFactory, T3, T4, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, WirelessDeviceFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WirelessDeviceFactory, T4, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WirelessDeviceFactory, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WirelessDeviceFactory, InnerWirelessDeviceLoRaWANDeviceFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WirelessDeviceFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T5, subFactoryAction));
}
