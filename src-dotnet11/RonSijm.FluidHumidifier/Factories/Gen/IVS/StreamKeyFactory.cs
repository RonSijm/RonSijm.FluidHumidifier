// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class StreamKeyFactory(string resourceName = null, Action<Humidifier.IVS.StreamKey> factoryAction = null) : ResourceFactory<Humidifier.IVS.StreamKey>(resourceName)
{

    protected override Humidifier.IVS.StreamKey Create()
    {
        var streamKeyResult = CreateStreamKey();
        factoryAction?.Invoke(streamKeyResult);

        return streamKeyResult;
    }

    private Humidifier.IVS.StreamKey CreateStreamKey()
    {
        var streamKeyResult = new Humidifier.IVS.StreamKey
        {
            GivenName = InputResourceName,
        };

        return streamKeyResult;
    }

} // End Of Class

public static class StreamKeyFactoryExtensions
{
}
