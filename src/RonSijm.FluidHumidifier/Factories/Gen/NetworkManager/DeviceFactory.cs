// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class DeviceFactory(string resourceName = null, Action<Humidifier.NetworkManager.Device> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.Device>(resourceName)
{

    internal InnerDeviceAWSLocationFactory AWSLocationFactory { get; set; }

    internal InnerDeviceLocationFactory LocationFactory { get; set; }

    protected override Humidifier.NetworkManager.Device Create()
    {
        var deviceResult = CreateDevice();
        factoryAction?.Invoke(deviceResult);

        return deviceResult;
    }

    private Humidifier.NetworkManager.Device CreateDevice()
    {
        var deviceResult = new Humidifier.NetworkManager.Device
        {
            GivenName = InputResourceName,
        };

        return deviceResult;
    }
    public override void CreateChildren(Humidifier.NetworkManager.Device result)
    {
        base.CreateChildren(result);

        result.AWSLocation ??= AWSLocationFactory?.Build();
        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class DeviceFactoryExtensions
{
    public static CombinedResult<DeviceFactory, InnerDeviceAWSLocationFactory> WithAWSLocation(this DeviceFactory parentFactory, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null)
    {
        parentFactory.AWSLocationFactory = new InnerDeviceAWSLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AWSLocationFactory);
    }

    public static CombinedResult<DeviceFactory, InnerDeviceLocationFactory> WithLocation(this DeviceFactory parentFactory, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerDeviceLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<DeviceFactory, T1, InnerDeviceAWSLocationFactory> WithAWSLocation<T1>(this CombinedResult<DeviceFactory, T1> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAWSLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, InnerDeviceAWSLocationFactory> WithAWSLocation<T1>(this CombinedResult<T1, DeviceFactory> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAWSLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeviceFactory, T1, T2, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2>(this CombinedResult<DeviceFactory, T1, T2> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, T2, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2>(this CombinedResult<T1, DeviceFactory, T2> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFactory, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2>(this CombinedResult<T1, T2, DeviceFactory> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeviceFactory, T1, T2, T3, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2, T3>(this CombinedResult<DeviceFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, T2, T3, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2, T3>(this CombinedResult<T1, DeviceFactory, T2, T3> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFactory, T3, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2, T3>(this CombinedResult<T1, T2, DeviceFactory, T3> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceFactory, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeviceFactory> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeviceFactory, T1, T2, T3, T4, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2, T3, T4>(this CombinedResult<DeviceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, T2, T3, T4, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2, T3, T4>(this CombinedResult<T1, DeviceFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFactory, T3, T4, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeviceFactory, T3, T4> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceFactory, T4, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeviceFactory, T4> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeviceFactory, InnerDeviceAWSLocationFactory> WithAWSLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeviceFactory> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.AWSLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAWSLocation(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DeviceFactory, T1, InnerDeviceLocationFactory> WithLocation<T1>(this CombinedResult<DeviceFactory, T1> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, InnerDeviceLocationFactory> WithLocation<T1>(this CombinedResult<T1, DeviceFactory> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeviceFactory, T1, T2, InnerDeviceLocationFactory> WithLocation<T1, T2>(this CombinedResult<DeviceFactory, T1, T2> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, T2, InnerDeviceLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, DeviceFactory, T2> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFactory, InnerDeviceLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, DeviceFactory> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeviceFactory, T1, T2, T3, InnerDeviceLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<DeviceFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, T2, T3, InnerDeviceLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, DeviceFactory, T2, T3> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFactory, T3, InnerDeviceLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, DeviceFactory, T3> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceFactory, InnerDeviceLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeviceFactory> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeviceFactory, T1, T2, T3, T4, InnerDeviceLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<DeviceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFactory, T2, T3, T4, InnerDeviceLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, DeviceFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFactory, T3, T4, InnerDeviceLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeviceFactory, T3, T4> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceFactory, T4, InnerDeviceLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeviceFactory, T4> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeviceFactory, InnerDeviceLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeviceFactory> combinedResult, Action<Humidifier.NetworkManager.DeviceTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction));
}
