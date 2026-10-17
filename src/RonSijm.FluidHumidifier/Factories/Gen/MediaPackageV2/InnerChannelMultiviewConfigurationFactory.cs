// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerChannelMultiviewConfigurationFactory(Action<Humidifier.MediaPackageV2.ChannelTypes.MultiviewConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.ChannelTypes.MultiviewConfiguration>
{

    protected override Humidifier.MediaPackageV2.ChannelTypes.MultiviewConfiguration Create()
    {
        var multiviewConfigurationResult = CreateMultiviewConfiguration();
        factoryAction?.Invoke(multiviewConfigurationResult);

        return multiviewConfigurationResult;
    }

    private Humidifier.MediaPackageV2.ChannelTypes.MultiviewConfiguration CreateMultiviewConfiguration()
    {
        var multiviewConfigurationResult = new Humidifier.MediaPackageV2.ChannelTypes.MultiviewConfiguration();

        return multiviewConfigurationResult;
    }

} // End Of Class

public static class InnerChannelMultiviewConfigurationFactoryExtensions
{
}
