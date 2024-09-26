// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelEsamFactory(Action<Humidifier.MediaLive.ChannelTypes.Esam> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.Esam>
{

    protected override Humidifier.MediaLive.ChannelTypes.Esam Create()
    {
        var esamResult = CreateEsam();
        factoryAction?.Invoke(esamResult);

        return esamResult;
    }

    private Humidifier.MediaLive.ChannelTypes.Esam CreateEsam()
    {
        var esamResult = new Humidifier.MediaLive.ChannelTypes.Esam();

        return esamResult;
    }

} // End Of Class

public static class InnerChannelEsamFactoryExtensions
{
}
