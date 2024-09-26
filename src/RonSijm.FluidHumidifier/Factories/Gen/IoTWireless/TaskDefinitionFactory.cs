// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class TaskDefinitionFactory(string resourceName = null, Action<Humidifier.IoTWireless.TaskDefinition> factoryAction = null) : ResourceFactory<Humidifier.IoTWireless.TaskDefinition>(resourceName)
{

    internal InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory LoRaWANUpdateGatewayTaskEntryFactory { get; set; }

    internal InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory UpdateFactory { get; set; }

    protected override Humidifier.IoTWireless.TaskDefinition Create()
    {
        var taskDefinitionResult = CreateTaskDefinition();
        factoryAction?.Invoke(taskDefinitionResult);

        return taskDefinitionResult;
    }

    private Humidifier.IoTWireless.TaskDefinition CreateTaskDefinition()
    {
        var taskDefinitionResult = new Humidifier.IoTWireless.TaskDefinition
        {
            GivenName = InputResourceName,
        };

        return taskDefinitionResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.TaskDefinition result)
    {
        base.CreateChildren(result);

        result.LoRaWANUpdateGatewayTaskEntry ??= LoRaWANUpdateGatewayTaskEntryFactory?.Build();
        result.Update ??= UpdateFactory?.Build();
    }

} // End Of Class

public static class TaskDefinitionFactoryExtensions
{
    public static CombinedResult<TaskDefinitionFactory, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry(this TaskDefinitionFactory parentFactory, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null)
    {
        parentFactory.LoRaWANUpdateGatewayTaskEntryFactory = new InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoRaWANUpdateGatewayTaskEntryFactory);
    }

    public static CombinedResult<TaskDefinitionFactory, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate(this TaskDefinitionFactory parentFactory, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null)
    {
        parentFactory.UpdateFactory = new InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UpdateFactory);
    }

    public static CombinedResult<TaskDefinitionFactory, T1, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1>(this CombinedResult<TaskDefinitionFactory, T1> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskDefinitionFactory, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1>(this CombinedResult<T1, TaskDefinitionFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TaskDefinitionFactory, T1, T2, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2>(this CombinedResult<TaskDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskDefinitionFactory, T2, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2>(this CombinedResult<T1, TaskDefinitionFactory, T2> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskDefinitionFactory, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2>(this CombinedResult<T1, T2, TaskDefinitionFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TaskDefinitionFactory, T1, T2, T3, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2, T3>(this CombinedResult<TaskDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskDefinitionFactory, T2, T3, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2, T3>(this CombinedResult<T1, TaskDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskDefinitionFactory, T3, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2, T3>(this CombinedResult<T1, T2, TaskDefinitionFactory, T3> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskDefinitionFactory, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskDefinitionFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TaskDefinitionFactory, T1, T2, T3, T4, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2, T3, T4>(this CombinedResult<TaskDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskDefinitionFactory, T2, T3, T4, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2, T3, T4>(this CombinedResult<T1, TaskDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskDefinitionFactory, T3, T4, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskDefinitionFactory, T4, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskDefinitionFactory, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TaskDefinitionFactory, InnerTaskDefinitionLoRaWANUpdateGatewayTaskEntryFactory> WithLoRaWANUpdateGatewayTaskEntry<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskDefinitionFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWANUpdateGatewayTaskEntry(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TaskDefinitionFactory, T1, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1>(this CombinedResult<TaskDefinitionFactory, T1> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, WithUpdate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskDefinitionFactory, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1>(this CombinedResult<T1, TaskDefinitionFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, WithUpdate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TaskDefinitionFactory, T1, T2, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2>(this CombinedResult<TaskDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskDefinitionFactory, T2, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2>(this CombinedResult<T1, TaskDefinitionFactory, T2> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskDefinitionFactory, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2>(this CombinedResult<T1, T2, TaskDefinitionFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TaskDefinitionFactory, T1, T2, T3, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2, T3>(this CombinedResult<TaskDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskDefinitionFactory, T2, T3, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2, T3>(this CombinedResult<T1, TaskDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskDefinitionFactory, T3, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2, T3>(this CombinedResult<T1, T2, TaskDefinitionFactory, T3> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskDefinitionFactory, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskDefinitionFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TaskDefinitionFactory, T1, T2, T3, T4, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2, T3, T4>(this CombinedResult<TaskDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskDefinitionFactory, T2, T3, T4, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2, T3, T4>(this CombinedResult<T1, TaskDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskDefinitionFactory, T3, T4, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskDefinitionFactory, T4, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskDefinitionFactory, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TaskDefinitionFactory, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> WithUpdate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskDefinitionFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpdate(combinedResult.T5, subFactoryAction));
}
