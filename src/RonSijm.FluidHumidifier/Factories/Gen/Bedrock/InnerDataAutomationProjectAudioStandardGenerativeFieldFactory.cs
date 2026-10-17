// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataAutomationProjectAudioStandardGenerativeFieldFactory(Action<Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardGenerativeField> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardGenerativeField>
{

    protected override Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardGenerativeField Create()
    {
        var audioStandardGenerativeFieldResult = CreateAudioStandardGenerativeField();
        factoryAction?.Invoke(audioStandardGenerativeFieldResult);

        return audioStandardGenerativeFieldResult;
    }

    private Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardGenerativeField CreateAudioStandardGenerativeField()
    {
        var audioStandardGenerativeFieldResult = new Humidifier.Bedrock.DataAutomationProjectTypes.AudioStandardGenerativeField();

        return audioStandardGenerativeFieldResult;
    }

} // End Of Class

public static class InnerDataAutomationProjectAudioStandardGenerativeFieldFactoryExtensions
{
}
