// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerChannelHlsIngestFactory(Action<Humidifier.MediaPackage.ChannelTypes.HlsIngest> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.ChannelTypes.HlsIngest>
{

    protected override Humidifier.MediaPackage.ChannelTypes.HlsIngest Create()
    {
        var hlsIngestResult = CreateHlsIngest();
        factoryAction?.Invoke(hlsIngestResult);

        return hlsIngestResult;
    }

    private Humidifier.MediaPackage.ChannelTypes.HlsIngest CreateHlsIngest()
    {
        var hlsIngestResult = new Humidifier.MediaPackage.ChannelTypes.HlsIngest();

        return hlsIngestResult;
    }

} // End Of Class

public static class InnerChannelHlsIngestFactoryExtensions
{
}
