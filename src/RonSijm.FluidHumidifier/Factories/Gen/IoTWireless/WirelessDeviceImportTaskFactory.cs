// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class WirelessDeviceImportTaskFactory(string resourceName = null, Action<Humidifier.IoTWireless.WirelessDeviceImportTask> factoryAction = null) : ResourceFactory<Humidifier.IoTWireless.WirelessDeviceImportTask>(resourceName)
{

    internal InnerWirelessDeviceImportTaskSidewalkFactory SidewalkFactory { get; set; }

    protected override Humidifier.IoTWireless.WirelessDeviceImportTask Create()
    {
        var wirelessDeviceImportTaskResult = CreateWirelessDeviceImportTask();
        factoryAction?.Invoke(wirelessDeviceImportTaskResult);

        return wirelessDeviceImportTaskResult;
    }

    private Humidifier.IoTWireless.WirelessDeviceImportTask CreateWirelessDeviceImportTask()
    {
        var wirelessDeviceImportTaskResult = new Humidifier.IoTWireless.WirelessDeviceImportTask
        {
            GivenName = InputResourceName,
        };

        return wirelessDeviceImportTaskResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.WirelessDeviceImportTask result)
    {
        base.CreateChildren(result);

        result.Sidewalk ??= SidewalkFactory?.Build();
    }

} // End Of Class

public static class WirelessDeviceImportTaskFactoryExtensions
{
    public static CombinedResult<WirelessDeviceImportTaskFactory, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk(this WirelessDeviceImportTaskFactory parentFactory, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null)
    {
        parentFactory.SidewalkFactory = new InnerWirelessDeviceImportTaskSidewalkFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SidewalkFactory);
    }

    public static CombinedResult<WirelessDeviceImportTaskFactory, T1, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1>(this CombinedResult<WirelessDeviceImportTaskFactory, T1> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, WithSidewalk(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessDeviceImportTaskFactory, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1>(this CombinedResult<T1, WirelessDeviceImportTaskFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, WithSidewalk(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WirelessDeviceImportTaskFactory, T1, T2, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2>(this CombinedResult<WirelessDeviceImportTaskFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessDeviceImportTaskFactory, T2, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2>(this CombinedResult<T1, WirelessDeviceImportTaskFactory, T2> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WirelessDeviceImportTaskFactory, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2>(this CombinedResult<T1, T2, WirelessDeviceImportTaskFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WirelessDeviceImportTaskFactory, T1, T2, T3, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2, T3>(this CombinedResult<WirelessDeviceImportTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessDeviceImportTaskFactory, T2, T3, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2, T3>(this CombinedResult<T1, WirelessDeviceImportTaskFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WirelessDeviceImportTaskFactory, T3, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2, T3>(this CombinedResult<T1, T2, WirelessDeviceImportTaskFactory, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WirelessDeviceImportTaskFactory, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2, T3>(this CombinedResult<T1, T2, T3, WirelessDeviceImportTaskFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WirelessDeviceImportTaskFactory, T1, T2, T3, T4, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2, T3, T4>(this CombinedResult<WirelessDeviceImportTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessDeviceImportTaskFactory, T2, T3, T4, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2, T3, T4>(this CombinedResult<T1, WirelessDeviceImportTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WirelessDeviceImportTaskFactory, T3, T4, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2, T3, T4>(this CombinedResult<T1, T2, WirelessDeviceImportTaskFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WirelessDeviceImportTaskFactory, T4, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WirelessDeviceImportTaskFactory, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WirelessDeviceImportTaskFactory, InnerWirelessDeviceImportTaskSidewalkFactory> WithSidewalk<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WirelessDeviceImportTaskFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSidewalk(combinedResult.T5, subFactoryAction));
}
