// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Oam;

public class SinkFactory(string resourceName = null, Action<Humidifier.Oam.Sink> factoryAction = null) : ResourceFactory<Humidifier.Oam.Sink>(resourceName)
{

    protected override Humidifier.Oam.Sink Create()
    {
        var sinkResult = CreateSink();
        factoryAction?.Invoke(sinkResult);

        return sinkResult;
    }

    private Humidifier.Oam.Sink CreateSink()
    {
        var sinkResult = new Humidifier.Oam.Sink
        {
            GivenName = InputResourceName,
        };

        return sinkResult;
    }

} // End Of Class

public static class SinkFactoryExtensions
{
}
