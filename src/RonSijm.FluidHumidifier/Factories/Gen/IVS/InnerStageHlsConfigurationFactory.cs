// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerStageHlsConfigurationFactory(Action<Humidifier.IVS.StageTypes.HlsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.StageTypes.HlsConfiguration>
{

    internal InnerStageParticipantRecordingHlsConfigurationFactory ParticipantRecordingHlsConfigurationFactory { get; set; }

    protected override Humidifier.IVS.StageTypes.HlsConfiguration Create()
    {
        var hlsConfigurationResult = CreateHlsConfiguration();
        factoryAction?.Invoke(hlsConfigurationResult);

        return hlsConfigurationResult;
    }

    private Humidifier.IVS.StageTypes.HlsConfiguration CreateHlsConfiguration()
    {
        var hlsConfigurationResult = new Humidifier.IVS.StageTypes.HlsConfiguration();

        return hlsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVS.StageTypes.HlsConfiguration result)
    {
        base.CreateChildren(result);

        result.ParticipantRecordingHlsConfiguration ??= ParticipantRecordingHlsConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerStageHlsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerStageHlsConfigurationFactory, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration(this InnerStageHlsConfigurationFactory parentFactory, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null)
    {
        parentFactory.ParticipantRecordingHlsConfigurationFactory = new InnerStageParticipantRecordingHlsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParticipantRecordingHlsConfigurationFactory);
    }

    public static CombinedResult<InnerStageHlsConfigurationFactory, T1, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1>(this CombinedResult<InnerStageHlsConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStageHlsConfigurationFactory, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1>(this CombinedResult<T1, InnerStageHlsConfigurationFactory> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerStageHlsConfigurationFactory, T1, T2, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2>(this CombinedResult<InnerStageHlsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStageHlsConfigurationFactory, T2, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2>(this CombinedResult<T1, InnerStageHlsConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStageHlsConfigurationFactory, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerStageHlsConfigurationFactory> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerStageHlsConfigurationFactory, T1, T2, T3, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2, T3>(this CombinedResult<InnerStageHlsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStageHlsConfigurationFactory, T2, T3, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerStageHlsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStageHlsConfigurationFactory, T3, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerStageHlsConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerStageHlsConfigurationFactory, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStageHlsConfigurationFactory> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerStageHlsConfigurationFactory, T1, T2, T3, T4, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerStageHlsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStageHlsConfigurationFactory, T2, T3, T4, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerStageHlsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStageHlsConfigurationFactory, T3, T4, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStageHlsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerStageHlsConfigurationFactory, T4, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStageHlsConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerStageHlsConfigurationFactory, InnerStageParticipantRecordingHlsConfigurationFactory> WithParticipantRecordingHlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStageHlsConfigurationFactory> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantRecordingHlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantRecordingHlsConfiguration(combinedResult.T5, subFactoryAction).T2);
}
