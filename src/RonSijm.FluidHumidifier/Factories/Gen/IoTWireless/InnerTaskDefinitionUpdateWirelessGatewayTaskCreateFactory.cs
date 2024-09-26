// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory(Action<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate>
{

    internal InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory LoRaWANFactory { get; set; }

    protected override Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate Create()
    {
        var updateWirelessGatewayTaskCreateResult = CreateUpdateWirelessGatewayTaskCreate();
        factoryAction?.Invoke(updateWirelessGatewayTaskCreateResult);

        return updateWirelessGatewayTaskCreateResult;
    }

    private Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate CreateUpdateWirelessGatewayTaskCreate()
    {
        var updateWirelessGatewayTaskCreateResult = new Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate();

        return updateWirelessGatewayTaskCreateResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.TaskDefinitionTypes.UpdateWirelessGatewayTaskCreate result)
    {
        base.CreateChildren(result);

        result.LoRaWAN ??= LoRaWANFactory?.Build();
    }

} // End Of Class

public static class InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactoryExtensions
{
    public static CombinedResult<InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN(this InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory parentFactory, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null)
    {
        parentFactory.LoRaWANFactory = new InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoRaWANFactory);
    }

    public static CombinedResult<InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T1, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1>(this CombinedResult<InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T1> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1>(this CombinedResult<T1, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T1, T2, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2>(this CombinedResult<InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T2, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T2> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, T2, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T1, T2, T3, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T2, T3, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T3, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T3> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T1, T2, T3, T4, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T2, T3, T4, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T3, T4, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T4, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, T4> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory, InnerTaskDefinitionLoRaWANUpdateGatewayTaskCreateFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskDefinitionUpdateWirelessGatewayTaskCreateFactory> combinedResult, Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANUpdateGatewayTaskCreate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T5, subFactoryAction));
}
