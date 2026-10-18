// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class MedicalTranscriptionJobFactory(string resourceName = null, Action<Humidifier.Transcribe.MedicalTranscriptionJob> factoryAction = null) : ResourceFactory<Humidifier.Transcribe.MedicalTranscriptionJob>(resourceName)
{

    internal InnerMedicalTranscriptionJobMediaFactory MediaFactory { get; set; }

    internal InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory SettingsFactory { get; set; }

    protected override Humidifier.Transcribe.MedicalTranscriptionJob Create()
    {
        var medicalTranscriptionJobResult = CreateMedicalTranscriptionJob();
        factoryAction?.Invoke(medicalTranscriptionJobResult);

        return medicalTranscriptionJobResult;
    }

    private Humidifier.Transcribe.MedicalTranscriptionJob CreateMedicalTranscriptionJob()
    {
        var medicalTranscriptionJobResult = new Humidifier.Transcribe.MedicalTranscriptionJob
        {
            GivenName = InputResourceName,
        };

        return medicalTranscriptionJobResult;
    }
    public override void CreateChildren(Humidifier.Transcribe.MedicalTranscriptionJob result)
    {
        base.CreateChildren(result);

        result.Media ??= MediaFactory?.Build();
        result.Settings ??= SettingsFactory?.Build();
    }

} // End Of Class

public static class MedicalTranscriptionJobFactoryExtensions
{
    public static CombinedResult<MedicalTranscriptionJobFactory, InnerMedicalTranscriptionJobMediaFactory> WithMedia(this MedicalTranscriptionJobFactory parentFactory, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null)
    {
        parentFactory.MediaFactory = new InnerMedicalTranscriptionJobMediaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MediaFactory);
    }

    public static CombinedResult<MedicalTranscriptionJobFactory, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings(this MedicalTranscriptionJobFactory parentFactory, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null)
    {
        parentFactory.SettingsFactory = new InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SettingsFactory);
    }

    public static CombinedResult<MedicalTranscriptionJobFactory, T1, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1>(this CombinedResult<MedicalTranscriptionJobFactory, T1> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MedicalTranscriptionJobFactory, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1>(this CombinedResult<T1, MedicalTranscriptionJobFactory> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MedicalTranscriptionJobFactory, T1, T2, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2>(this CombinedResult<MedicalTranscriptionJobFactory, T1, T2> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MedicalTranscriptionJobFactory, T2, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2>(this CombinedResult<T1, MedicalTranscriptionJobFactory, T2> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MedicalTranscriptionJobFactory, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2>(this CombinedResult<T1, T2, MedicalTranscriptionJobFactory> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MedicalTranscriptionJobFactory, T1, T2, T3, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2, T3>(this CombinedResult<MedicalTranscriptionJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MedicalTranscriptionJobFactory, T2, T3, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2, T3>(this CombinedResult<T1, MedicalTranscriptionJobFactory, T2, T3> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MedicalTranscriptionJobFactory, T3, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2, T3>(this CombinedResult<T1, T2, MedicalTranscriptionJobFactory, T3> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MedicalTranscriptionJobFactory, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2, T3>(this CombinedResult<T1, T2, T3, MedicalTranscriptionJobFactory> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MedicalTranscriptionJobFactory, T1, T2, T3, T4, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<MedicalTranscriptionJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MedicalTranscriptionJobFactory, T2, T3, T4, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, MedicalTranscriptionJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MedicalTranscriptionJobFactory, T3, T4, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, MedicalTranscriptionJobFactory, T3, T4> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MedicalTranscriptionJobFactory, T4, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MedicalTranscriptionJobFactory, T4> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MedicalTranscriptionJobFactory, InnerMedicalTranscriptionJobMediaFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MedicalTranscriptionJobFactory> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<MedicalTranscriptionJobFactory, T1, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1>(this CombinedResult<MedicalTranscriptionJobFactory, T1> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MedicalTranscriptionJobFactory, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1>(this CombinedResult<T1, MedicalTranscriptionJobFactory> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MedicalTranscriptionJobFactory, T1, T2, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2>(this CombinedResult<MedicalTranscriptionJobFactory, T1, T2> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MedicalTranscriptionJobFactory, T2, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2>(this CombinedResult<T1, MedicalTranscriptionJobFactory, T2> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MedicalTranscriptionJobFactory, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2>(this CombinedResult<T1, T2, MedicalTranscriptionJobFactory> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MedicalTranscriptionJobFactory, T1, T2, T3, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2, T3>(this CombinedResult<MedicalTranscriptionJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MedicalTranscriptionJobFactory, T2, T3, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2, T3>(this CombinedResult<T1, MedicalTranscriptionJobFactory, T2, T3> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MedicalTranscriptionJobFactory, T3, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2, T3>(this CombinedResult<T1, T2, MedicalTranscriptionJobFactory, T3> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MedicalTranscriptionJobFactory, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, MedicalTranscriptionJobFactory> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MedicalTranscriptionJobFactory, T1, T2, T3, T4, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<MedicalTranscriptionJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MedicalTranscriptionJobFactory, T2, T3, T4, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, MedicalTranscriptionJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MedicalTranscriptionJobFactory, T3, T4, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, MedicalTranscriptionJobFactory, T3, T4> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MedicalTranscriptionJobFactory, T4, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MedicalTranscriptionJobFactory, T4> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MedicalTranscriptionJobFactory, InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory> WithSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MedicalTranscriptionJobFactory> combinedResult, Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSettings(combinedResult.T5, subFactoryAction).T2);
}
