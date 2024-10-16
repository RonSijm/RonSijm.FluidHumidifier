// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class DeviceDefinitionFactory(string resourceName = null, Action<Humidifier.Greengrass.DeviceDefinition> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.DeviceDefinition>(resourceName)
{

    internal InnerDeviceDefinitionDeviceDefinitionVersionFactory InitialVersionFactory { get; set; }

    protected override Humidifier.Greengrass.DeviceDefinition Create()
    {
        var deviceDefinitionResult = CreateDeviceDefinition();
        factoryAction?.Invoke(deviceDefinitionResult);

        return deviceDefinitionResult;
    }

    private Humidifier.Greengrass.DeviceDefinition CreateDeviceDefinition()
    {
        var deviceDefinitionResult = new Humidifier.Greengrass.DeviceDefinition
        {
            GivenName = InputResourceName,
        };

        return deviceDefinitionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.DeviceDefinition result)
    {
        base.CreateChildren(result);

        result.InitialVersion ??= InitialVersionFactory?.Build();
    }

} // End Of Class

public static class DeviceDefinitionFactoryExtensions
{
    public static CombinedResult<DeviceDefinitionFactory, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion(this DeviceDefinitionFactory parentFactory, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null)
    {
        parentFactory.InitialVersionFactory = new InnerDeviceDefinitionDeviceDefinitionVersionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InitialVersionFactory);
    }

    public static CombinedResult<DeviceDefinitionFactory, T1, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<DeviceDefinitionFactory, T1> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceDefinitionFactory, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<T1, DeviceDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeviceDefinitionFactory, T1, T2, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<DeviceDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceDefinitionFactory, T2, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, DeviceDefinitionFactory, T2> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceDefinitionFactory, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, T2, DeviceDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeviceDefinitionFactory, T1, T2, T3, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<DeviceDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceDefinitionFactory, T2, T3, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, DeviceDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceDefinitionFactory, T3, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, DeviceDefinitionFactory, T3> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceDefinitionFactory, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeviceDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeviceDefinitionFactory, T1, T2, T3, T4, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<DeviceDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceDefinitionFactory, T2, T3, T4, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, DeviceDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceDefinitionFactory, T3, T4, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeviceDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceDefinitionFactory, T4, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeviceDefinitionFactory, T4> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeviceDefinitionFactory, InnerDeviceDefinitionDeviceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeviceDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T5, subFactoryAction));
}
