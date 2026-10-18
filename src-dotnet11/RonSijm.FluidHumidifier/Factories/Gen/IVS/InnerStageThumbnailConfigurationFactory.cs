// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerStageThumbnailConfigurationFactory(Action<Humidifier.IVS.StageTypes.ThumbnailConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.StageTypes.ThumbnailConfiguration>
{

    internal InnerStageParticipantThumbnailConfigurationFactory ParticipantThumbnailConfigurationFactory { get; set; }

    protected override Humidifier.IVS.StageTypes.ThumbnailConfiguration Create()
    {
        var thumbnailConfigurationResult = CreateThumbnailConfiguration();
        factoryAction?.Invoke(thumbnailConfigurationResult);

        return thumbnailConfigurationResult;
    }

    private Humidifier.IVS.StageTypes.ThumbnailConfiguration CreateThumbnailConfiguration()
    {
        var thumbnailConfigurationResult = new Humidifier.IVS.StageTypes.ThumbnailConfiguration();

        return thumbnailConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVS.StageTypes.ThumbnailConfiguration result)
    {
        base.CreateChildren(result);

        result.ParticipantThumbnailConfiguration ??= ParticipantThumbnailConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerStageThumbnailConfigurationFactoryExtensions
{
    public static CombinedResult<InnerStageThumbnailConfigurationFactory, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration(this InnerStageThumbnailConfigurationFactory parentFactory, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null)
    {
        parentFactory.ParticipantThumbnailConfigurationFactory = new InnerStageParticipantThumbnailConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParticipantThumbnailConfigurationFactory);
    }

    public static CombinedResult<InnerStageThumbnailConfigurationFactory, T1, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1>(this CombinedResult<InnerStageThumbnailConfigurationFactory, T1> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStageThumbnailConfigurationFactory, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1>(this CombinedResult<T1, InnerStageThumbnailConfigurationFactory> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerStageThumbnailConfigurationFactory, T1, T2, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2>(this CombinedResult<InnerStageThumbnailConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStageThumbnailConfigurationFactory, T2, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2>(this CombinedResult<T1, InnerStageThumbnailConfigurationFactory, T2> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStageThumbnailConfigurationFactory, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerStageThumbnailConfigurationFactory> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerStageThumbnailConfigurationFactory, T1, T2, T3, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2, T3>(this CombinedResult<InnerStageThumbnailConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStageThumbnailConfigurationFactory, T2, T3, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerStageThumbnailConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStageThumbnailConfigurationFactory, T3, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerStageThumbnailConfigurationFactory, T3> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerStageThumbnailConfigurationFactory, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStageThumbnailConfigurationFactory> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerStageThumbnailConfigurationFactory, T1, T2, T3, T4, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerStageThumbnailConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStageThumbnailConfigurationFactory, T2, T3, T4, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerStageThumbnailConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStageThumbnailConfigurationFactory, T3, T4, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStageThumbnailConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerStageThumbnailConfigurationFactory, T4, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStageThumbnailConfigurationFactory, T4> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerStageThumbnailConfigurationFactory, InnerStageParticipantThumbnailConfigurationFactory> WithParticipantThumbnailConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStageThumbnailConfigurationFactory> combinedResult, Action<Humidifier.IVS.StageTypes.ParticipantThumbnailConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParticipantThumbnailConfiguration(combinedResult.T5, subFactoryAction).T2);
}
