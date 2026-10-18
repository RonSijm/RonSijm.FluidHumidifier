// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerMedicalScribeJobMedicalScribeSettingsFactory(Action<Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeSettings> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeSettings>
{

    internal InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory ClinicalNoteGenerationSettingsFactory { get; set; }

    protected override Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeSettings Create()
    {
        var medicalScribeSettingsResult = CreateMedicalScribeSettings();
        factoryAction?.Invoke(medicalScribeSettingsResult);

        return medicalScribeSettingsResult;
    }

    private Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeSettings CreateMedicalScribeSettings()
    {
        var medicalScribeSettingsResult = new Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeSettings();

        return medicalScribeSettingsResult;
    }
    public override void CreateChildren(Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeSettings result)
    {
        base.CreateChildren(result);

        result.ClinicalNoteGenerationSettings ??= ClinicalNoteGenerationSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerMedicalScribeJobMedicalScribeSettingsFactoryExtensions
{
    public static CombinedResult<InnerMedicalScribeJobMedicalScribeSettingsFactory, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings(this InnerMedicalScribeJobMedicalScribeSettingsFactory parentFactory, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null)
    {
        parentFactory.ClinicalNoteGenerationSettingsFactory = new InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClinicalNoteGenerationSettingsFactory);
    }

    public static CombinedResult<InnerMedicalScribeJobMedicalScribeSettingsFactory, T1, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1>(this CombinedResult<InnerMedicalScribeJobMedicalScribeSettingsFactory, T1> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMedicalScribeJobMedicalScribeSettingsFactory, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1>(this CombinedResult<T1, InnerMedicalScribeJobMedicalScribeSettingsFactory> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMedicalScribeJobMedicalScribeSettingsFactory, T1, T2, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2>(this CombinedResult<InnerMedicalScribeJobMedicalScribeSettingsFactory, T1, T2> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMedicalScribeJobMedicalScribeSettingsFactory, T2, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2>(this CombinedResult<T1, InnerMedicalScribeJobMedicalScribeSettingsFactory, T2> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMedicalScribeJobMedicalScribeSettingsFactory, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2>(this CombinedResult<T1, T2, InnerMedicalScribeJobMedicalScribeSettingsFactory> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMedicalScribeJobMedicalScribeSettingsFactory, T1, T2, T3, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2, T3>(this CombinedResult<InnerMedicalScribeJobMedicalScribeSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMedicalScribeJobMedicalScribeSettingsFactory, T2, T3, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2, T3>(this CombinedResult<T1, InnerMedicalScribeJobMedicalScribeSettingsFactory, T2, T3> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMedicalScribeJobMedicalScribeSettingsFactory, T3, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerMedicalScribeJobMedicalScribeSettingsFactory, T3> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMedicalScribeJobMedicalScribeSettingsFactory, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMedicalScribeJobMedicalScribeSettingsFactory> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMedicalScribeJobMedicalScribeSettingsFactory, T1, T2, T3, T4, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2, T3, T4>(this CombinedResult<InnerMedicalScribeJobMedicalScribeSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMedicalScribeJobMedicalScribeSettingsFactory, T2, T3, T4, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerMedicalScribeJobMedicalScribeSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMedicalScribeJobMedicalScribeSettingsFactory, T3, T4, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMedicalScribeJobMedicalScribeSettingsFactory, T3, T4> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMedicalScribeJobMedicalScribeSettingsFactory, T4, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMedicalScribeJobMedicalScribeSettingsFactory, T4> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMedicalScribeJobMedicalScribeSettingsFactory, InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory> WithClinicalNoteGenerationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMedicalScribeJobMedicalScribeSettingsFactory> combinedResult, Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClinicalNoteGenerationSettings(combinedResult.T5, subFactoryAction).T2);
}
