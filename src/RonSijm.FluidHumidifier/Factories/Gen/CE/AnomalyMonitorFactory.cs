// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CE;

public class AnomalyMonitorFactory(string resourceName = null, Action<Humidifier.CE.AnomalyMonitor> factoryAction = null) : ResourceFactory<Humidifier.CE.AnomalyMonitor>(resourceName)
{

    internal List<InnerAnomalyMonitorResourceTagFactory> ResourceTagsFactories { get; set; } = [];

    protected override Humidifier.CE.AnomalyMonitor Create()
    {
        var anomalyMonitorResult = CreateAnomalyMonitor();
        factoryAction?.Invoke(anomalyMonitorResult);

        return anomalyMonitorResult;
    }

    private Humidifier.CE.AnomalyMonitor CreateAnomalyMonitor()
    {
        var anomalyMonitorResult = new Humidifier.CE.AnomalyMonitor
        {
            GivenName = InputResourceName,
        };

        return anomalyMonitorResult;
    }
    public override void CreateChildren(Humidifier.CE.AnomalyMonitor result)
    {
        base.CreateChildren(result);

        result.ResourceTags = ResourceTagsFactories.Any() ? ResourceTagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AnomalyMonitorFactoryExtensions
{
    public static CombinedResult<AnomalyMonitorFactory, InnerAnomalyMonitorResourceTagFactory> WithResourceTags(this AnomalyMonitorFactory parentFactory, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null)
    {
        var factory = new InnerAnomalyMonitorResourceTagFactory(subFactoryAction);
        parentFactory.ResourceTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AnomalyMonitorFactory, T1, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1>(this CombinedResult<AnomalyMonitorFactory, T1> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyMonitorFactory, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1>(this CombinedResult<T1, AnomalyMonitorFactory> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnomalyMonitorFactory, T1, T2, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<AnomalyMonitorFactory, T1, T2> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyMonitorFactory, T2, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, AnomalyMonitorFactory, T2> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalyMonitorFactory, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, T2, AnomalyMonitorFactory> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnomalyMonitorFactory, T1, T2, T3, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<AnomalyMonitorFactory, T1, T2, T3> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyMonitorFactory, T2, T3, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, AnomalyMonitorFactory, T2, T3> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalyMonitorFactory, T3, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, AnomalyMonitorFactory, T3> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnomalyMonitorFactory, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnomalyMonitorFactory> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnomalyMonitorFactory, T1, T2, T3, T4, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<AnomalyMonitorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyMonitorFactory, T2, T3, T4, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, AnomalyMonitorFactory, T2, T3, T4> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalyMonitorFactory, T3, T4, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnomalyMonitorFactory, T3, T4> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnomalyMonitorFactory, T4, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnomalyMonitorFactory, T4> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnomalyMonitorFactory, InnerAnomalyMonitorResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnomalyMonitorFactory> combinedResult, Action<Humidifier.CE.AnomalyMonitorTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T5, subFactoryAction));
}
