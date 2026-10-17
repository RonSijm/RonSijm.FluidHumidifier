// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionRedshiftLineageSyncConfigurationInputFactory(Action<Humidifier.DataZone.ConnectionTypes.RedshiftLineageSyncConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.RedshiftLineageSyncConfigurationInput>
{

    internal InnerConnectionLineageSyncScheduleFactory ScheduleFactory { get; set; }

    protected override Humidifier.DataZone.ConnectionTypes.RedshiftLineageSyncConfigurationInput Create()
    {
        var redshiftLineageSyncConfigurationInputResult = CreateRedshiftLineageSyncConfigurationInput();
        factoryAction?.Invoke(redshiftLineageSyncConfigurationInputResult);

        return redshiftLineageSyncConfigurationInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.RedshiftLineageSyncConfigurationInput CreateRedshiftLineageSyncConfigurationInput()
    {
        var redshiftLineageSyncConfigurationInputResult = new Humidifier.DataZone.ConnectionTypes.RedshiftLineageSyncConfigurationInput();

        return redshiftLineageSyncConfigurationInputResult;
    }
    public override void CreateChildren(Humidifier.DataZone.ConnectionTypes.RedshiftLineageSyncConfigurationInput result)
    {
        base.CreateChildren(result);

        result.Schedule ??= ScheduleFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionRedshiftLineageSyncConfigurationInputFactoryExtensions
{
    public static CombinedResult<InnerConnectionRedshiftLineageSyncConfigurationInputFactory, InnerConnectionLineageSyncScheduleFactory> WithSchedule(this InnerConnectionRedshiftLineageSyncConfigurationInputFactory parentFactory, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null)
    {
        parentFactory.ScheduleFactory = new InnerConnectionLineageSyncScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleFactory);
    }

    public static CombinedResult<InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T1, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1>(this CombinedResult<InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T1> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1>(this CombinedResult<T1, InnerConnectionRedshiftLineageSyncConfigurationInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T1, T2, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T2, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, T2, InnerConnectionRedshiftLineageSyncConfigurationInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T1, T2, T3, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T2, T3, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T3, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionRedshiftLineageSyncConfigurationInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T1, T2, T3, T4, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T2, T3, T4, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T3, T4, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T4, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionRedshiftLineageSyncConfigurationInputFactory, InnerConnectionLineageSyncScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionRedshiftLineageSyncConfigurationInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T5, subFactoryAction).T2);
}
