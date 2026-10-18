// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class ProgramFactory(string resourceName = null, Action<Humidifier.MediaTailor.Program> factoryAction = null) : ResourceFactory<Humidifier.MediaTailor.Program>(resourceName)
{

    internal List<InnerProgramAdBreakFactory> AdBreaksFactories { get; set; } = [];

    internal List<InnerProgramAudienceMediaFactory> AudienceMediaFactories { get; set; } = [];

    internal InnerProgramScheduleConfigurationFactory ScheduleConfigurationFactory { get; set; }

    protected override Humidifier.MediaTailor.Program Create()
    {
        var programResult = CreateProgram();
        factoryAction?.Invoke(programResult);

        return programResult;
    }

    private Humidifier.MediaTailor.Program CreateProgram()
    {
        var programResult = new Humidifier.MediaTailor.Program
        {
            GivenName = InputResourceName,
        };

        return programResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.Program result)
    {
        base.CreateChildren(result);

        result.AdBreaks = AdBreaksFactories.Any() ? AdBreaksFactories.Select(x => x.Build()).ToList() : null;
        result.AudienceMedia = AudienceMediaFactories.Any() ? AudienceMediaFactories.Select(x => x.Build()).ToList() : null;
        result.ScheduleConfiguration ??= ScheduleConfigurationFactory?.Build();
    }

} // End Of Class

public static class ProgramFactoryExtensions
{
    public static CombinedResult<ProgramFactory, InnerProgramAdBreakFactory> WithAdBreaks(this ProgramFactory parentFactory, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null)
    {
        var factory = new InnerProgramAdBreakFactory(subFactoryAction);
        parentFactory.AdBreaksFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProgramFactory, InnerProgramAudienceMediaFactory> WithAudienceMedia(this ProgramFactory parentFactory, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null)
    {
        var factory = new InnerProgramAudienceMediaFactory(subFactoryAction);
        parentFactory.AudienceMediaFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProgramFactory, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration(this ProgramFactory parentFactory, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null)
    {
        parentFactory.ScheduleConfigurationFactory = new InnerProgramScheduleConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleConfigurationFactory);
    }

    public static CombinedResult<ProgramFactory, T1, InnerProgramAdBreakFactory> WithAdBreaks<T1>(this CombinedResult<ProgramFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdBreaks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, InnerProgramAdBreakFactory> WithAdBreaks<T1>(this CombinedResult<T1, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdBreaks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, T2, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2>(this CombinedResult<ProgramFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, T2, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2>(this CombinedResult<T1, ProgramFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProgramFactory, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2>(this CombinedResult<T1, T2, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, T2, T3, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2, T3>(this CombinedResult<ProgramFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, T2, T3, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2, T3>(this CombinedResult<T1, ProgramFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProgramFactory, T3, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2, T3>(this CombinedResult<T1, T2, ProgramFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProgramFactory, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, T2, T3, T4, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2, T3, T4>(this CombinedResult<ProgramFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, T2, T3, T4, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2, T3, T4>(this CombinedResult<T1, ProgramFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProgramFactory, T3, T4, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProgramFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProgramFactory, T4, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProgramFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProgramFactory, InnerProgramAdBreakFactory> WithAdBreaks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AdBreak> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdBreaks(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1>(this CombinedResult<ProgramFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, WithAudienceMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1>(this CombinedResult<T1, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, WithAudienceMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, T2, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2>(this CombinedResult<ProgramFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, T2, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2>(this CombinedResult<T1, ProgramFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProgramFactory, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2>(this CombinedResult<T1, T2, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, T2, T3, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2, T3>(this CombinedResult<ProgramFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, T2, T3, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2, T3>(this CombinedResult<T1, ProgramFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProgramFactory, T3, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2, T3>(this CombinedResult<T1, T2, ProgramFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProgramFactory, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, T2, T3, T4, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2, T3, T4>(this CombinedResult<ProgramFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, T2, T3, T4, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2, T3, T4>(this CombinedResult<T1, ProgramFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProgramFactory, T3, T4, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProgramFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProgramFactory, T4, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProgramFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProgramFactory, InnerProgramAudienceMediaFactory> WithAudienceMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.AudienceMedia> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAudienceMedia(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1>(this CombinedResult<ProgramFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1>(this CombinedResult<T1, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, T2, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2>(this CombinedResult<ProgramFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, T2, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2>(this CombinedResult<T1, ProgramFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProgramFactory, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2>(this CombinedResult<T1, T2, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, T2, T3, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3>(this CombinedResult<ProgramFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, T2, T3, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3>(this CombinedResult<T1, ProgramFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProgramFactory, T3, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ProgramFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProgramFactory, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProgramFactory, T1, T2, T3, T4, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3, T4>(this CombinedResult<ProgramFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProgramFactory, T2, T3, T4, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ProgramFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProgramFactory, T3, T4, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProgramFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProgramFactory, T4, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProgramFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProgramFactory, InnerProgramScheduleConfigurationFactory> WithScheduleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProgramFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfiguration(combinedResult.T5, subFactoryAction).T2);
}
