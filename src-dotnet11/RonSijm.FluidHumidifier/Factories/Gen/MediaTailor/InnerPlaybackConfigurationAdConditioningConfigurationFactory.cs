// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationAdConditioningConfigurationFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdConditioningConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdConditioningConfiguration>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.AdConditioningConfiguration Create()
    {
        var adConditioningConfigurationResult = CreateAdConditioningConfiguration();
        factoryAction?.Invoke(adConditioningConfigurationResult);

        return adConditioningConfigurationResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.AdConditioningConfiguration CreateAdConditioningConfiguration()
    {
        var adConditioningConfigurationResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.AdConditioningConfiguration();

        return adConditioningConfigurationResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationAdConditioningConfigurationFactoryExtensions
{
}
