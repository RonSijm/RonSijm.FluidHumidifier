// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class DeviceProfileFactory(string resourceName = null, Action<Humidifier.IoTWireless.DeviceProfile> factoryAction = null) : ResourceFactory<Humidifier.IoTWireless.DeviceProfile>(resourceName)
{

    internal InnerDeviceProfileLoRaWANDeviceProfileFactory LoRaWANFactory { get; set; }

    protected override Humidifier.IoTWireless.DeviceProfile Create()
    {
        var deviceProfileResult = CreateDeviceProfile();
        factoryAction?.Invoke(deviceProfileResult);

        return deviceProfileResult;
    }

    private Humidifier.IoTWireless.DeviceProfile CreateDeviceProfile()
    {
        var deviceProfileResult = new Humidifier.IoTWireless.DeviceProfile
        {
            GivenName = InputResourceName,
        };

        return deviceProfileResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.DeviceProfile result)
    {
        base.CreateChildren(result);

        result.LoRaWAN ??= LoRaWANFactory?.Build();
    }

} // End Of Class

public static class DeviceProfileFactoryExtensions
{
    public static CombinedResult<DeviceProfileFactory, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN(this DeviceProfileFactory parentFactory, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null)
    {
        parentFactory.LoRaWANFactory = new InnerDeviceProfileLoRaWANDeviceProfileFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoRaWANFactory);
    }

    public static CombinedResult<DeviceProfileFactory, T1, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1>(this CombinedResult<DeviceProfileFactory, T1> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceProfileFactory, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1>(this CombinedResult<T1, DeviceProfileFactory> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeviceProfileFactory, T1, T2, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2>(this CombinedResult<DeviceProfileFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceProfileFactory, T2, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, DeviceProfileFactory, T2> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceProfileFactory, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, T2, DeviceProfileFactory> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeviceProfileFactory, T1, T2, T3, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<DeviceProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceProfileFactory, T2, T3, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, DeviceProfileFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceProfileFactory, T3, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, DeviceProfileFactory, T3> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceProfileFactory, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeviceProfileFactory> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeviceProfileFactory, T1, T2, T3, T4, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<DeviceProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceProfileFactory, T2, T3, T4, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, DeviceProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceProfileFactory, T3, T4, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeviceProfileFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceProfileFactory, T4, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeviceProfileFactory, T4> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeviceProfileFactory, InnerDeviceProfileLoRaWANDeviceProfileFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeviceProfileFactory> combinedResult, Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T5, subFactoryAction));
}
