// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class DeviceFleetFactory(string resourceName = null, Action<Humidifier.SageMaker.DeviceFleet> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.DeviceFleet>(resourceName)
{

    internal InnerDeviceFleetEdgeOutputConfigFactory OutputConfigFactory { get; set; }

    protected override Humidifier.SageMaker.DeviceFleet Create()
    {
        var deviceFleetResult = CreateDeviceFleet();
        factoryAction?.Invoke(deviceFleetResult);

        return deviceFleetResult;
    }

    private Humidifier.SageMaker.DeviceFleet CreateDeviceFleet()
    {
        var deviceFleetResult = new Humidifier.SageMaker.DeviceFleet
        {
            GivenName = InputResourceName,
        };

        return deviceFleetResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DeviceFleet result)
    {
        base.CreateChildren(result);

        result.OutputConfig ??= OutputConfigFactory?.Build();
    }

} // End Of Class

public static class DeviceFleetFactoryExtensions
{
    public static CombinedResult<DeviceFleetFactory, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig(this DeviceFleetFactory parentFactory, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null)
    {
        parentFactory.OutputConfigFactory = new InnerDeviceFleetEdgeOutputConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputConfigFactory);
    }

    public static CombinedResult<DeviceFleetFactory, T1, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1>(this CombinedResult<DeviceFleetFactory, T1> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFleetFactory, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1>(this CombinedResult<T1, DeviceFleetFactory> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeviceFleetFactory, T1, T2, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<DeviceFleetFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFleetFactory, T2, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<T1, DeviceFleetFactory, T2> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFleetFactory, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<T1, T2, DeviceFleetFactory> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeviceFleetFactory, T1, T2, T3, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<DeviceFleetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFleetFactory, T2, T3, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, DeviceFleetFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFleetFactory, T3, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, T2, DeviceFleetFactory, T3> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceFleetFactory, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeviceFleetFactory> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeviceFleetFactory, T1, T2, T3, T4, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<DeviceFleetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeviceFleetFactory, T2, T3, T4, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, DeviceFleetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeviceFleetFactory, T3, T4, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeviceFleetFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeviceFleetFactory, T4, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeviceFleetFactory, T4> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeviceFleetFactory, InnerDeviceFleetEdgeOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeviceFleetFactory> combinedResult, Action<Humidifier.SageMaker.DeviceFleetTypes.EdgeOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T5, subFactoryAction));
}
