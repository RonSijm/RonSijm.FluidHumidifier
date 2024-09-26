// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationAvailSuppressionFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AvailSuppression> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.AvailSuppression>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.AvailSuppression Create()
    {
        var availSuppressionResult = CreateAvailSuppression();
        factoryAction?.Invoke(availSuppressionResult);

        return availSuppressionResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.AvailSuppression CreateAvailSuppression()
    {
        var availSuppressionResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.AvailSuppression();

        return availSuppressionResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationAvailSuppressionFactoryExtensions
{
}
