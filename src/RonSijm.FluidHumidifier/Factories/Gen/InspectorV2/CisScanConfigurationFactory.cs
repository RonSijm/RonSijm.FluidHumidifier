// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class CisScanConfigurationFactory(string resourceName = null, Action<Humidifier.InspectorV2.CisScanConfiguration> factoryAction = null) : ResourceFactory<Humidifier.InspectorV2.CisScanConfiguration>(resourceName)
{

    internal InnerCisScanConfigurationScheduleFactory ScheduleFactory { get; set; }

    internal InnerCisScanConfigurationCisTargetsFactory TargetsFactory { get; set; }

    protected override Humidifier.InspectorV2.CisScanConfiguration Create()
    {
        var cisScanConfigurationResult = CreateCisScanConfiguration();
        factoryAction?.Invoke(cisScanConfigurationResult);

        return cisScanConfigurationResult;
    }

    private Humidifier.InspectorV2.CisScanConfiguration CreateCisScanConfiguration()
    {
        var cisScanConfigurationResult = new Humidifier.InspectorV2.CisScanConfiguration
        {
            GivenName = InputResourceName,
        };

        return cisScanConfigurationResult;
    }
    public override void CreateChildren(Humidifier.InspectorV2.CisScanConfiguration result)
    {
        base.CreateChildren(result);

        result.Schedule ??= ScheduleFactory?.Build();
        result.Targets ??= TargetsFactory?.Build();
    }

} // End Of Class

public static class CisScanConfigurationFactoryExtensions
{
    public static CombinedResult<CisScanConfigurationFactory, InnerCisScanConfigurationScheduleFactory> WithSchedule(this CisScanConfigurationFactory parentFactory, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null)
    {
        parentFactory.ScheduleFactory = new InnerCisScanConfigurationScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleFactory);
    }

    public static CombinedResult<CisScanConfigurationFactory, InnerCisScanConfigurationCisTargetsFactory> WithTargets(this CisScanConfigurationFactory parentFactory, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null)
    {
        parentFactory.TargetsFactory = new InnerCisScanConfigurationCisTargetsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetsFactory);
    }

    public static CombinedResult<CisScanConfigurationFactory, T1, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1>(this CombinedResult<CisScanConfigurationFactory, T1> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CisScanConfigurationFactory, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1>(this CombinedResult<T1, CisScanConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CisScanConfigurationFactory, T1, T2, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<CisScanConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CisScanConfigurationFactory, T2, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, CisScanConfigurationFactory, T2> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CisScanConfigurationFactory, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, T2, CisScanConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CisScanConfigurationFactory, T1, T2, T3, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<CisScanConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CisScanConfigurationFactory, T2, T3, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, CisScanConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CisScanConfigurationFactory, T3, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, CisScanConfigurationFactory, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CisScanConfigurationFactory, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, CisScanConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CisScanConfigurationFactory, T1, T2, T3, T4, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<CisScanConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CisScanConfigurationFactory, T2, T3, T4, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, CisScanConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CisScanConfigurationFactory, T3, T4, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, CisScanConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CisScanConfigurationFactory, T4, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CisScanConfigurationFactory, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CisScanConfigurationFactory, InnerCisScanConfigurationScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CisScanConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CisScanConfigurationFactory, T1, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1>(this CombinedResult<CisScanConfigurationFactory, T1> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CisScanConfigurationFactory, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1>(this CombinedResult<T1, CisScanConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CisScanConfigurationFactory, T1, T2, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2>(this CombinedResult<CisScanConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CisScanConfigurationFactory, T2, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2>(this CombinedResult<T1, CisScanConfigurationFactory, T2> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CisScanConfigurationFactory, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2>(this CombinedResult<T1, T2, CisScanConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CisScanConfigurationFactory, T1, T2, T3, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<CisScanConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CisScanConfigurationFactory, T2, T3, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, CisScanConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CisScanConfigurationFactory, T3, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, CisScanConfigurationFactory, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CisScanConfigurationFactory, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, CisScanConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CisScanConfigurationFactory, T1, T2, T3, T4, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<CisScanConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CisScanConfigurationFactory, T2, T3, T4, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, CisScanConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CisScanConfigurationFactory, T3, T4, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, CisScanConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CisScanConfigurationFactory, T4, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CisScanConfigurationFactory, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CisScanConfigurationFactory, InnerCisScanConfigurationCisTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CisScanConfigurationFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T5, subFactoryAction));
}
