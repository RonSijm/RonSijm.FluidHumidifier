// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class ServiceProfileFactory(string resourceName = null, Action<Humidifier.IoTWireless.ServiceProfile> factoryAction = null) : ResourceFactory<Humidifier.IoTWireless.ServiceProfile>(resourceName)
{

    internal InnerServiceProfileLoRaWANServiceProfileFactory LoRaWANFactory { get; set; }

    protected override Humidifier.IoTWireless.ServiceProfile Create()
    {
        var serviceProfileResult = CreateServiceProfile();
        factoryAction?.Invoke(serviceProfileResult);

        return serviceProfileResult;
    }

    private Humidifier.IoTWireless.ServiceProfile CreateServiceProfile()
    {
        var serviceProfileResult = new Humidifier.IoTWireless.ServiceProfile
        {
            GivenName = InputResourceName,
        };

        return serviceProfileResult;
    }
    public override void CreateChildren(Humidifier.IoTWireless.ServiceProfile result)
    {
        base.CreateChildren(result);

        result.LoRaWAN ??= LoRaWANFactory?.Build();
    }

} // End Of Class

public static class ServiceProfileFactoryExtensions
{
    public static CombinedResult<ServiceProfileFactory, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN(this ServiceProfileFactory parentFactory, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null)
    {
        parentFactory.LoRaWANFactory = new InnerServiceProfileLoRaWANServiceProfileFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoRaWANFactory);
    }

    public static CombinedResult<ServiceProfileFactory, T1, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1>(this CombinedResult<ServiceProfileFactory, T1> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceProfileFactory, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1>(this CombinedResult<T1, ServiceProfileFactory> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServiceProfileFactory, T1, T2, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2>(this CombinedResult<ServiceProfileFactory, T1, T2> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceProfileFactory, T2, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, ServiceProfileFactory, T2> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceProfileFactory, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2>(this CombinedResult<T1, T2, ServiceProfileFactory> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServiceProfileFactory, T1, T2, T3, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<ServiceProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceProfileFactory, T2, T3, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, ServiceProfileFactory, T2, T3> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceProfileFactory, T3, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, ServiceProfileFactory, T3> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceProfileFactory, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceProfileFactory> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServiceProfileFactory, T1, T2, T3, T4, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<ServiceProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceProfileFactory, T2, T3, T4, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, ServiceProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceProfileFactory, T3, T4, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceProfileFactory, T3, T4> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceProfileFactory, T4, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceProfileFactory, T4> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServiceProfileFactory, InnerServiceProfileLoRaWANServiceProfileFactory> WithLoRaWAN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceProfileFactory> combinedResult, Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoRaWAN(combinedResult.T5, subFactoryAction));
}
