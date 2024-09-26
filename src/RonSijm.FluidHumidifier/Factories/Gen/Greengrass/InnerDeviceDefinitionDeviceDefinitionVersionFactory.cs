// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerDeviceDefinitionDeviceDefinitionVersionFactory(Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion>
{

    internal List<InnerDeviceDefinitionDeviceFactory> DevicesFactories { get; set; } = [];

    protected override Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion Create()
    {
        var deviceDefinitionVersionResult = CreateDeviceDefinitionVersion();
        factoryAction?.Invoke(deviceDefinitionVersionResult);

        return deviceDefinitionVersionResult;
    }

    private Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion CreateDeviceDefinitionVersion()
    {
        var deviceDefinitionVersionResult = new Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion();

        return deviceDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Devices = DevicesFactories.Any() ? DevicesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerDeviceDefinitionDeviceDefinitionVersionFactoryExtensions
{
    public static CombinedResult<InnerDeviceDefinitionDeviceDefinitionVersionFactory, InnerDeviceDefinitionDeviceFactory> WithDevices(this InnerDeviceDefinitionDeviceDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null)
    {
        var factory = new InnerDeviceDefinitionDeviceFactory(subFactoryAction);
        parentFactory.DevicesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerDeviceDefinitionDeviceDefinitionVersionFactory, T1, InnerDeviceDefinitionDeviceFactory> WithDevices<T1>(this CombinedResult<InnerDeviceDefinitionDeviceDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, WithDevices(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeviceDefinitionDeviceDefinitionVersionFactory, InnerDeviceDefinitionDeviceFactory> WithDevices<T1>(this CombinedResult<T1, InnerDeviceDefinitionDeviceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, WithDevices(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeviceDefinitionDeviceDefinitionVersionFactory, T1, T2, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2>(this CombinedResult<InnerDeviceDefinitionDeviceDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T2, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2>(this CombinedResult<T1, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeviceDefinitionDeviceDefinitionVersionFactory, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2>(this CombinedResult<T1, T2, InnerDeviceDefinitionDeviceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeviceDefinitionDeviceDefinitionVersionFactory, T1, T2, T3, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2, T3>(this CombinedResult<InnerDeviceDefinitionDeviceDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T2, T3, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2, T3>(this CombinedResult<T1, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T3, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeviceDefinitionDeviceDefinitionVersionFactory, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeviceDefinitionDeviceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeviceDefinitionDeviceDefinitionVersionFactory, T1, T2, T3, T4, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2, T3, T4>(this CombinedResult<InnerDeviceDefinitionDeviceDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T2, T3, T4, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T3, T4, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T4, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeviceDefinitionDeviceDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeviceDefinitionDeviceDefinitionVersionFactory, InnerDeviceDefinitionDeviceFactory> WithDevices<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeviceDefinitionDeviceDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevices(combinedResult.T5, subFactoryAction));
}
