// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class PortalFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.Portal> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.Portal>(resourceName)
{

    internal InnerPortalAlarmsFactory AlarmsFactory { get; set; }

    protected override Humidifier.IoTSiteWise.Portal Create()
    {
        var portalResult = CreatePortal();
        factoryAction?.Invoke(portalResult);

        return portalResult;
    }

    private Humidifier.IoTSiteWise.Portal CreatePortal()
    {
        var portalResult = new Humidifier.IoTSiteWise.Portal
        {
            GivenName = InputResourceName,
        };

        return portalResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.Portal result)
    {
        base.CreateChildren(result);

        result.Alarms ??= AlarmsFactory?.Build();
    }

} // End Of Class

public static class PortalFactoryExtensions
{
    public static CombinedResult<PortalFactory, InnerPortalAlarmsFactory> WithAlarms(this PortalFactory parentFactory, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null)
    {
        parentFactory.AlarmsFactory = new InnerPortalAlarmsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AlarmsFactory);
    }

    public static CombinedResult<PortalFactory, T1, InnerPortalAlarmsFactory> WithAlarms<T1>(this CombinedResult<PortalFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PortalFactory, InnerPortalAlarmsFactory> WithAlarms<T1>(this CombinedResult<T1, PortalFactory> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PortalFactory, T1, T2, InnerPortalAlarmsFactory> WithAlarms<T1, T2>(this CombinedResult<PortalFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PortalFactory, T2, InnerPortalAlarmsFactory> WithAlarms<T1, T2>(this CombinedResult<T1, PortalFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PortalFactory, InnerPortalAlarmsFactory> WithAlarms<T1, T2>(this CombinedResult<T1, T2, PortalFactory> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PortalFactory, T1, T2, T3, InnerPortalAlarmsFactory> WithAlarms<T1, T2, T3>(this CombinedResult<PortalFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PortalFactory, T2, T3, InnerPortalAlarmsFactory> WithAlarms<T1, T2, T3>(this CombinedResult<T1, PortalFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PortalFactory, T3, InnerPortalAlarmsFactory> WithAlarms<T1, T2, T3>(this CombinedResult<T1, T2, PortalFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PortalFactory, InnerPortalAlarmsFactory> WithAlarms<T1, T2, T3>(this CombinedResult<T1, T2, T3, PortalFactory> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PortalFactory, T1, T2, T3, T4, InnerPortalAlarmsFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<PortalFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PortalFactory, T2, T3, T4, InnerPortalAlarmsFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, PortalFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PortalFactory, T3, T4, InnerPortalAlarmsFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, T2, PortalFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PortalFactory, T4, InnerPortalAlarmsFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PortalFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PortalFactory, InnerPortalAlarmsFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PortalFactory> combinedResult, Action<Humidifier.IoTSiteWise.PortalTypes.Alarms> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T5, subFactoryAction));
}
