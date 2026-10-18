// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelInputLocationFactory(Action<Humidifier.MediaLive.ChannelTypes.InputLocation> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.InputLocation>
{

    protected override Humidifier.MediaLive.ChannelTypes.InputLocation Create()
    {
        var inputLocationResult = CreateInputLocation();
        factoryAction?.Invoke(inputLocationResult);

        return inputLocationResult;
    }

    private Humidifier.MediaLive.ChannelTypes.InputLocation CreateInputLocation()
    {
        var inputLocationResult = new Humidifier.MediaLive.ChannelTypes.InputLocation();

        return inputLocationResult;
    }

} // End Of Class

public static class InnerChannelInputLocationFactoryExtensions
{
}
