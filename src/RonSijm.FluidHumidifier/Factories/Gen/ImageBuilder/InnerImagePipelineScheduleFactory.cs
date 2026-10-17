// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImagePipelineScheduleFactory(Action<Humidifier.ImageBuilder.ImagePipelineTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImagePipelineTypes.Schedule>
{

    internal InnerImagePipelineAutoDisablePolicyFactory AutoDisablePolicyFactory { get; set; }

    protected override Humidifier.ImageBuilder.ImagePipelineTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.ImageBuilder.ImagePipelineTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.ImageBuilder.ImagePipelineTypes.Schedule();

        return scheduleResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.ImagePipelineTypes.Schedule result)
    {
        base.CreateChildren(result);

        result.AutoDisablePolicy ??= AutoDisablePolicyFactory?.Build();
    }

} // End Of Class

public static class InnerImagePipelineScheduleFactoryExtensions
{
    public static CombinedResult<InnerImagePipelineScheduleFactory, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy(this InnerImagePipelineScheduleFactory parentFactory, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null)
    {
        parentFactory.AutoDisablePolicyFactory = new InnerImagePipelineAutoDisablePolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutoDisablePolicyFactory);
    }

    public static CombinedResult<InnerImagePipelineScheduleFactory, T1, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1>(this CombinedResult<InnerImagePipelineScheduleFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerImagePipelineScheduleFactory, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1>(this CombinedResult<T1, InnerImagePipelineScheduleFactory> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerImagePipelineScheduleFactory, T1, T2, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2>(this CombinedResult<InnerImagePipelineScheduleFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerImagePipelineScheduleFactory, T2, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2>(this CombinedResult<T1, InnerImagePipelineScheduleFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerImagePipelineScheduleFactory, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2>(this CombinedResult<T1, T2, InnerImagePipelineScheduleFactory> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerImagePipelineScheduleFactory, T1, T2, T3, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2, T3>(this CombinedResult<InnerImagePipelineScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerImagePipelineScheduleFactory, T2, T3, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2, T3>(this CombinedResult<T1, InnerImagePipelineScheduleFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerImagePipelineScheduleFactory, T3, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerImagePipelineScheduleFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerImagePipelineScheduleFactory, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerImagePipelineScheduleFactory> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerImagePipelineScheduleFactory, T1, T2, T3, T4, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2, T3, T4>(this CombinedResult<InnerImagePipelineScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerImagePipelineScheduleFactory, T2, T3, T4, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerImagePipelineScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerImagePipelineScheduleFactory, T3, T4, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerImagePipelineScheduleFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerImagePipelineScheduleFactory, T4, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerImagePipelineScheduleFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerImagePipelineScheduleFactory, InnerImagePipelineAutoDisablePolicyFactory> WithAutoDisablePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerImagePipelineScheduleFactory> combinedResult, Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoDisablePolicy(combinedResult.T5, subFactoryAction).T2);
}
