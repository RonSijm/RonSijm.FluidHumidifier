// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerHoursOfOperationRecurrenceConfigFactory(Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig>
{

    internal InnerHoursOfOperationRecurrencePatternFactory RecurrencePatternFactory { get; set; }

    protected override Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig Create()
    {
        var recurrenceConfigResult = CreateRecurrenceConfig();
        factoryAction?.Invoke(recurrenceConfigResult);

        return recurrenceConfigResult;
    }

    private Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig CreateRecurrenceConfig()
    {
        var recurrenceConfigResult = new Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig();

        return recurrenceConfigResult;
    }
    public override void CreateChildren(Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig result)
    {
        base.CreateChildren(result);

        result.RecurrencePattern ??= RecurrencePatternFactory?.Build();
    }

} // End Of Class

public static class InnerHoursOfOperationRecurrenceConfigFactoryExtensions
{
    public static CombinedResult<InnerHoursOfOperationRecurrenceConfigFactory, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern(this InnerHoursOfOperationRecurrenceConfigFactory parentFactory, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null)
    {
        parentFactory.RecurrencePatternFactory = new InnerHoursOfOperationRecurrencePatternFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecurrencePatternFactory);
    }

    public static CombinedResult<InnerHoursOfOperationRecurrenceConfigFactory, T1, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1>(this CombinedResult<InnerHoursOfOperationRecurrenceConfigFactory, T1> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHoursOfOperationRecurrenceConfigFactory, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1>(this CombinedResult<T1, InnerHoursOfOperationRecurrenceConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHoursOfOperationRecurrenceConfigFactory, T1, T2, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2>(this CombinedResult<InnerHoursOfOperationRecurrenceConfigFactory, T1, T2> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHoursOfOperationRecurrenceConfigFactory, T2, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2>(this CombinedResult<T1, InnerHoursOfOperationRecurrenceConfigFactory, T2> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHoursOfOperationRecurrenceConfigFactory, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2>(this CombinedResult<T1, T2, InnerHoursOfOperationRecurrenceConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHoursOfOperationRecurrenceConfigFactory, T1, T2, T3, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2, T3>(this CombinedResult<InnerHoursOfOperationRecurrenceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHoursOfOperationRecurrenceConfigFactory, T2, T3, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2, T3>(this CombinedResult<T1, InnerHoursOfOperationRecurrenceConfigFactory, T2, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHoursOfOperationRecurrenceConfigFactory, T3, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2, T3>(this CombinedResult<T1, T2, InnerHoursOfOperationRecurrenceConfigFactory, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHoursOfOperationRecurrenceConfigFactory, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHoursOfOperationRecurrenceConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHoursOfOperationRecurrenceConfigFactory, T1, T2, T3, T4, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2, T3, T4>(this CombinedResult<InnerHoursOfOperationRecurrenceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHoursOfOperationRecurrenceConfigFactory, T2, T3, T4, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2, T3, T4>(this CombinedResult<T1, InnerHoursOfOperationRecurrenceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHoursOfOperationRecurrenceConfigFactory, T3, T4, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHoursOfOperationRecurrenceConfigFactory, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHoursOfOperationRecurrenceConfigFactory, T4, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHoursOfOperationRecurrenceConfigFactory, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHoursOfOperationRecurrenceConfigFactory, InnerHoursOfOperationRecurrencePatternFactory> WithRecurrencePattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHoursOfOperationRecurrenceConfigFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrencePattern(combinedResult.T5, subFactoryAction).T2);
}
