// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerDecoderManifestObdSignalFactory(Action<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal>
{

    protected override Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal Create()
    {
        var obdSignalResult = CreateObdSignal();
        factoryAction?.Invoke(obdSignalResult);

        return obdSignalResult;
    }

    private Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal CreateObdSignal()
    {
        var obdSignalResult = new Humidifier.IoTFleetWise.DecoderManifestTypes.ObdSignal();

        return obdSignalResult;
    }

} // End Of Class

public static class InnerDecoderManifestObdSignalFactoryExtensions
{
}
