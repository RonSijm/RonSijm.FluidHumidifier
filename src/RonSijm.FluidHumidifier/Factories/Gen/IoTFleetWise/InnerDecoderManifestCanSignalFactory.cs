// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerDecoderManifestCanSignalFactory(Action<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal>
{

    protected override Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal Create()
    {
        var canSignalResult = CreateCanSignal();
        factoryAction?.Invoke(canSignalResult);

        return canSignalResult;
    }

    private Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal CreateCanSignal()
    {
        var canSignalResult = new Humidifier.IoTFleetWise.DecoderManifestTypes.CanSignal();

        return canSignalResult;
    }

} // End Of Class

public static class InnerDecoderManifestCanSignalFactoryExtensions
{
}
