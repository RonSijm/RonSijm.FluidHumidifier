// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class MulticastGroupFactory(string resourceName = null, Action<Humidifier.IoTWireless.MulticastGroup> factoryAction = null) : ResourceFactory<Humidifier.IoTWireless.MulticastGroup>(resourceName)
{

    internal InnerMulticastGroupLoRaWANFactory LoRaWANFactory { get; set; }

    protected override Humidifier.IoTWireless.MulticastGroup Create()
    {
        var multicastGroupResult = CreateMulticastGroup();
        factoryAction?.Invoke(multicastGroupResult);

        return multicastGroupResult;
    }

    private Humidifier.IoTWireless.MulticastGroup CreateMulticastGroup()
    {
        var multicastGroupResult = new Humidifier.IoTWireless.MulticastGroup
        {
            GivenName = InputResourceName,
        };

        return multicastGroupResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.MulticastGroup result)
    {
        base.CreateChildren(result);

        result.LoRaWAN ??= LoRaWANFactory?.Build();
    }

} // End Of Class

public static class MulticastGroupFactoryExtensions
{
    public static CombinedResult<MulticastGroupFactory, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN(this MulticastGroupFactory parentFactory, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null)
    {
        parentFactory.LoRaWANFactory = new InnerMulticastGroupLoRaWANFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoRaWANFactory);
    }

    public static CombinedResult<MulticastGroupFactory, T1, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1>(this CombinedResult<MulticastGroupFactory, T1> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MulticastGroupFactory, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1>(this CombinedResult<T1, MulticastGroupFactory> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MulticastGroupFactory, T1, T2, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2>(this CombinedResult<MulticastGroupFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MulticastGroupFactory, T2, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, MulticastGroupFactory, T2> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MulticastGroupFactory, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, T2, MulticastGroupFactory> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MulticastGroupFactory, T1, T2, T3, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<MulticastGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MulticastGroupFactory, T2, T3, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, MulticastGroupFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MulticastGroupFactory, T3, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, MulticastGroupFactory, T3> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MulticastGroupFactory, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, T3, MulticastGroupFactory> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MulticastGroupFactory, T1, T2, T3, T4, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<MulticastGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MulticastGroupFactory, T2, T3, T4, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, MulticastGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MulticastGroupFactory, T3, T4, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, MulticastGroupFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MulticastGroupFactory, T4, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MulticastGroupFactory, T4> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MulticastGroupFactory, InnerMulticastGroupLoRaWANFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MulticastGroupFactory> combinedResult, Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T5, subFactoryAction));
}
