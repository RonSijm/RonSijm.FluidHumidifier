// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelNielsenConfigurationFactory(Action<Humidifier.MediaLive.ChannelTypes.NielsenConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.NielsenConfiguration>
{

    protected override Humidifier.MediaLive.ChannelTypes.NielsenConfiguration Create()
    {
        var nielsenConfigurationResult = CreateNielsenConfiguration();
        factoryAction?.Invoke(nielsenConfigurationResult);

        return nielsenConfigurationResult;
    }

    private Humidifier.MediaLive.ChannelTypes.NielsenConfiguration CreateNielsenConfiguration()
    {
        var nielsenConfigurationResult = new Humidifier.MediaLive.ChannelTypes.NielsenConfiguration();

        return nielsenConfigurationResult;
    }

} // End Of Class

public static class InnerChannelNielsenConfigurationFactoryExtensions
{
}
