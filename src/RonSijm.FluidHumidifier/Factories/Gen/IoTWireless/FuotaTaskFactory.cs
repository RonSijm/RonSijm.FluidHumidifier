// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class FuotaTaskFactory(string resourceName = null, Action<Humidifier.IoTWireless.FuotaTask> factoryAction = null) : ResourceFactory<Humidifier.IoTWireless.FuotaTask>(resourceName)
{

    internal InnerFuotaTaskLoRaWANFactory LoRaWANFactory { get; set; }

    protected override Humidifier.IoTWireless.FuotaTask Create()
    {
        var fuotaTaskResult = CreateFuotaTask();
        factoryAction?.Invoke(fuotaTaskResult);

        return fuotaTaskResult;
    }

    private Humidifier.IoTWireless.FuotaTask CreateFuotaTask()
    {
        var fuotaTaskResult = new Humidifier.IoTWireless.FuotaTask
        {
            GivenName = InputResourceName,
        };

        return fuotaTaskResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.FuotaTask result)
    {
        base.CreateChildren(result);

        result.LoRaWAN ??= LoRaWANFactory?.Build();
    }

} // End Of Class

public static class FuotaTaskFactoryExtensions
{
    public static CombinedResult<FuotaTaskFactory, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN(this FuotaTaskFactory parentFactory, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null)
    {
        parentFactory.LoRaWANFactory = new InnerFuotaTaskLoRaWANFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoRaWANFactory);
    }

    public static CombinedResult<FuotaTaskFactory, T1, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1>(this CombinedResult<FuotaTaskFactory, T1> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FuotaTaskFactory, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1>(this CombinedResult<T1, FuotaTaskFactory> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FuotaTaskFactory, T1, T2, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2>(this CombinedResult<FuotaTaskFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FuotaTaskFactory, T2, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, FuotaTaskFactory, T2> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FuotaTaskFactory, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, T2, FuotaTaskFactory> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FuotaTaskFactory, T1, T2, T3, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<FuotaTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FuotaTaskFactory, T2, T3, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, FuotaTaskFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FuotaTaskFactory, T3, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, FuotaTaskFactory, T3> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FuotaTaskFactory, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, T3, FuotaTaskFactory> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FuotaTaskFactory, T1, T2, T3, T4, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<FuotaTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FuotaTaskFactory, T2, T3, T4, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, FuotaTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FuotaTaskFactory, T3, T4, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, FuotaTaskFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FuotaTaskFactory, T4, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FuotaTaskFactory, T4> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FuotaTaskFactory, InnerFuotaTaskLoRaWANFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FuotaTaskFactory> combinedResult, Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T5, subFactoryAction));
}
