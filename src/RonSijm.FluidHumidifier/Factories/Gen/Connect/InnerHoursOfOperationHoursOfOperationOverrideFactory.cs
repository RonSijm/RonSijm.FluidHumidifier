// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerHoursOfOperationHoursOfOperationOverrideFactory(Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride> factoryAction = null) : SubResourceFactory<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride>
{

    internal InnerHoursOfOperationRecurrenceConfigFactory RecurrenceConfigFactory { get; set; }

    protected override Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride Create()
    {
        var hoursOfOperationOverrideResult = CreateHoursOfOperationOverride();
        factoryAction?.Invoke(hoursOfOperationOverrideResult);

        return hoursOfOperationOverrideResult;
    }

    private Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride CreateHoursOfOperationOverride()
    {
        var hoursOfOperationOverrideResult = new Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride();

        return hoursOfOperationOverrideResult;
    }
    public override void CreateChildren(Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride result)
    {
        base.CreateChildren(result);

        result.RecurrenceConfig ??= RecurrenceConfigFactory?.Build();
    }

} // End Of Class

public static class InnerHoursOfOperationHoursOfOperationOverrideFactoryExtensions
{
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationOverrideFactory, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig(this InnerHoursOfOperationHoursOfOperationOverrideFactory parentFactory, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null)
    {
        parentFactory.RecurrenceConfigFactory = new InnerHoursOfOperationRecurrenceConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecurrenceConfigFactory);
    }

    public static CombinedResult<InnerHoursOfOperationHoursOfOperationOverrideFactory, T1, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1>(this CombinedResult<InnerHoursOfOperationHoursOfOperationOverrideFactory, T1> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationOverrideFactory, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationOverrideFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationOverrideFactory, T1, T2, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2>(this CombinedResult<InnerHoursOfOperationHoursOfOperationOverrideFactory, T1, T2> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationOverrideFactory, T2, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationOverrideFactory, T2> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationOverrideFactory, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2>(this CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationOverrideFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationOverrideFactory, T1, T2, T3, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2, T3>(this CombinedResult<InnerHoursOfOperationHoursOfOperationOverrideFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationOverrideFactory, T2, T3, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2, T3>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationOverrideFactory, T2, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationOverrideFactory, T3, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationOverrideFactory, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationOverrideFactory, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationOverrideFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHoursOfOperationHoursOfOperationOverrideFactory, T1, T2, T3, T4, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2, T3, T4>(this CombinedResult<InnerHoursOfOperationHoursOfOperationOverrideFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHoursOfOperationHoursOfOperationOverrideFactory, T2, T3, T4, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerHoursOfOperationHoursOfOperationOverrideFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationOverrideFactory, T3, T4, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHoursOfOperationHoursOfOperationOverrideFactory, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationOverrideFactory, T4, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHoursOfOperationHoursOfOperationOverrideFactory, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHoursOfOperationHoursOfOperationOverrideFactory, InnerHoursOfOperationRecurrenceConfigFactory> WithRecurrenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHoursOfOperationHoursOfOperationOverrideFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecurrenceConfig(combinedResult.T5, subFactoryAction).T2);
}
