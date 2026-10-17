// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRoomsML;

public class MLInputChannelFactory(string resourceName = null, Action<Humidifier.CleanRoomsML.MLInputChannel> factoryAction = null) : ResourceFactory<Humidifier.CleanRoomsML.MLInputChannel>(resourceName)
{

    protected override Humidifier.CleanRoomsML.MLInputChannel Create()
    {
        var mLInputChannelResult = CreateMLInputChannel();
        factoryAction?.Invoke(mLInputChannelResult);

        return mLInputChannelResult;
    }

    private Humidifier.CleanRoomsML.MLInputChannel CreateMLInputChannel()
    {
        var mLInputChannelResult = new Humidifier.CleanRoomsML.MLInputChannel
        {
            GivenName = InputResourceName,
        };

        return mLInputChannelResult;
    }

} // End Of Class

public static class MLInputChannelFactoryExtensions
{
}
