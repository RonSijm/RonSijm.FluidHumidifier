// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerChannelSlateSourceFactory(Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ChannelTypes.SlateSource>
{

    protected override Humidifier.MediaTailor.ChannelTypes.SlateSource Create()
    {
        var slateSourceResult = CreateSlateSource();
        factoryAction?.Invoke(slateSourceResult);

        return slateSourceResult;
    }

    private Humidifier.MediaTailor.ChannelTypes.SlateSource CreateSlateSource()
    {
        var slateSourceResult = new Humidifier.MediaTailor.ChannelTypes.SlateSource();

        return slateSourceResult;
    }

} // End Of Class

public static class InnerChannelSlateSourceFactoryExtensions
{
}
