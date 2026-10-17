// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerDecoderManifestCustomDecodingSignalFactory(Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingSignal> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingSignal>
{

    protected override Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingSignal Create()
    {
        var customDecodingSignalResult = CreateCustomDecodingSignal();
        factoryAction?.Invoke(customDecodingSignalResult);

        return customDecodingSignalResult;
    }

    private Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingSignal CreateCustomDecodingSignal()
    {
        var customDecodingSignalResult = new Humidifier.IoTFleetWise.DecoderManifestTypes.CustomDecodingSignal();

        return customDecodingSignalResult;
    }

} // End Of Class

public static class InnerDecoderManifestCustomDecodingSignalFactoryExtensions
{
}
