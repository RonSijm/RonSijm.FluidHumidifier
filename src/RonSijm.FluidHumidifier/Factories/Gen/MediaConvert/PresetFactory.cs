// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConvert;

public class PresetFactory(string resourceName = null, Action<Humidifier.MediaConvert.Preset> factoryAction = null) : ResourceFactory<Humidifier.MediaConvert.Preset>(resourceName)
{

    protected override Humidifier.MediaConvert.Preset Create()
    {
        var presetResult = CreatePreset();
        factoryAction?.Invoke(presetResult);

        return presetResult;
    }

    private Humidifier.MediaConvert.Preset CreatePreset()
    {
        var presetResult = new Humidifier.MediaConvert.Preset
        {
            GivenName = InputResourceName,
        };

        return presetResult;
    }

} // End Of Class

public static class PresetFactoryExtensions
{
}
