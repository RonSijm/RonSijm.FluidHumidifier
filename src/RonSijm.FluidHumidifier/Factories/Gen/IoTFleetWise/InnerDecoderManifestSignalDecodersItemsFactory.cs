// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerDecoderManifestSignalDecodersItemsFactory(Action<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems>
{

    internal InnerDecoderManifestObdSignalFactory ObdSignalFactory { get; set; }

    internal InnerDecoderManifestCanSignalFactory CanSignalFactory { get; set; }

    protected override Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems Create()
    {
        var signalDecodersItemsResult = CreateSignalDecodersItems();
        factoryAction?.Invoke(signalDecodersItemsResult);

        return signalDecodersItemsResult;
    }

    private Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems CreateSignalDecodersItems()
    {
        var signalDecodersItemsResult = new Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems();

        return signalDecodersItemsResult;
    }
    public override void CreateChildren(Humidifier.IoTFleetWise.DecoderManifestTypes.SignalDecodersItems result)
    {
        base.CreateChildren(result);

        result.ObdSignal ??= ObdSignalFactory?.Build();
        result.CanSignal ??= CanSignalFactory?.Build();
    }

} // End Of Class

public static class InnerDecoderManifestSignalDecodersItemsFactoryExtensions
{
    public static CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, InnerDecoderManifestObdSignalFactory> WithObdSignal(this InnerDecoderManifestSignalDecodersItemsFactory parentFactory, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null)
    {
        parentFactory.ObdSignalFactory = new InnerDecoderManifestObdSignalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ObdSignalFactory);
    }

    public static CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, InnerDecoderManifestCanSignalFactory> WithCanSignal(this InnerDecoderManifestSignalDecodersItemsFactory parentFactory, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null)
    {
        parentFactory.CanSignalFactory = new InnerDecoderManifestCanSignalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanSignalFactory);
    }

    public static CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1>(this CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, WithObdSignal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1>(this CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, WithObdSignal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2>(this CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2>(this CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2>(this CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2, T3, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2, T3>(this CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2, T3, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2, T3>(this CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory, T3, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2, T3>(this CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDecoderManifestSignalDecodersItemsFactory, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDecoderManifestSignalDecodersItemsFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2, T3, T4, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2, T3, T4>(this CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2, T3, T4, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2, T3, T4>(this CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory, T3, T4, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDecoderManifestSignalDecodersItemsFactory, T4, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDecoderManifestSignalDecodersItemsFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDecoderManifestSignalDecodersItemsFactory, InnerDecoderManifestObdSignalFactory> WithObdSignal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDecoderManifestSignalDecodersItemsFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObdSignal(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1>(this CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanSignal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1>(this CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanSignal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2>(this CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2>(this CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2>(this CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2, T3, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2, T3>(this CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2, T3, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2, T3>(this CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory, T3, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2, T3>(this CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDecoderManifestSignalDecodersItemsFactory, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDecoderManifestSignalDecodersItemsFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2, T3, T4, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2, T3, T4>(this CombinedResult<InnerDecoderManifestSignalDecodersItemsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2, T3, T4, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2, T3, T4>(this CombinedResult<T1, InnerDecoderManifestSignalDecodersItemsFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory, T3, T4, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDecoderManifestSignalDecodersItemsFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDecoderManifestSignalDecodersItemsFactory, T4, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDecoderManifestSignalDecodersItemsFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDecoderManifestSignalDecodersItemsFactory, InnerDecoderManifestCanSignalFactory> WithCanSignal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDecoderManifestSignalDecodersItemsFactory> combinedResult, Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanSignal(combinedResult.T5, subFactoryAction));
}
