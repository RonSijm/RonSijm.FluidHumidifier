// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerProgramScheduleConfigurationFactory(Action<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration>
{

    internal InnerProgramTransitionFactory TransitionFactory { get; set; }

    internal InnerProgramClipRangeFactory ClipRangeFactory { get; set; }

    protected override Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration Create()
    {
        var scheduleConfigurationResult = CreateScheduleConfiguration();
        factoryAction?.Invoke(scheduleConfigurationResult);

        return scheduleConfigurationResult;
    }

    private Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration CreateScheduleConfiguration()
    {
        var scheduleConfigurationResult = new Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration();

        return scheduleConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.ProgramTypes.ScheduleConfiguration result)
    {
        base.CreateChildren(result);

        result.Transition ??= TransitionFactory?.Build();
        result.ClipRange ??= ClipRangeFactory?.Build();
    }

} // End Of Class

public static class InnerProgramScheduleConfigurationFactoryExtensions
{
    public static CombinedResult<InnerProgramScheduleConfigurationFactory, InnerProgramTransitionFactory> WithTransition(this InnerProgramScheduleConfigurationFactory parentFactory, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null)
    {
        parentFactory.TransitionFactory = new InnerProgramTransitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TransitionFactory);
    }

    public static CombinedResult<InnerProgramScheduleConfigurationFactory, InnerProgramClipRangeFactory> WithClipRange(this InnerProgramScheduleConfigurationFactory parentFactory, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null)
    {
        parentFactory.ClipRangeFactory = new InnerProgramClipRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClipRangeFactory);
    }

    public static CombinedResult<InnerProgramScheduleConfigurationFactory, T1, InnerProgramTransitionFactory> WithTransition<T1>(this CombinedResult<InnerProgramScheduleConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProgramScheduleConfigurationFactory, InnerProgramTransitionFactory> WithTransition<T1>(this CombinedResult<T1, InnerProgramScheduleConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, WithTransition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2, InnerProgramTransitionFactory> WithTransition<T1, T2>(this CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2, InnerProgramTransitionFactory> WithTransition<T1, T2>(this CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory, InnerProgramTransitionFactory> WithTransition<T1, T2>(this CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2, T3, InnerProgramTransitionFactory> WithTransition<T1, T2, T3>(this CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2, T3, InnerProgramTransitionFactory> WithTransition<T1, T2, T3>(this CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory, T3, InnerProgramTransitionFactory> WithTransition<T1, T2, T3>(this CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProgramScheduleConfigurationFactory, InnerProgramTransitionFactory> WithTransition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProgramScheduleConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2, T3, T4, InnerProgramTransitionFactory> WithTransition<T1, T2, T3, T4>(this CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2, T3, T4, InnerProgramTransitionFactory> WithTransition<T1, T2, T3, T4>(this CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory, T3, T4, InnerProgramTransitionFactory> WithTransition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProgramScheduleConfigurationFactory, T4, InnerProgramTransitionFactory> WithTransition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProgramScheduleConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerProgramScheduleConfigurationFactory, InnerProgramTransitionFactory> WithTransition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProgramScheduleConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.Transition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTransition(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerProgramScheduleConfigurationFactory, T1, InnerProgramClipRangeFactory> WithClipRange<T1>(this CombinedResult<InnerProgramScheduleConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithClipRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProgramScheduleConfigurationFactory, InnerProgramClipRangeFactory> WithClipRange<T1>(this CombinedResult<T1, InnerProgramScheduleConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithClipRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2, InnerProgramClipRangeFactory> WithClipRange<T1, T2>(this CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2, InnerProgramClipRangeFactory> WithClipRange<T1, T2>(this CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory, InnerProgramClipRangeFactory> WithClipRange<T1, T2>(this CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2, T3, InnerProgramClipRangeFactory> WithClipRange<T1, T2, T3>(this CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2, T3, InnerProgramClipRangeFactory> WithClipRange<T1, T2, T3>(this CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory, T3, InnerProgramClipRangeFactory> WithClipRange<T1, T2, T3>(this CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProgramScheduleConfigurationFactory, InnerProgramClipRangeFactory> WithClipRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProgramScheduleConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2, T3, T4, InnerProgramClipRangeFactory> WithClipRange<T1, T2, T3, T4>(this CombinedResult<InnerProgramScheduleConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2, T3, T4, InnerProgramClipRangeFactory> WithClipRange<T1, T2, T3, T4>(this CombinedResult<T1, InnerProgramScheduleConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory, T3, T4, InnerProgramClipRangeFactory> WithClipRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProgramScheduleConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProgramScheduleConfigurationFactory, T4, InnerProgramClipRangeFactory> WithClipRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProgramScheduleConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerProgramScheduleConfigurationFactory, InnerProgramClipRangeFactory> WithClipRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProgramScheduleConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClipRange(combinedResult.T5, subFactoryAction).T2);
}
