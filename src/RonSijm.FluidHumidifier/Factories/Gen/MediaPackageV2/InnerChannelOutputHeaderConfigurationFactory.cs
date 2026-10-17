// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerChannelOutputHeaderConfigurationFactory(Action<Humidifier.MediaPackageV2.ChannelTypes.OutputHeaderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.ChannelTypes.OutputHeaderConfiguration>
{

    protected override Humidifier.MediaPackageV2.ChannelTypes.OutputHeaderConfiguration Create()
    {
        var outputHeaderConfigurationResult = CreateOutputHeaderConfiguration();
        factoryAction?.Invoke(outputHeaderConfigurationResult);

        return outputHeaderConfigurationResult;
    }

    private Humidifier.MediaPackageV2.ChannelTypes.OutputHeaderConfiguration CreateOutputHeaderConfiguration()
    {
        var outputHeaderConfigurationResult = new Humidifier.MediaPackageV2.ChannelTypes.OutputHeaderConfiguration();

        return outputHeaderConfigurationResult;
    }

} // End Of Class

public static class InnerChannelOutputHeaderConfigurationFactoryExtensions
{
}
