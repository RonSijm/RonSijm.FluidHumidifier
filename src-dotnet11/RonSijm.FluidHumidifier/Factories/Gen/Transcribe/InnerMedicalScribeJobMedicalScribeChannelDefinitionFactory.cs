// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerMedicalScribeJobMedicalScribeChannelDefinitionFactory(Action<Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeChannelDefinition> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeChannelDefinition>
{

    protected override Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeChannelDefinition Create()
    {
        var medicalScribeChannelDefinitionResult = CreateMedicalScribeChannelDefinition();
        factoryAction?.Invoke(medicalScribeChannelDefinitionResult);

        return medicalScribeChannelDefinitionResult;
    }

    private Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeChannelDefinition CreateMedicalScribeChannelDefinition()
    {
        var medicalScribeChannelDefinitionResult = new Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeChannelDefinition();

        return medicalScribeChannelDefinitionResult;
    }

} // End Of Class

public static class InnerMedicalScribeJobMedicalScribeChannelDefinitionFactoryExtensions
{
}
