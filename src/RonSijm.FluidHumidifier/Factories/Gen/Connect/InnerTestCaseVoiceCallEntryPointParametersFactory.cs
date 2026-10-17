// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerTestCaseVoiceCallEntryPointParametersFactory(Action<Humidifier.Connect.TestCaseTypes.VoiceCallEntryPointParameters> factoryAction = null) : SubResourceFactory<Humidifier.Connect.TestCaseTypes.VoiceCallEntryPointParameters>
{

    protected override Humidifier.Connect.TestCaseTypes.VoiceCallEntryPointParameters Create()
    {
        var voiceCallEntryPointParametersResult = CreateVoiceCallEntryPointParameters();
        factoryAction?.Invoke(voiceCallEntryPointParametersResult);

        return voiceCallEntryPointParametersResult;
    }

    private Humidifier.Connect.TestCaseTypes.VoiceCallEntryPointParameters CreateVoiceCallEntryPointParameters()
    {
        var voiceCallEntryPointParametersResult = new Humidifier.Connect.TestCaseTypes.VoiceCallEntryPointParameters();

        return voiceCallEntryPointParametersResult;
    }

} // End Of Class

public static class InnerTestCaseVoiceCallEntryPointParametersFactoryExtensions
{
}
