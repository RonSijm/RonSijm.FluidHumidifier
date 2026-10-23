// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputSrtListenerDecryptionFactory(Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.SrtListenerDecryption>
{

    protected override Humidifier.MediaLive.InputTypes.SrtListenerDecryption Create()
    {
        var srtListenerDecryptionResult = CreateSrtListenerDecryption();
        factoryAction?.Invoke(srtListenerDecryptionResult);

        return srtListenerDecryptionResult;
    }

    private Humidifier.MediaLive.InputTypes.SrtListenerDecryption CreateSrtListenerDecryption()
    {
        var srtListenerDecryptionResult = new Humidifier.MediaLive.InputTypes.SrtListenerDecryption();

        return srtListenerDecryptionResult;
    }

} // End Of Class

public static class InnerInputSrtListenerDecryptionFactoryExtensions
{
}
