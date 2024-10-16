// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class WirelessGatewayFactory(string resourceName = null, Action<Humidifier.IoTWireless.WirelessGateway> factoryAction = null) : ResourceFactory<Humidifier.IoTWireless.WirelessGateway>(resourceName)
{

    internal InnerWirelessGatewayLoRaWANGatewayFactory LoRaWANFactory { get; set; }

    protected override Humidifier.IoTWireless.WirelessGateway Create()
    {
        var wirelessGatewayResult = CreateWirelessGateway();
        factoryAction?.Invoke(wirelessGatewayResult);

        return wirelessGatewayResult;
    }

    private Humidifier.IoTWireless.WirelessGateway CreateWirelessGateway()
    {
        var wirelessGatewayResult = new Humidifier.IoTWireless.WirelessGateway
        {
            GivenName = InputResourceName,
        };

        return wirelessGatewayResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.WirelessGateway result)
    {
        base.CreateChildren(result);

        result.LoRaWAN ??= LoRaWANFactory?.Build();
    }

} // End Of Class

public static class WirelessGatewayFactoryExtensions
{
    public static CombinedResult<WirelessGatewayFactory, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN(this WirelessGatewayFactory parentFactory, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null)
    {
        parentFactory.LoRaWANFactory = new InnerWirelessGatewayLoRaWANGatewayFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoRaWANFactory);
    }

    public static CombinedResult<WirelessGatewayFactory, T1, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1>(this CombinedResult<WirelessGatewayFactory, T1> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessGatewayFactory, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1>(this CombinedResult<T1, WirelessGatewayFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WirelessGatewayFactory, T1, T2, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2>(this CombinedResult<WirelessGatewayFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessGatewayFactory, T2, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, WirelessGatewayFactory, T2> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WirelessGatewayFactory, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, T2, WirelessGatewayFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WirelessGatewayFactory, T1, T2, T3, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<WirelessGatewayFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessGatewayFactory, T2, T3, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, WirelessGatewayFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WirelessGatewayFactory, T3, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, WirelessGatewayFactory, T3> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WirelessGatewayFactory, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, T3, WirelessGatewayFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WirelessGatewayFactory, T1, T2, T3, T4, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<WirelessGatewayFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WirelessGatewayFactory, T2, T3, T4, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, WirelessGatewayFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WirelessGatewayFactory, T3, T4, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, WirelessGatewayFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WirelessGatewayFactory, T4, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WirelessGatewayFactory, T4> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WirelessGatewayFactory, InnerWirelessGatewayLoRaWANGatewayFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WirelessGatewayFactory> combinedResult, Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T5, subFactoryAction));
}
