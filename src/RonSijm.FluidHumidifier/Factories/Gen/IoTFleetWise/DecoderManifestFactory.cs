// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class DecoderManifestFactory(string resourceName = null, Action<Humidifier.IoTFleetWise.DecoderManifest> factoryAction = null) : ResourceFactory<Humidifier.IoTFleetWise.DecoderManifest>(resourceName)
{

    internal List<InnerDecoderManifestSignalDecodersItemsFactory> SignalDecodersFactories { get; set; } = [];

    internal List<InnerDecoderManifestNetworkInterfacesItemsFactory> NetworkInterfacesFactories { get; set; } = [];

    protected override Humidifier.IoTFleetWise.DecoderManifest Create()
    {
        var decoderManifestResult = CreateDecoderManifest();
        factoryAction?.Invoke(decoderManifestResult);

        return decoderManifestResult;
    }

    private Humidifier.IoTFleetWise.DecoderManifest CreateDecoderManifest()
    {
        var decoderManifestResult = new Humidifier.IoTFleetWise.DecoderManifest
        {
            GivenName = InputResourceName,
        };

        return decoderManifestResult;
    }
    public override void CreateChildren(Humidifier.IoTFleetWise.DecoderManifest result)
    {
        base.CreateChildren(result);

        result.SignalDecoders = SignalDecodersFactories.Any() ? SignalDecodersFactories.Select(x => x.Build()).ToList() : null;
        result.NetworkInterfaces = NetworkInterfacesFactories.Any() ? NetworkInterfacesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DecoderManifestFactoryExtensions
{
    public static CombinedResult<DecoderManifestFactory, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders(this DecoderManifestFactory parentFactory, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null)
    {
        var factory = new InnerDecoderManifestSignalDecodersItemsFactory(subFactoryAction);
        parentFactory.SignalDecodersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DecoderManifestFactory, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces(this DecoderManifestFactory parentFactory, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null)
    {
        var factory = new InnerDecoderManifestNetworkInterfacesItemsFactory(subFactoryAction);
        parentFactory.NetworkInterfacesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DecoderManifestFactory, T1, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1>(this CombinedResult<DecoderManifestFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignalDecoders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DecoderManifestFactory, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1>(this CombinedResult<T1, DecoderManifestFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignalDecoders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DecoderManifestFactory, T1, T2, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2>(this CombinedResult<DecoderManifestFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DecoderManifestFactory, T2, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2>(this CombinedResult<T1, DecoderManifestFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DecoderManifestFactory, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2>(this CombinedResult<T1, T2, DecoderManifestFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DecoderManifestFactory, T1, T2, T3, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2, T3>(this CombinedResult<DecoderManifestFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DecoderManifestFactory, T2, T3, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2, T3>(this CombinedResult<T1, DecoderManifestFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DecoderManifestFactory, T3, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2, T3>(this CombinedResult<T1, T2, DecoderManifestFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DecoderManifestFactory, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2, T3>(this CombinedResult<T1, T2, T3, DecoderManifestFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DecoderManifestFactory, T1, T2, T3, T4, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2, T3, T4>(this CombinedResult<DecoderManifestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DecoderManifestFactory, T2, T3, T4, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2, T3, T4>(this CombinedResult<T1, DecoderManifestFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DecoderManifestFactory, T3, T4, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2, T3, T4>(this CombinedResult<T1, T2, DecoderManifestFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DecoderManifestFactory, T4, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DecoderManifestFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DecoderManifestFactory, InnerDecoderManifestSignalDecodersItemsFactory> WithSignalDecoders<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DecoderManifestFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignalDecoders(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DecoderManifestFactory, T1, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1>(this CombinedResult<DecoderManifestFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DecoderManifestFactory, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1>(this CombinedResult<T1, DecoderManifestFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DecoderManifestFactory, T1, T2, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2>(this CombinedResult<DecoderManifestFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DecoderManifestFactory, T2, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2>(this CombinedResult<T1, DecoderManifestFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DecoderManifestFactory, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2>(this CombinedResult<T1, T2, DecoderManifestFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DecoderManifestFactory, T1, T2, T3, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2, T3>(this CombinedResult<DecoderManifestFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DecoderManifestFactory, T2, T3, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2, T3>(this CombinedResult<T1, DecoderManifestFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DecoderManifestFactory, T3, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2, T3>(this CombinedResult<T1, T2, DecoderManifestFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DecoderManifestFactory, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2, T3>(this CombinedResult<T1, T2, T3, DecoderManifestFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DecoderManifestFactory, T1, T2, T3, T4, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2, T3, T4>(this CombinedResult<DecoderManifestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DecoderManifestFactory, T2, T3, T4, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2, T3, T4>(this CombinedResult<T1, DecoderManifestFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DecoderManifestFactory, T3, T4, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2, T3, T4>(this CombinedResult<T1, T2, DecoderManifestFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DecoderManifestFactory, T4, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DecoderManifestFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DecoderManifestFactory, InnerDecoderManifestNetworkInterfacesItemsFactory> WithNetworkInterfaces<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DecoderManifestFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.NetworkInterfacesItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInterfaces(combinedResult.T5, subFactoryAction));
}
