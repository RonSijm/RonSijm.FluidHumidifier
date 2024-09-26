// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class DeviceDefinitionVersionFactory(string resourceName = null, Action<Humidifier.Greengrass.DeviceDefinitionVersion> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.DeviceDefinitionVersion>(resourceName)
{

    internal List<InnerDeviceDefinitionVersionDeviceFactory> DevicesFactories { get; set; } = [];

    protected override Humidifier.Greengrass.DeviceDefinitionVersion Create()
    {
        var deviceDefinitionVersionResult = CreateDeviceDefinitionVersion();
        factoryAction?.Invoke(deviceDefinitionVersionResult);

        return deviceDefinitionVersionResult;
    }

    private Humidifier.Greengrass.DeviceDefinitionVersion CreateDeviceDefinitionVersion()
    {
        var deviceDefinitionVersionResult = new Humidifier.Greengrass.DeviceDefinitionVersion
        {
            GivenName = InputResourceName,
        };

        return deviceDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.DeviceDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Devices = DevicesFactories.Any() ? DevicesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DeviceDefinitionVersionFactoryExtensions
{
    public static CombinedResult<DeviceDefinitionVersionFactory, InnerDeviceDefinitionVersionDeviceFactory> WithDevices(this DeviceDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null)
    {
        var factory = new InnerDeviceDefinitionVersionDeviceFactory(subFactoryAction);
        parentFactory.DevicesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DeviceDefinitionVersionFactory, T1, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1>(this CombinedResult<DeviceDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, WithDevices(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceDefinitionVersionFactory, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1>(this CombinedResult<T1, DeviceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, WithDevices(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeviceDefinitionVersionFactory, T1, T2, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2>(this CombinedResult<DeviceDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceDefinitionVersionFactory, T2, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2>(this CombinedResult<T1, DeviceDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceDefinitionVersionFactory, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2>(this CombinedResult<T1, T2, DeviceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeviceDefinitionVersionFactory, T1, T2, T3, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2, T3>(this CombinedResult<DeviceDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceDefinitionVersionFactory, T2, T3, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2, T3>(this CombinedResult<T1, DeviceDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceDefinitionVersionFactory, T3, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2, T3>(this CombinedResult<T1, T2, DeviceDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceDefinitionVersionFactory, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeviceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeviceDefinitionVersionFactory, T1, T2, T3, T4, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2, T3, T4>(this CombinedResult<DeviceDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceDefinitionVersionFactory, T2, T3, T4, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2, T3, T4>(this CombinedResult<T1, DeviceDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceDefinitionVersionFactory, T3, T4, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeviceDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceDefinitionVersionFactory, T4, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeviceDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeviceDefinitionVersionFactory, InnerDeviceDefinitionVersionDeviceFactory> WithDevices<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeviceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T5, subFactoryAction));
}
