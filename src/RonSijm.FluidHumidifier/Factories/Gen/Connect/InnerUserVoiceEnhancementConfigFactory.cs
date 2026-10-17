// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserVoiceEnhancementConfigFactory(Action<Humidifier.Connect.UserTypes.VoiceEnhancementConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserTypes.VoiceEnhancementConfig>
{

    protected override Humidifier.Connect.UserTypes.VoiceEnhancementConfig Create()
    {
        var voiceEnhancementConfigResult = CreateVoiceEnhancementConfig();
        factoryAction?.Invoke(voiceEnhancementConfigResult);

        return voiceEnhancementConfigResult;
    }

    private Humidifier.Connect.UserTypes.VoiceEnhancementConfig CreateVoiceEnhancementConfig()
    {
        var voiceEnhancementConfigResult = new Humidifier.Connect.UserTypes.VoiceEnhancementConfig();

        return voiceEnhancementConfigResult;
    }

} // End Of Class

public static class InnerUserVoiceEnhancementConfigFactoryExtensions
{
}
