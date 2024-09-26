// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConvert;

public class InnerJobTemplateAccelerationSettingsFactory(Action<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings>
{

    protected override Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings Create()
    {
        var accelerationSettingsResult = CreateAccelerationSettings();
        factoryAction?.Invoke(accelerationSettingsResult);

        return accelerationSettingsResult;
    }

    private Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings CreateAccelerationSettings()
    {
        var accelerationSettingsResult = new Humidifier.MediaConvert.JobTemplateTypes.AccelerationSettings();

        return accelerationSettingsResult;
    }

} // End Of Class

public static class InnerJobTemplateAccelerationSettingsFactoryExtensions
{
}
