// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConvert;

public class InnerJobAccelerationSettingsFactory(Action<Humidifier.MediaConvert.JobTypes.AccelerationSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaConvert.JobTypes.AccelerationSettings>
{

    protected override Humidifier.MediaConvert.JobTypes.AccelerationSettings Create()
    {
        var accelerationSettingsResult = CreateAccelerationSettings();
        factoryAction?.Invoke(accelerationSettingsResult);

        return accelerationSettingsResult;
    }

    private Humidifier.MediaConvert.JobTypes.AccelerationSettings CreateAccelerationSettings()
    {
        var accelerationSettingsResult = new Humidifier.MediaConvert.JobTypes.AccelerationSettings();

        return accelerationSettingsResult;
    }

} // End Of Class

public static class InnerJobAccelerationSettingsFactoryExtensions
{
}
