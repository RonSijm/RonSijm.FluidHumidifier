// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerHoursOfOperationHoursOfOperationConfigFactory(Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig>
{

    internal InnerHoursOfOperationHoursOfOperationTimeSliceFactory EndTimeFactory { get; set; }

    internal InnerHoursOfOperationHoursOfOperationTimeSliceFactory StartTimeFactory { get; set; }

    protected override Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig Create()
    {
        var hoursOfOperationConfigResult = CreateHoursOfOperationConfig();
        factoryAction?.Invoke(hoursOfOperationConfigResult);

        return hoursOfOperationConfigResult;
    }

    private Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig CreateHoursOfOperationConfig()
    {
        var hoursOfOperationConfigResult = new Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig();

        return hoursOfOperationConfigResult;
    }
    public override void CreateChildren(Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig result)
    {
        base.CreateChildren(result);

        result.EndTime ??= EndTimeFactory?.Build();
        result.StartTime ??= StartTimeFactory?.Build();
    }

} // End Of Class

public static class InnerHoursOfOperationHoursOfOperationConfigFactoryExtensions
{
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime(this InnerHoursOfOperationHoursOfOperationConfigFactory parentFactory, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null)
    {
        parentFactory.EndTimeFactory = new InnerHoursOfOperationHoursOfOperationTimeSliceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EndTimeFactory);
    }

    public static CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime(this InnerHoursOfOperationHoursOfOperationConfigFactory parentFactory, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null)
    {
        parentFactory.StartTimeFactory = new InnerHoursOfOperationHoursOfOperationTimeSliceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StartTimeFactory);
    }

    public static CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1>(this CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2>(this CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2>(this CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2, T3, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2, T3>(this CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2, T3, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2, T3>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory, T3, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationConfigFactory, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2, T3, T4, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2, T3, T4>(this CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2, T3, T4, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory, T3, T4, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationConfigFactory, T4, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationConfigFactory, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerHoursOfOperationHoursOfOperationConfigFactory, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithEndTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHoursOfOperationHoursOfOperationConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1>(this CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2>(this CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2>(this CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2, T3, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2, T3>(this CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2, T3, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory, T3, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationConfigFactory, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2, T3, T4, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<InnerHoursOfOperationHoursOfOperationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2, T3, T4, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory, T3, T4, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationConfigFactory, T4, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationConfigFactory, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerHoursOfOperationHoursOfOperationConfigFactory, InnerHoursOfOperationHoursOfOperationTimeSliceFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHoursOfOperationHoursOfOperationConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T5, subFactoryAction));
}
