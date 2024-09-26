// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelVpcOutputSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.VpcOutputSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.VpcOutputSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.VpcOutputSettings Create()
    {
        var vpcOutputSettingsResult = CreateVpcOutputSettings();
        factoryAction?.Invoke(vpcOutputSettingsResult);

        return vpcOutputSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.VpcOutputSettings CreateVpcOutputSettings()
    {
        var vpcOutputSettingsResult = new Humidifier.MediaLive.ChannelTypes.VpcOutputSettings();

        return vpcOutputSettingsResult;
    }

} // End Of Class

public static class InnerChannelVpcOutputSettingsFactoryExtensions
{
}
