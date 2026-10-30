// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class WaveFactory(string resourceName = null, Action<Humidifier.MGN.Wave> factoryAction = null) : ResourceFactory<Humidifier.MGN.Wave>(resourceName)
{

    protected override Humidifier.MGN.Wave Create()
    {
        var waveResult = CreateWave();
        factoryAction?.Invoke(waveResult);

        return waveResult;
    }

    private Humidifier.MGN.Wave CreateWave()
    {
        var waveResult = new Humidifier.MGN.Wave
        {
            GivenName = InputResourceName,
        };

        return waveResult;
    }

} // End Of Class

public static class WaveFactoryExtensions
{
}
