// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class SignalMapFactory(string resourceName = null, Action<Humidifier.MediaLive.SignalMap> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.SignalMap>(resourceName)
{

    protected override Humidifier.MediaLive.SignalMap Create()
    {
        var signalMapResult = CreateSignalMap();
        factoryAction?.Invoke(signalMapResult);

        return signalMapResult;
    }

    private Humidifier.MediaLive.SignalMap CreateSignalMap()
    {
        var signalMapResult = new Humidifier.MediaLive.SignalMap
        {
            GivenName = InputResourceName,
        };

        return signalMapResult;
    }

} // End Of Class

public static class SignalMapFactoryExtensions
{
}
