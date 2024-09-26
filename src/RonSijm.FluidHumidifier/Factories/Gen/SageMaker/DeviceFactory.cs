// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class DeviceFactory(string resourceName = null, Action<Humidifier.SageMaker.Device> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Device>(resourceName)
{

    internal InnerDeviceDeviceFactory Device_Factory { get; set; }

    protected override Humidifier.SageMaker.Device Create()
    {
        var deviceResult = CreateDevice();
        factoryAction?.Invoke(deviceResult);

        return deviceResult;
    }

    private Humidifier.SageMaker.Device CreateDevice()
    {
        var deviceResult = new Humidifier.SageMaker.Device
        {
            GivenName = InputResourceName,
        };

        return deviceResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Device result)
    {
        base.CreateChildren(result);

        result.Device_ ??= Device_Factory?.Build();
    }

} // End Of Class

public static class DeviceFactoryExtensions
{
    public static CombinedResult<DeviceFactory, InnerDeviceDeviceFactory> WithDevice_(this DeviceFactory parentFactory, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null)
    {
        parentFactory.Device_Factory = new InnerDeviceDeviceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Device_Factory);
    }

    public static CombinedResult<DeviceFactory, T1, InnerDeviceDeviceFactory> WithDevice_<T1>(this CombinedResult<DeviceFactory, T1> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, WithDevice_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, InnerDeviceDeviceFactory> WithDevice_<T1>(this CombinedResult<T1, DeviceFactory> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, WithDevice_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeviceFactory, T1, T2, InnerDeviceDeviceFactory> WithDevice_<T1, T2>(this CombinedResult<DeviceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, T2, InnerDeviceDeviceFactory> WithDevice_<T1, T2>(this CombinedResult<T1, DeviceFactory, T2> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFactory, InnerDeviceDeviceFactory> WithDevice_<T1, T2>(this CombinedResult<T1, T2, DeviceFactory> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeviceFactory, T1, T2, T3, InnerDeviceDeviceFactory> WithDevice_<T1, T2, T3>(this CombinedResult<DeviceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, T2, T3, InnerDeviceDeviceFactory> WithDevice_<T1, T2, T3>(this CombinedResult<T1, DeviceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFactory, T3, InnerDeviceDeviceFactory> WithDevice_<T1, T2, T3>(this CombinedResult<T1, T2, DeviceFactory, T3> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceFactory, InnerDeviceDeviceFactory> WithDevice_<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeviceFactory> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeviceFactory, T1, T2, T3, T4, InnerDeviceDeviceFactory> WithDevice_<T1, T2, T3, T4>(this CombinedResult<DeviceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, T2, T3, T4, InnerDeviceDeviceFactory> WithDevice_<T1, T2, T3, T4>(this CombinedResult<T1, DeviceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFactory, T3, T4, InnerDeviceDeviceFactory> WithDevice_<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeviceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceFactory, T4, InnerDeviceDeviceFactory> WithDevice_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeviceFactory, T4> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeviceFactory, InnerDeviceDeviceFactory> WithDevice_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeviceFactory> combinedResult, Action<Humidifier.SageMaker.DeviceTypes.Device> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDevice_(combinedResult.T5, subFactoryAction));
}
