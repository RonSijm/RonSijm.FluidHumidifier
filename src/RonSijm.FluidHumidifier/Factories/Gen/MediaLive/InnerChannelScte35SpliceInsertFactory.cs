// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelScte35SpliceInsertFactory(Action<Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsert> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsert>
{

    protected override Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsert Create()
    {
        var scte35SpliceInsertResult = CreateScte35SpliceInsert();
        factoryAction?.Invoke(scte35SpliceInsertResult);

        return scte35SpliceInsertResult;
    }

    private Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsert CreateScte35SpliceInsert()
    {
        var scte35SpliceInsertResult = new Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsert();

        return scte35SpliceInsertResult;
    }

} // End Of Class

public static class InnerChannelScte35SpliceInsertFactoryExtensions
{
}
