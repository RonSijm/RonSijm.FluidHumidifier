// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerChannelInputSwitchConfigurationFactory(Action<Humidifier.MediaPackageV2.ChannelTypes.InputSwitchConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.ChannelTypes.InputSwitchConfiguration>
{

    protected override Humidifier.MediaPackageV2.ChannelTypes.InputSwitchConfiguration Create()
    {
        var inputSwitchConfigurationResult = CreateInputSwitchConfiguration();
        factoryAction?.Invoke(inputSwitchConfigurationResult);

        return inputSwitchConfigurationResult;
    }

    private Humidifier.MediaPackageV2.ChannelTypes.InputSwitchConfiguration CreateInputSwitchConfiguration()
    {
        var inputSwitchConfigurationResult = new Humidifier.MediaPackageV2.ChannelTypes.InputSwitchConfiguration();

        return inputSwitchConfigurationResult;
    }

} // End Of Class

public static class InnerChannelInputSwitchConfigurationFactoryExtensions
{
}
