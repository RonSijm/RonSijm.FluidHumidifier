// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputSrtListenerDecryptionRequestFactory(Action<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest>
{

    protected override Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest Create()
    {
        var srtListenerDecryptionRequestResult = CreateSrtListenerDecryptionRequest();
        factoryAction?.Invoke(srtListenerDecryptionRequestResult);

        return srtListenerDecryptionRequestResult;
    }

    private Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest CreateSrtListenerDecryptionRequest()
    {
        var srtListenerDecryptionRequestResult = new Humidifier.MediaLive.InputTypes.SrtListenerDecryptionRequest();

        return srtListenerDecryptionRequestResult;
    }

} // End Of Class

public static class InnerInputSrtListenerDecryptionRequestFactoryExtensions
{
}
