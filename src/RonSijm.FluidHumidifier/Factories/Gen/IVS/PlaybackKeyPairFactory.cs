// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class PlaybackKeyPairFactory(string resourceName = null, Action<Humidifier.IVS.PlaybackKeyPair> factoryAction = null) : ResourceFactory<Humidifier.IVS.PlaybackKeyPair>(resourceName)
{

    protected override Humidifier.IVS.PlaybackKeyPair Create()
    {
        var playbackKeyPairResult = CreatePlaybackKeyPair();
        factoryAction?.Invoke(playbackKeyPairResult);

        return playbackKeyPairResult;
    }

    private Humidifier.IVS.PlaybackKeyPair CreatePlaybackKeyPair()
    {
        var playbackKeyPairResult = new Humidifier.IVS.PlaybackKeyPair
        {
            GivenName = InputResourceName,
        };

        return playbackKeyPairResult;
    }

} // End Of Class

public static class PlaybackKeyPairFactoryExtensions
{
}
